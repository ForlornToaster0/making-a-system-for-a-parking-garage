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
            

            spot.Size = new Size(80, 40);
         
            spot.Location = new Point(100 * xPos, 50 * yPos);
            
           
            return spot;
        }
    }
}
