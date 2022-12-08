using Raylib_cs;
using System.Numerics;

class GameObject: ObjectPosition{
    public Vector2 Velocity = new Vector2(0, 5);
     Color theColor;

     public bool colorNumber;

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
    virtual public Rectangle GetRectangle()
    {
        return new Rectangle(4,3,2,1);
    }
    public bool  GetColor(){
        return colorNumber;
    }

}