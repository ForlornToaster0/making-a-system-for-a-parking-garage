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

            Vehicle[] list = new Vehicle[100];
       
            foreach (var car in carData)
            {
                switch (car.Type)
                {
                    case "MC":
                        {
                            MC mc = new(car.Reg, car.Arrival);
                            mc.VehicleCost = 10;
                            list[car.Spot-1] = mc;
                            break;
                        }
                    case "Car":
                        {
                            Car cars = new(car.Reg, car.Arrival);
                            cars.VehicleCost = 20;
                            list[car.Spot-1] = cars;
                            break;
                        }
                }
            }
            return list;
        }
    }
}
