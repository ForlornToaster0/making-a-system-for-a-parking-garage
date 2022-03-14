using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataInitialiser
    {
        public void InsertVehicle(string regNumber, int type, DateTime? parkTime)
        {
            using (var db = new testContext())
            {
                db.TestVehicles.Add(new testVehicle() { RegNumber = regNumber, Type = type, ParkTime = DateTime.Now });
                db.SaveChanges();
            }
        }

        public void RemoveVehicle(testVehicle vehicle)
        {
            using (var db = new testContext())
            {
                
            }
        }

        public void MoveVehicle(testVehicle vehicle, int newParkingId)
        {
            using (var db = new testContext())
            {
                
            }
        }
    }
}
