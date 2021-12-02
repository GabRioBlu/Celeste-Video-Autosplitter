using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Drawing;

namespace LiveSplit.ComponentUtil
{
    public static class ScreenGrabberUtils
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public static string GetWindowTitle()
        {
            IntPtr handle = GetForegroundWindow();
            StringBuilder buffer = new StringBuilder(256);

            if (GetWindowText(handle, buffer, 256) > 0)
            {
                return buffer.ToString();
            }
            return null;
        }

        public static Rectangle GetWindowSize()
        {
            IntPtr handle = GetForegroundWindow();

            GetWindowRect(handle, out RECT fullRect);
            GetClientRect(handle, out RECT clientRect);

            int borderWidth = ((fullRect.Right - fullRect.Left) - (clientRect.Right - clientRect.Left)) / 2;
            int borderHeight = ((fullRect.Bottom - fullRect.Top) - (clientRect.Bottom - clientRect.Top)) / 2;

            RECT trueRect = fullRect;
            trueRect.Left += borderWidth;
            trueRect.Top += borderHeight;
            trueRect.Right -= borderWidth;
            trueRect.Bottom -= borderHeight;

            Rectangle trueBounds = new Rectangle();
            trueBounds.X = trueRect.Left;
            trueBounds.Y = trueRect.Top;
            trueBounds.Width = trueRect.Right - trueRect.Left;
            trueBounds.Height = trueRect.Bottom - trueRect.Top;

            return trueBounds;
        }

        public static Bitmap CaptureWindow(Rectangle bounds)
        {
            Bitmap image = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics capture = Graphics.FromImage(image))
            {
                capture.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            return image;
        }
    }
}
