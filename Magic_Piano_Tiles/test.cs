using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PianoCheater.Helper
{
    public class WindowFinder
    {

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(IntPtr lpClassName, string lpWindowName);

        public static IntPtr GetPianoWindow()
        {

            return FindWindow(IntPtr.Zero, Helper.Global.WINDOW_NAME);
        }

    }
}