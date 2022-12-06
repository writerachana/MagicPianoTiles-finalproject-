using Raylib_cs;
using System.Numerics;
class Screen: ObjectColor
{
    int ScreenHeight;
    int ScreenWidth;

    Color white = Color.WHITE;
     Color black = Color.BLACK;

     int position1 = 0;
     int position2 = 120;
     int position3 = 240;
     int position4 = 360;

    List<GameObject> Objects = new List<GameObject>();
    

    
    Score score = new Score();
    public Screen(): base ()
    {
        ScreenHeight = 880;
        ScreenWidth = 480;
        var Tile1 = new Tile (white, position1);
        var Tile2 = new Tile (white, position2);
        var Tile3 = new Tile (black, position3);
        var Tile4 = new Tile (white, position4);
        Objects.Add(Tile1);
        Objects.Add(Tile2);
        Objects.Add(Tile3);
        Objects.Add(Tile4);
    }
    
    public void Run()
    {
        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);

        int timeIndex = 0;

        bool gameOver = false;

  
        while (!Raylib.WindowShouldClose())
        {
            if (!gameOver)
            {
                int deleteIndex = 0;
                int index = 0;
                bool delete = false;
                foreach (var obj in Objects)
                {
                    
                    
                    
                        obj.Move();
                    

                    index += 1;
                }

                if (delete)
                {
                    Objects.RemoveAt(deleteIndex);
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(backgroundColor);

                score.Draw();
                

                foreach (var obj in Objects)
                {
                    obj.Draw();
                }

                Raylib.EndDrawing();

                timeIndex += 1;

                if (timeIndex >= 3000)
                {
                    gameOver = true;
                }
            }

            else
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(backgroundColor);

                Raylib.DrawText("Game Over", ScreenWidth/2 -170, ScreenHeight/2 -70, 70, playerColor);
                Raylib.DrawText($"Score: {score.GetScore()}", ScreenWidth/2 -130, ScreenHeight/2, 50, playerColor);

                Raylib.EndDrawing();
            }
        }

        Raylib.CloseWindow();
    }

}