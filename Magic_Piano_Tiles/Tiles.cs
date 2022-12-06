using Raylib_cs;
using System.Numerics;

class Rock: GameObject
{
    int Size;

    public Rock(): base ()
    {
        Size = 17;
    }

    public override void Draw()
    {
        Raylib.DrawRectangle((int) Position.X, (int) Position.Y, Size, Size, theColor);
        
    }

    public override bool CheckCollision(Rectangle player)
    {
        return Raylib.CheckCollisionRecs (new Rectangle((int) Position.X, (int) Position.Y, Size, Size), player);
    }

}