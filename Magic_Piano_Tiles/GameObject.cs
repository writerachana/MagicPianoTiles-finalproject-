using Raylib_cs;
using System.Numerics;

class GameObject: ObjectPosition{
    public Vector2 Velocity = new Vector2(0, 0);
    protected Color theColor;

    public GameObject(): base()
    {
        Velocity.Y = 2 + random.Next(3);
        theColor = RandomColor();
        Position.Y = 0;
        Position.X = random.Next(800);

    }

    public void Move() 
    {
        Vector2 NewPosition = Position;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;
    }

    virtual public bool CheckCollision(Rectangle player)
    {
        return false;
    }

}