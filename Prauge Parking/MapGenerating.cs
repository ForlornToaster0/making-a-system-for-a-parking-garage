using Core;
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
        public IconButton[,] Creating(Phouse spots, Vehicle[] vehicles)
        {
            IconButton[,] map = new IconButton[spots.HouseSizeX, spots.HouseSizeY];
            int i = 0;
            for (int mapLenght = 0; mapLenght < spots.HouseSizeX; mapLenght++)
            {
                for (int x = 0; x < spots.HouseSizeY; x++)
                {
                    Pspots pspots = new();
                    map[x, mapLenght] = pspots.Modular(x, mapLenght);
                    map[x, mapLenght].Text = "Empty";
                    map[x, mapLenght].BackColor = Color.White;


                    if (vehicles[i] != null)
                    {



                        if (vehicles[i].GetType() == typeof(Car))
                        {
                            map[x, mapLenght].Text = $"Car\n{vehicles[x + mapLenght].RegNumber}";
                            map[x, mapLenght].BackColor = Color.Green;
                        }
                        else if (vehicles[i].GetType() == typeof(MC))
                        {
                            map[x, mapLenght].Text = $"MC\n{vehicles[x + mapLenght].RegNumber}";
                            map[x, mapLenght].BackColor = Color.Yellow;
                        }
                    }
                    i++;
                }
            }

            return map;
        }


    }
}


