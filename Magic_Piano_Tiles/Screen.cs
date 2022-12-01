using Raylib_cs;
using System.Numerics;
class Screen: ObjectColor
{
    int ScreenHeight;
    int ScreenWidth;
    List<GameObject> Objects = new List<GameObject>();
    

    Player player = new Player();
    Score score = new Score();
    public Screen(): base ()
    {
        ScreenHeight = 480;
        ScreenWidth = 800;
        var gem = new Gem ();
        Objects.Add(gem);
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
                    if (obj.CheckCollision(player.thePlayer))
                    {
                        score.AdjustScore(obj);
                        delete = true;
                        deleteIndex = index;
                    }
                    else
                    {
                        obj.Move();
                    }

                    index += 1;
                }

                if (delete)
                {
                    Objects.RemoveAt(deleteIndex);
                }

                player.Move();

                if (random.Next(7) == 1)
                {
                    int randNum = random.Next(2);
                    if (randNum == 1)
                    {
                        var rock = new Rock();
                        Objects.Add(rock);
                    }
                    else
                    {
                        var gem = new Gem ();
                        Objects.Add(gem);
                    }

                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(backgroundColor);

                score.Draw();
                player.Draw();

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