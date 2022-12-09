using System.Numerics;



using Raylib_cs;
// {
    public class MouseClickHelper{

        public bool IsMouseButtonPressed(){
             return Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT);
        }
        public Vector2 GetMousePosition(){
            return Raylib.GetMousePosition();
        }
        public MouseClickHelper(){


        }

    }


// bool IsMouseButtonPressed(int button);                      // Check if a mouse button has been pressed once
   
//     int GetMouseX(void);                                        // Get mouse position X
//     int GetMouseY(void);                                        // Get mouse position Y
   