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

        public List<Vehicle> NewCars()
        {
            var carData = DataExtration.AllData();

            List<Vehicle> list = new();
            int i = 0;
            foreach (var car in carData)
            {
                switch (car.Type)
                {
                    case "MC":
                        {
                            list.Add(new MC(car.Reg, car.Arrival));

                            break;
                        }
                    case "Car":
                        {
                            list.Add(new Car(car.Reg, car.Arrival));

                            break;
                        }
                }
            }
            return list;        
        }
        public List<ParkingSpots> parkings()
        {
            {
                var allData = DataExtration.AllData();
                List<ParkingSpots> parkings = new();
                foreach (var car in allData)
                {
                    parkings.Add(new ParkingSpots(0, car.Spot));
                }
                return parkings;
            }
        }
    }
}
