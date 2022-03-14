using Core.Configurations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public enum VehicleTypeEnum
    {
        MC = 1, CAR = 2
    }

    public class testVehicle
    {
        public static XML xml = new XML();
        public int ParkedOnSpot { get; set; }
        [Key]
        public string RegNumber { get; set; }
        public DateTime ParkTime { get; set; }
        public double VehicleCost { get; set; }
        public double VehicleSize { get; set; }
        public int Type { get; set; }

        //public testVehicle(string regNumber, int type, DateTime parkTime)
        //{

        //    this.RegNumber = regNumber;
        //    this.ParkTime = parkTime;
        //    this.Type = type;

        //}

    }
    public class Car : testVehicle
    {
        public Car(string regNumber, DateTime parkTime) 
        {
            VehicleCost = xml.cPrice;
            VehicleSize = xml.CarSize;
            RegNumber = regNumber;
            ParkTime = parkTime;
            Type = 2;
        }
    }
    public class MC : testVehicle
    {
        public MC(string regNumber, DateTime parkTime) 
        {
            VehicleCost = xml.mPrice;
            VehicleSize = xml.MCSize;
            RegNumber = regNumber;
            ParkTime = parkTime;
            Type = 1;
        }

    }
    public class Buss : testVehicle
    {
        public int VehicleCost { get; set; }
        public Buss(string regNumber, DateTime parkTime)
        {
            VehicleSize = 4 * 4;
        }
    }
    public class Cycle : testVehicle
    {
        public int VehicleCost { get; set; }
        public Cycle(string regNumber, DateTime parkTime) 
        {
            VehicleSize = 1;
        }
    }
}
