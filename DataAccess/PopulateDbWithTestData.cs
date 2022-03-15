using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class PopulateDbWithTestData
    {
        public void Populate()
        {
            string[] data = File.ReadAllLines("testdata.csv");

            List<string[]> testdata = data
                .Skip(1)
                .Select(x => x.Split(','))
                .ToList();

            using(var context = new testContext())
            {
                foreach (var item in testdata)
                {   
                    DBPspot vehicle = new();

                    vehicle.Spot = Convert.ToInt32(item[0]);
                    vehicle.Reg = Convert.ToString(item[1]);
                    vehicle.Arrival = Convert.ToDateTime(item[2]);
                    vehicle.Type = Convert.ToString(item[3]);
                    context.Pspots.Add(vehicle);
                }
                
                context.SaveChanges();
            }

        }


    }
}
