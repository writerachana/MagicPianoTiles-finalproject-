using Raylib_cs;
using System.Numerics;

class GameObject: ObjectPosition{
    public Vector2 Velocity = new Vector2(0, 5);
    protected Color theColor;

    public GameObject(): base()
    {
        
        theColor = RandomColor();
        Position.Y = 0;
       

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