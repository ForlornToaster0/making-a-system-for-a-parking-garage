using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Vehicle
    {
        public string RegNumber { get; set; }
        public DateTime ParkTime { get; set; }
        public int VehicleSize { get; protected set; }
        public Vehicle(string regNumber, DateTime parkTime)
        {

            RegNumber = regNumber;
            ParkTime = parkTime;

        }
    }
    public class Car : Vehicle
    {
        public int VehicleCost { get; set; }
        public Car(string regNumber, DateTime parkTime) : base(regNumber, parkTime)
        {
            VehicleSize = 4;
        }

    }
    public class MC : Vehicle
    {
        public int VehicleCost { get; set; }
        public MC(string regNumber, DateTime parkTime) : base(regNumber, parkTime)
        {
            VehicleSize = 2;
        }

    }
    public class Buss : Vehicle
    {
        public int VehicleCost { get; set; }
        public Buss(string regNumber, DateTime parkTime) : base(regNumber, parkTime)
        {
            VehicleSize = 4 * 4;
        }
    }
    public class Cycle : Vehicle
    {
        public int VehicleCost { get; set; }
        public Cycle(string regNumber, DateTime parkTime) : base(regNumber, parkTime)
        {
            VehicleSize = 1;
        }
    }
}
