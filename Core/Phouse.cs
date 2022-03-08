using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Phouse : ParkingSpots
    {
        public int HouseSizeX { get; set; }
        public int HouseSizeY { get; set; }
        public int SpotAmount { get; set; }
        public Phouse(int houseSizeX,int houseSizeY, int spotAmount) : base(houseSizeX, houseSizeY)
        {
            HouseSizeX = houseSizeX;
            HouseSizeY = houseSizeY;
            SpotAmount = spotAmount;
        }
    }
    public class ParkingSpots 
    {
        public int SpotSize { get; set; }   
        public int Position { get; set; }   
        public ParkingSpots(int spotSize, int pos) 
        {
            SpotSize = 4;
            Position = pos;
        }
    }

}
