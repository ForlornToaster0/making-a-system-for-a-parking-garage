using DataAccess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Inzilasing
    {

        public Vehicle[] NewCars()
        {
            var carData = DataExtration.AllData();

            Vehicle[] list = new Vehicle[carData.Length];
            int i = 0;
            foreach (var car in carData)
            {
                switch (car.Type)
                {
                    case "MC":
                        {
                            MC mc = new(car.Reg, car.Arrival);
                            mc.VehicleCost = 10;
                            list[i] = mc;
                            i++;
                            break;
                        }
                    case "Car":
                        {
                            Car cars = new(car.Reg, car.Arrival);
                            cars.VehicleCost = 20;
                            list[i] = cars;
                            i++;
                            break;
                        }
                }
            }
            return list;
        }
        public ParkingSpots[] parkings()
        {
            var par = NewCars();
            ParkingSpots[] parkings = new ParkingSpots[par.Length];
            
            for (int i = 0; i < parkings.Length; i++)
            {
                //parkings[i].Position = par[i];
            }
            return parkings;
        }
    }
}
