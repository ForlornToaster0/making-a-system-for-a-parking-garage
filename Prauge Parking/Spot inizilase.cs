using Core;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prauge_Parking.Moving_soon
{
    public class Spot_inizilase
    {
        public void SpotIni(List<ParkingSpots> spot, IconButton[] map, int spotSize)
        {
            for (int i = 0; i < spot.Count; i++)
            {
                int spotNum = spot[i].Position;

                if (spot[i].SpotSize == spotSize)
                {
                    map[spotNum - 1].BackColor = Color.Red;
                    break;
                }
                else if (spot[i].SpotSize == spotSize / 2)
                {
                    map[spotNum - 1].BackColor = Color.Yellow;
                    break;
                }
            }
        }
    }
}
