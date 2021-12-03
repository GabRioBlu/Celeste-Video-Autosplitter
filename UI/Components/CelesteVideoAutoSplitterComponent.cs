using LiveSplit.Model;
using LiveSplit.ComponentUtil;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using System.IO;

namespace LiveSplit.UI.Components
{
    public class CelesteVideoAutoSplitterComponent : IComponent
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        public CelesteVideoAutoSplitterSettings Settings { get; set; }

        public string ComponentName => "Celeste Video Splitter";

        public float HorizontalWidth  { get { return 0; } }
        public float MinimumHeight { get { return 0; } }
        public float VerticalHeight { get { return 0; } }
        public float MinimumWidth { get { return 0; } }

        public float PaddingTop { get { return 0; } }
        public float PaddingBottom { get { return 0; } }
        public float PaddingLeft { get { return 0; } }
        public float PaddingRight { get { return 0; } }

        public IDictionary<string, Action> ContextMenuControls => null;


        private string[] files;

        public VideoSplit CurrentSplit { get; set; }

        public TimerModel Model { get; set; }
        
        public Colour[][,] ImageBytes { get; set; }

        public CelesteVideoAutoSplitterComponent(LiveSplitState state)
        {
            Settings = new CelesteVideoAutoSplitterSettings();
            Model = new TimerModel() { CurrentState = state };

            SplitInit.InitSplits();
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion) {}

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion) {}

        public Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        unsafe private void GetSplitImageData()
        {
            files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Images\" + CurrentSplit.description);
            ImageBytes = new Colour[files.Length][,];

            for (int i = 0; i < files.Length; i++)
            {
                Image image = Image.FromFile(files[i]);
                Bitmap bitmap = new Bitmap(image);

                BitmapData bData = bitmap.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                byte bitsPerPixel = (byte)Image.GetPixelFormatSize(bData.PixelFormat);

                byte* scan0 = (byte*)bData.Scan0.ToPointer();

                int imageLeft = int.Parse(files[i].Split('\\').Last().Split('.')[0].Split('-')[1].Split('x')[0]);
                int imageTop = int.Parse(files[i].Split('\\').Last().Split('.')[0].Split('-')[1].Split('x')[1]);
                int imageRight = int.Parse(files[i].Split('\\').Last().Split('-')[0].Split('x')[0]) - imageLeft;
                int imageBottom = int.Parse(files[i].Split('\\').Last().Split('-')[0].Split('x')[1]) - imageTop;

                ImageBytes[i] = new Colour[imageRight - imageLeft, imageBottom - imageTop];

                for (int y = 0; y < bData.Height; ++y)
                {

                    for (int x = 0; x < bData.Width; ++x)
                    {
                        byte* data = scan0 + y * bData.Stride + x * bitsPerPixel / 8;

                        ImageBytes[i][x, y] = new Colour()
                        {
                            blue = data[0],
                            green = data[1],
                            red = data[2]
                        };
                    }
                }

                bitmap.UnlockBits(bData);
            }
        }

        unsafe private void CompareScreen(Rectangle windowBounds)
        {
            Bitmap screen = ScreenGrabberUtils.CaptureWindow(windowBounds);
            BitmapData screenData = screen.LockBits(new Rectangle(0, 0, windowBounds.Width, windowBounds.Height), ImageLockMode.ReadWrite, screen.PixelFormat);
            byte screenBitsPerPixel = (byte)Image.GetPixelFormatSize(screenData.PixelFormat);

            byte* screenScan0 = (byte*)screenData.Scan0.ToPointer();

            Colour[,] screenBytes = new Colour[windowBounds.Width, windowBounds.Height];

            for (int y = 0; y < screenData.Height; ++y)
            {
                for (int x = 0; x < screenData.Width; ++x)
                {
                    byte* data = screenScan0 + y * screenData.Stride + x * screenBitsPerPixel / 8;
                    screenBytes[x, y] = new Colour()
                    {
                        blue = data[0],
                        green = data[1],
                        red = data[2]
                    };
                }
            }

            screen.UnlockBits(screenData);

            float[] matchAmounts = new float[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                int imageLeft = int.Parse(files[i].Split('\\').Last().Split('.')[0].Split('-')[1].Split('x')[0]);
                int imageTop = int.Parse(files[i].Split('\\').Last().Split('.')[0].Split('-')[1].Split('x')[1]);

                float[] pixelSimilarities = new float[ImageBytes[i].Length];

                for (int x = 0; x < ImageBytes[i].GetLength(0); ++x)
                {
                    for (int y = 0; y < ImageBytes[i].GetLength(1); ++y)
                    {
                        float pixelSimilarity = ImageBytes[i][x, y].Compare(screenBytes[x + imageLeft, y + imageTop]);
                        pixelSimilarities[x * ImageBytes[i].GetLength(1) + y] = pixelSimilarity;
                    }
                }

                float imageSimilarity = 0f;
                imageSimilarity += pixelSimilarities.Sum();
                imageSimilarity /= pixelSimilarities.Length;
                matchAmounts[i] = imageSimilarity;
            }

            float totalConfidence = 0f;
            totalConfidence = matchAmounts.Sum();
            totalConfidence /= matchAmounts.Length;

            using (StreamWriter w = File.AppendText(Directory.GetCurrentDirectory() + @"\log.txt"))
            {
                w.Write($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
                w.Write(" :");
                w.WriteLine($" {totalConfidence}");
            }

            if (totalConfidence > 0.85f)
            {
                if (CurrentSplit.pauseTimer)
                {
                    Model.Pause();
                }
                if (CurrentSplit.splitTimer)
                {
                    Model.Split();
                }
                if (CurrentSplit.startTimer)
                {
                    Model.Start();
                }
            }
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (ScreenGrabberUtils.GetWindowTitle() == "Celeste.exe")
            {
                Rectangle windowBounds = ScreenGrabberUtils.GetWindowSize();

                CompareScreen(windowBounds);
            }
        }

        public void Dispose()
        {

        }
    }
}