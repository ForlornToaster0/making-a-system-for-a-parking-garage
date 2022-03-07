
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
        public static DBPspot[] AllData()
        {
            using testContext Context = new();
            {
                var data = Context.Pspots.Select(s => s).ToArray();
                return data;
            }
        }
    }
}
