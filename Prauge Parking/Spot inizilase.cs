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
        public void SpotIni(List<ParkingSpots> spot, List<Vehicle> vehicles, IconButton[] map, int spotSize)
        {
            for (int i = 0; i < vehicles.Count; i++)
            {
                int spotNum = spot[i].Position;
                if (spot[i].SpotSize < spotSize && spot[i].SpotSize > 0)
                {
                    var substr = map[spotNum].Text;
                    map[spotNum - 1].Text = $"{substr}{vehicles[i].RegNumber}";
                }
                else if (vehicles[i].GetType() == typeof(Car))
                {
                    map[spotNum - 1].Text = $"{spotNum}:{vehicles[i].RegNumber}";
                    map[spotNum - 1].BackColor = Color.Green;
                    spot[i].SpotSize += vehicles[i].VehicleSize;
                }
                else if (vehicles[i].GetType() == typeof(MC))
                {
                    map[spotNum - 1].Text = $"{spotNum}:{vehicles[i].RegNumber}";
                    map[spotNum - 1].BackColor = Color.Yellow;

                    spot[i].SpotSize += vehicles[i].VehicleSize;
                }

            }
        }
    }
}
