// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Runtime.InteropServices;
// using System.Text;
// using System.Threading.Tasks;

// namespace PianoCheater.Helper
using Raylib_cs;
// {
    public class MouseClickHelper{

        public bool IsMouseButtonPressed(){
             return Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_RIGHT);
        }
        public MouseClickHelper(){


        }

    }
//     {

//         [DllImport("user32.dll")]
//         static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);


//         public static void MouseClick()
//         {
//             mouse_event(Global.MOUSEEVENTF_LEFTDOWN, 0,0,0,0);
//             mouse_event(Global.MOUSEEVENTF_LEFTUP, 0,0,0,0);
//         }



//     }
// };

// bool IsMouseButtonPressed(int button);                      // Check if a mouse button has been pressed once
   
//     int GetMouseX(void);                                        // Get mouse position X
//     int GetMouseY(void);                                        // Get mouse position Y
   