using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AddToDB
    {
        public List<Vehicle>  AddVechicle(List<Vehicle> vehicles)
        {
            vehicles.Add(new Car("ahe203",DateTime.Now));
            return vehicles;
        }
        public List<ParkingSpots> AddSpot(List<ParkingSpots> vehicles)
        {
            vehicles.Add(new ParkingSpots(4,40));
            return vehicles;
        }
    }
}
