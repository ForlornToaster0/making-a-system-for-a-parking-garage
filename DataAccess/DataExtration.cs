using DeleteMe.Data;
using DeleteMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataExtration
    {
        public string?[] Reg()
        {
            using var context = new testContext();
            {
                
                var reg = context.Pspots.Select(s=> s.Reg).ToArray();
                return reg;
            }
        }
        public string?[] Type()
        {
            using var context = new testContext();
            {

                var type = context.Pspots.Select(s => s.Type).ToArray();
                return type;
            }
        }
    }
}
