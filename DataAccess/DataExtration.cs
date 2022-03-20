
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
        public static int[] AllData()
        {
            using testContext Context = new();
            {
                var data = Context.Pspots.Select(s => s).Select(s=>s.Spot).Distinct().ToArray();
                return data;
            }
        }
        public static DBPspot[] spotVechales(int pos)
        {
            using testContext Context = new();
            {
                var vechailelist = Context.Pspots.Where(x => x.Spot == pos).ToArray();
                return vechailelist;
            }

        }
    }
}
