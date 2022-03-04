using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class vehicle
    {
        public string? RegNumber { get; set; }
        public string? VehicleType { get; set; }
        public DateTime ParkTime { get; set; }
        public int ParkedOnSpot { get; set; }
    }
    public class Car : vehicle
    {
        public int VehicleCost { get; set; }
        public int VehicleSize { get; set; }
    }
    public class MC : vehicle
    {
        public int VehicleCost { get; set; }
        public int VehicleSize { get; set; }
    }
}
