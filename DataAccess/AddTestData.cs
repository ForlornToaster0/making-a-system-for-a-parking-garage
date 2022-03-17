using DataAccess.Data;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AddTestData
    {
        public static void AddVehicles()
        {
            var context = new testContext();


            DBPspot[] pspot = new DBPspot[] {
                    new DBPspot {  Spot = 40,
                    Reg = "ABC123",
                    Arrival = new DateTime(2022, 01, 01),
                    Type = "2"},
                    new DBPspot {  Spot = 24,
                    Reg = "ACC123",
                    Arrival = new DateTime(2022, 01, 07),
                    Type = "2" },
                    new DBPspot {  Spot = 3,
                    Reg = "ACD123",
                    Arrival = new DateTime(2022, 01, 06),
                    Type = "1" },
                    new DBPspot {  Spot = 27,
                    Reg = "ACB223",
                    Arrival = new DateTime(2022, 01, 04),
                    Type = "2" },
                    new DBPspot {  Spot = 88,
                    Reg = "CCC123",
                    Arrival = new DateTime(2022, 01, 03),
                    Type = "2" },
                    new DBPspot {  Spot = 33,
                    Reg = "ECC123",
                    Arrival = new DateTime(2022, 01, 02),
                    Type = "2" },
                    new DBPspot {  Spot = 51,
                    Reg = "DCC123",
                    Arrival = new DateTime(2022, 04, 01),
                    Type = "2" },
                    new DBPspot {  Spot = 55,
                    Reg = "RCC123",
                    Arrival = new DateTime(2022, 05, 01),
                    Type = "2" },
                    new DBPspot {  Spot = 65,
                    Reg = "TCC123",
                    Arrival = new DateTime(2022, 03, 01),
                    Type = "1" },
                    new DBPspot {  Spot = 18,
                    Reg = "QCC123",
                    Arrival = new DateTime(2022, 01, 01),
                    Type = "1" } };
            context.AddRange(pspot);
            context.SaveChanges();

        }
    }
}
