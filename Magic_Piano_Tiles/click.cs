using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PianoCheater.Helper
{
    public class MouseClickHelper
    {

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


        public static void MouseClick()
        {
            mouse_event(Global.MOUSEEVENTF_LEFTDOWN, 0,0,0,0);
            mouse_event(Global.MOUSEEVENTF_LEFTUP, 0,0,0,0);
        }



    }
}
