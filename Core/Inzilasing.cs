using DataAccess;
using DataAccess.Models;
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


        public List<ParkingSpots> ParkingHouse()
        {
            var allData = DataExtration.AllData();
            List<ParkingSpots> list = new();

            foreach (var Position in allData)
            {
                int size = 0;
                List<Vehicle> vehicleList = new();
                var DBData = DataExtration.spotVechales(Position);
                foreach (var Data in DBData)
                {
                    vehicleList.AddRange(NewCars(Data.Reg, Data.Arrival, int.Parse(Data.Type)));
                }
                foreach (var Data in vehicleList)
                {
                    size =size + Data.VehicleSize;
                }
                
                if (vehicleList.Count > 0)
                {
                    list.Add(new ParkingSpots(size, Position, vehicleList));
                }
            }
            return list;


        }
        public List<Vehicle> NewCars(string reg, DateTime arrival, int type)
        {

            List<Vehicle> list = new();

            
                switch (type)
                {
                    case 1:
                        {
                            list.Add(new MC(reg, arrival));

                            break;
                        }
                    case 2:
                        {
                            list.Add(new Car(reg, arrival));

                            break;
                        }
                }

                return list;
            
        }
        public object[] DetailedList(ParkingSpots spot, Vehicle vehicles, int[] Prize)
        {
            double priceAmount = 0;
            var span = Math.Round(DateTime.Now.Subtract(vehicles.ParkTime.AddMinutes(10)).TotalHours);
            if (vehicles.GetType() == typeof(Car))
            {
                priceAmount = span * Prize[1];
            }
            else if (vehicles.GetType() == typeof(MC))
            {
                priceAmount = span * Prize[0];
            }
            object[] row = new object[4] { spot.Position, vehicles.RegNumber, vehicles.ParkTime, priceAmount };
            return row;

        }

    }
}
