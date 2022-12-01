using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PianoCheater.Functions
{
    public class PianoTilesChecker
    {
        public static bool PianoLocationChecker(int x, int y)
        {
            using (Bitmap bitmap = new Bitmap(1,1))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(new Point(x, y), new Point(0,0), new Size(1,1));
                }

                if (bitmap.GetPixel(0, 0).R.ToString("X") + bitmap.GetPixel(0, 0).G.ToString("X") +
                    bitmap.GetPixel(0, 0).B.ToString("X") == "3B383F")
                {
                    return true;
                }
                return false;
            }

        }
    }


}