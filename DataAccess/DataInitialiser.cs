﻿using DataAccess.Data;
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
        public void InsertVehicle(string regNumber, int type, int spot)
        {
            using (var db = new testContext())
            {
                db.Pspots.Add(new DBPspot() { Reg = regNumber, Type = Convert.ToString(type), Arrival = DateTime.Now, Spot = spot });
                db.SaveChanges();
            }
        }

        public void RemoveVehicle(DBPspot vehicle)
        {
            using (var db = new testContext())
            {
                
            }
        }

        public void MoveVehicle(DBPspot vehicle, int newParkingId)
        {
            using (var db = new testContext())
            {
                
            }
        }
    }
}
