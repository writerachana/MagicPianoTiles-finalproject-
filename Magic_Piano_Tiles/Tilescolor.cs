using Raylib_cs;
using System.Numerics;


class ObjectColor {
   protected Random random = new Random();
   protected List<Color> ColorsList = new List<Color>();
   protected Color[] colors = { Color.WHITE, Color.BLACK};

   protected Color backgroundColor;
   protected Color playerColor;

   public ObjectColor()
   {
      backgroundColor = Color.BLUE;
      playerColor = Color.WHITE;
      ColorsList.AddRange(colors);
   }

   public Color RandomColor()
   {
      int randIndex = random.Next(ColorsList.Count());
      Color thecolor = ColorsList[randIndex];
      return thecolor;
   }

}