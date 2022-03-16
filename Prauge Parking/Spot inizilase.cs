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
                for (int j = 0; j < spot.Count; j++)
                    if (spot[j].Position == spot[i].Position&&j!=i&& spot[j].SpotSize+spot[i].SpotSize<spotSize)
                    {
                        var substr = map[spotNum].Text;
                        map[spotNum - 1].Text = $"{substr}{vehicles[i].RegNumber}";
                        map[spotNum - 1].BackColor = Color.Green;
                        break;
                    }
                    else if (vehicles[i].GetType() == typeof(Car))
                    {
                        map[spotNum - 1].Text = $"{spotNum}:{vehicles[i].RegNumber}";

                        spot[i].SpotSize += vehicles[i].VehicleSize;
                        map[spotNum - 1].BackColor = Color.Green;
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
