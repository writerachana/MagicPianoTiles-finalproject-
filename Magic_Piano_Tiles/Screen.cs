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

    MouseClickHelper click = new MouseClickHelper();

    List<GameObject> Objects = new List<GameObject>();
    

    
    Score score = new Score();
    public Screen(): base ()
    {
        ScreenHeight = 880;
        ScreenWidth = 480;
        var Tile1 = new Tile (white, position1, false);
        var Tile2 = new Tile (white, position2,false);
        var Tile3 = new Tile (black, position3,true);
        var Tile4 = new Tile (white, position4,false);
        Objects.Add(Tile1);
        Objects.Add(Tile2);
        Objects.Add(Tile3);
        Objects.Add(Tile4);
    }
    
    public void Run()
    {
        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);

        

        bool gameOver = false;
        int count = 0;

  
        while (!Raylib.WindowShouldClose())
        {
            if (!gameOver)
            {


                  
                    if (count == 55){
                        Random random = new Random();
                        int randomnumber = random.Next(4);
                        var Tile1 = new Tile (black, position1, true);
                        var Tile2 = new Tile (white, position1, false);
                        var Tile3 = new Tile (black, position1, false);
                        var Tile4 = new Tile (black, position1, false);
                        
                        if (randomnumber == 0){
                             Tile1 = new Tile (black, position1,true);
                             Tile2 = new Tile (white, position2,false);
                             Tile3 = new Tile (white, position3, false);
                             Tile4 = new Tile (white, position4,false);
                        }
                        else if (randomnumber == 1){
                             Tile1 = new Tile (white, position1,false);
                             Tile2 = new Tile (black, position2,true);
                             Tile3 = new Tile (white, position3,false);
                             Tile4 = new Tile (white, position4,false);
                        }

                        else if (randomnumber == 2){
                             Tile1 = new Tile (white, position1,false);
                             Tile2 = new Tile (white, position2,false);
                             Tile3 = new Tile (black, position3,true);
                             Tile4 = new Tile (white, position4,false);
                        }

                        else  {
                             Tile1 = new Tile (white, position1,false);
                             Tile2 = new Tile (white, position2,false);
                             Tile3 = new Tile (white, position3,false);
                             Tile4 = new Tile (black, position4,true);
                        }

                       
                        
                        // var Tile1 = new Tile (white, position1);
                        // var Tile2 = new Tile (white, position2);
                        // var Tile3 = new Tile (black, position3);
                        // var Tile4 = new Tile (white, position4);
                        Objects.Add(Tile1);
                        Objects.Add(Tile2);
                        Objects.Add(Tile3);
                        Objects.Add(Tile4); 

                        count = 0;


                    

                }
                  count +=1;

                foreach (var obj in Objects)
            
                {
                    obj.Move();
                }
                Vector2 MousePosition = click.GetMousePosition();
                bool IsMouseButtonPressed = click.IsMouseButtonPressed();

                if (IsMouseButtonPressed){
                    bool adjustscore = false;
                    GameObject therectangle = new GameObject();
                    foreach (var obj in Objects){
                        Rectangle rectangle = obj.GetRectangle();
                        adjustscore =  Raylib.CheckCollisionPointRec(MousePosition, rectangle); 
                        if (adjustscore){
                            therectangle = obj;
                        }
    
                    }
                    if (adjustscore){
                        gameOver = score.AdjustScore(therectangle);
                    }
                }



             

                Raylib.BeginDrawing();
                Raylib.ClearBackground(backgroundColor);

                
                

                foreach (var obj in Objects)
                {
                    obj.Draw();
                }
                score.Draw();

                Raylib.EndDrawing();

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