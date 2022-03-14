using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataImport
    {
        public void import(DateTime arrived,string type,string reg,int spot)
        {
            using(var context = new testContext())
            {
                DBPspot pspot = new();
                pspot.Arrival = arrived;
                pspot.Type = type;
                pspot.Reg = reg;
                pspot.Spot = spot;
                context.Pspots.Add(pspot);
                context.SaveChanges();  
            }
        }
    }
}
