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
        public IconButton[] Creating(Phouse house)
        {
            IconButton[] map = new IconButton[house.SpotAmount];
            int i = 0;
            for (int mapLenght = 0; mapLenght < house.HouseSizeX; mapLenght++)
            {
                for (int x = 0; x < house.HouseSizeY; x++)
                {
                    string newName = $"MapSpot{i}";

                    Pspots pspots = new();
                    map[i] = pspots.Modular(x, mapLenght);
                    map[i].Text = $"{i}";
                    map[i].BackColor = Color.White;
                    map[i].BringToFront();
                    map[i].Name = newName;
                    i++;
                }
            }
            return map;
        }


    }
}


