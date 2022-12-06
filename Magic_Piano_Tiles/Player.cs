using Raylib_cs;
using System.Numerics;

class Player: ObjectPosition{

    int MovementSpeed;
    public Rectangle thePlayer;

    int Size;

    public Player(): base()
    {
        Size = 30;
        MovementSpeed = 4;
        thePlayer.x = 390;
        thePlayer.y = 420;
        thePlayer.width = Size;
        thePlayer.height = Size;
        Position.X = thePlayer.x;
        Position.Y = thePlayer.y;
    }

    public void Move()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
            Position.X += MovementSpeed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
            Position.X -= MovementSpeed;
        }

        // if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
            // Position.Y -= MovementSpeed;
        // }
        
        // if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
            // Position.Y += MovementSpeed;
        // }


        thePlayer.x = Position.X;
    }

    public override void Draw()
    {
        Raylib.DrawRectangleLines((int)Position.X, (int)Position.Y, Size, Size, playerColor);

    }
}