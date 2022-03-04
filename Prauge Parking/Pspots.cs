using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prauge_Parking
{
    public class Pspots
    {
        public IconButton Modular(string vehicle, string reg, int xPos, int yPos)
        {
            IconButton spot = new();
            spot.Text = "Empty";

            spot.Size = new Size(80, 40);
         
            spot.Location = new Point(100 * xPos, 50 * yPos);
            
            spot.BackColor = Color.White;
            return spot;
        }
    }
}
