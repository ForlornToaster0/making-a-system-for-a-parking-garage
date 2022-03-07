
using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataExtration
    {
        public static Pspot[] CarData()
        {
            using testContext Context = new();
            {
                var data = Context.Pspots.Select(s=>s).Where(p=>p.Type=="Car").ToArray();
                return data;
            }
        }
        public static Pspot[] MCData()
        {
            using testContext Context = new();
            {
                var data = Context.Pspots.Select(s => s).Where(p => p.Type == "MC").ToArray();
                return data;
            }
        }
    }
}
