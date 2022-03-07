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
        {
            HouseSizeX = houseSizeX;
            HouseSizeY = houseSizeY;
            SpotAmount = spotAmount;
        }
    }
    public class ParkingSpots : Phouse
    {
        public int SpotSize { get; set; }   
        public ParkingSpots(int houseSizeX, int houseSizeY, int spotAmount, int spotSize) : base(houseSizeX , houseSizeY, spotAmount)
        {
            SpotSize = spotSize;
            
        }
    }

}
