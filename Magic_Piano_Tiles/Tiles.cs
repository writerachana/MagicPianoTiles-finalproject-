using Raylib_cs;
using System.Numerics;

class Tile: GameObject
{
    int width;
    int height;

    Color Color;

    public Tile(Color color, int xposition, bool ColorNumber): base ()
    {
        width = 120;
        height =293;
        Color = color;
        Position.X = xposition;
        Position.Y = -300;
        colorNumber = ColorNumber; 

    }

    public override void Draw()
    {
        Raylib.DrawRectangle((int) Position.X, (int) Position.Y, width, height, Color);
        
    }

    public override bool CheckCollision(Rectangle player)
    {
        return Raylib.CheckCollisionRecs (new Rectangle((int) Position.X, (int) Position.Y, width, height), player);
    }
    public override Rectangle GetRectangle()
    {
        return new Rectangle((int) Position.X, (int) Position.Y, width, height);
    }

}