using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Inzilasing
    {
        public Car[] Cars()
        {
            var carData = DataExtration.CarData();

            Car[] list = new Car[carData.Length];
            int i=0;
            foreach (var car in carData)
            {

                Car cars = new(car.Reg, car.Arrival);
                cars.VehicleCost = 20;
                list[i] = cars;
                i++;
            }
            return list;
        }
        public MC[] MC()
        {
            var mcData = DataExtration.MCData();

            MC[] list = new MC[mcData.Length];
            int i = 0;
            foreach (var mc in mcData)
            {

                MC mcs = new(mc.Reg, mc.Arrival);
                mcs.VehicleCost = 20;
                list[i] = mcs;
                i++;
            }
            return list;
        }
    }
}
