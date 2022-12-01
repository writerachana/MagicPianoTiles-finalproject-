


using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 600;
            var BallPosition = new Vector2(ScreenHeight / 2, ScreenWidth / 2);
            var BallMovementSpeed = 4;
            float BallRadius = 50;

            Raylib.InitWindow(ScreenHeight, ScreenWidth, "Ball");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Move the ball with the arrow keys!", 12, 12, 20, Color.BLUE);

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    BallPosition.X += BallMovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    BallPosition.X -= BallMovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                    BallPosition.Y -= BallMovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                    BallPosition.Y  += BallMovementSpeed;
                }

                Raylib.DrawCircleV(BallPosition, BallRadius, Color.YELLOW);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
