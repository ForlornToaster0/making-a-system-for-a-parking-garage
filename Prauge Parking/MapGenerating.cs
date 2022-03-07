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
        public IconButton[,] Creating(ParkingSpots spots, Vehicle[] vehicles)
        {
            IconButton[,] map = new IconButton[spots.HouseSizeX, spots.HouseSizeY];

            for (int mapLenght = 0; mapLenght < spots.HouseSizeX; mapLenght++)
            {
                for (int x = 0; x < spots.HouseSizeY; x++)
                {
                    Pspots pspots = new();
                    if (vehicles.GetType() == typeof(Car))
                    {
                        map[x, mapLenght] = pspots.Modular("Car", vehicles[x+ mapLenght].RegNumber, x, mapLenght);
                    }
                    else if (vehicles.GetType() == typeof(MC))
                    {

                    }
                }
            }
            return map;
        }
    }
}
