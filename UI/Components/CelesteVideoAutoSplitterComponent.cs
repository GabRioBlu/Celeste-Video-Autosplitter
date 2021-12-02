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


        public TimerModel Model { get; set; }

        public IDictionary<string, Action> ContextMenuControls => null;

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

        unsafe private void DoStuff(VideoSplit currentVideoSplit)
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\Images\" + currentVideoSplit.description);
            float[] matchAmounts = new float[files.Length];
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

                Colour[,] imageBytes = new Colour[imageRight + imageLeft, imageBottom + imageTop];

                for (int j = 0; j < bData.Height; ++j)
                {
                    if (j >= imageTop && j <= imageBottom)
                    {

                        for (int k = 0; k < bData.Width; ++k)
                        {
                            if (k >= imageLeft && k <= imageRight)
                            {
                                byte* data = scan0 + j * bData.Stride + k * bitsPerPixel / 8;

                                imageBytes[k, j] = new Colour()
                                {
                                    blue = data[0],
                                    green = data[1],
                                    red = data[2]
                                };
                            }
                        }
                    }
                }

                bitmap.UnlockBits(bData);
            }
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (ScreenGrabberUtils.GetWindowTitle() == "Celeste.exe")
            {
                Rectangle windowBounds = ScreenGrabberUtils.GetWindowSize();
                VideoSplit currentVideoSplit = SplitInit.possibleSplits.ElementAt(Model.CurrentState.CurrentSplitIndex);

                DoStuff(currentVideoSplit);
            }
        }

        public void Dispose()
        {
            
        }
    }
}