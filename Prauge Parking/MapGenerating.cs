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
        public IconButton[,] Creating(ParkingSpots[] spot,Phouse house, Vehicle[] vehicles)
        {
            IconButton[,] map = new IconButton[house.HouseSizeX, house.HouseSizeY];
            int i = 0;
            for (int mapLenght = 0; mapLenght < house.HouseSizeX; mapLenght++)
            {
                for (int x = 0; x < house.HouseSizeY; x++)
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


