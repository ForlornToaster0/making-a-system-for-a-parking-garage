using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prauge_Parking
{
    internal class MapGenerating
    {
        public IconButton[,] Creating(int width, int length, string[] veicle, string[] reg)
        {
            IconButton[,] map = new IconButton[width ,length];

            for (int mapLenght = 0; mapLenght < length; mapLenght++)
            {
                for (int x = 0; x < width; x++)
                {
                    Pspots pspots = new();
                    map[x, mapLenght] = pspots.Modular(null,null, x, mapLenght);                  
                }              
            }
            return map;
        }
    }
}
