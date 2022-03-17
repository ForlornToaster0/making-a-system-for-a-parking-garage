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
            
            foreach (var car in carData)
            {
                switch (car.Type)
                {
                    case "1":
                        {
                            list.Add(new MC(car.Reg, car.Arrival));

                            break;
                        }
                    case "2":
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
        public object[] DetailedList(ParkingSpots spot, Vehicle vehicles, int Prize)
        {
            double priceAmount = 0;
            var span = Math.Round(DateTime.Now.Subtract(vehicles.ParkTime.AddMinutes(10)).TotalHours);
            if (vehicles.GetType() == typeof(Car))
            {
                priceAmount = span * Prize;

            }
            else if (vehicles.GetType() == typeof(MC))
            {
                priceAmount = span * (Prize / 2);


            }
            object[] row = new object[4] { spot.Position, vehicles.RegNumber, vehicles.ParkTime,priceAmount };
            return row;

        }
    }
}
