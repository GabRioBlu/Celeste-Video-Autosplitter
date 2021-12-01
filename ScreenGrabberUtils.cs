using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LiveSplit.ComponentUtil
{
    class ScreenGrabberUtils
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

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
    }
}
