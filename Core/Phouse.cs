using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Phouse 
    {
        public int HouseSizeX { get; set; }
        public int HouseSizeY { get; set; }
        public int SpotAmount { get; set; }
        
        public Phouse(int houseSizeX,int houseSizeY, int spotAmount)
        {;
            this.HouseSizeX = houseSizeX;
            this.HouseSizeY = houseSizeY;
            this.SpotAmount = spotAmount;
        }
    }
    public class ParkingSpots 
    {
        public List<Vehicle> Vehicle { get; set; }
        public int SpotSize { get; set; }   
        public int Position { get; set; }   
        public ParkingSpots(int spotSize, int pos, List<Vehicle> vehicles) 
        {
            this.Vehicle = vehicles;
            SpotSize = 0;
            Position = pos;
        }
    }

}
