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
        public IconButton Modular( int xPos, int yPos)
        {
            IconButton spot = new();
            

            spot.Size = new Size(70, 30);
         
            spot.Location = new Point(80 * xPos, 30 * yPos);
            
           
            return spot;
        }
    }
}
