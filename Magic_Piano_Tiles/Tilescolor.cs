using Raylib_cs;
using System.Numerics;


class ObjectColor {
   protected Random random = new Random();
   protected List<Color> ColorsList = new List<Color>();
   protected Color[] colors = { Color.LIGHTGRAY, Color.GRAY, Color.DARKGRAY, Color.YELLOW, Color.GOLD, Color.ORANGE, Color.PINK, Color.RED, Color.MAROON, Color.GREEN, Color.LIME, Color.DARKGREEN, Color.SKYBLUE, Color.BLUE, Color.DARKBLUE, Color.PURPLE, Color.VIOLET, Color.DARKPURPLE, Color.BEIGE, Color.BROWN, Color.DARKBROWN};

   protected Color backgroundColor;
   protected Color playerColor;

   public ObjectColor()
   {
      backgroundColor = Color.BLACK;
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