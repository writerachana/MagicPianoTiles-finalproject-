using Raylib_cs;
using System.Numerics;

class Score: ObjectPosition
{
    int theScore;
    public Score(): base ()
    {
        theScore = 0;
        Position.Y = 25;
        Position.X = 25;
    }

    public override void Draw()
    {
        string text = theScore.ToString();
        Raylib.DrawText((string) text, (int) Position.X, (int) Position.Y, 40, Color.BLACK);
    }

    public bool AdjustScore(GameObject theObject)
    {
        
        if (theObject.GetColor() == true)
        {
            theScore += 10;
            return false;
        }
        else
        {
            return true;
        }
    }

    public int GetScore()
    {
        return theScore;
    }

}