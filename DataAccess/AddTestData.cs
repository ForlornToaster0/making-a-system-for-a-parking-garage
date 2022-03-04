using DataAccess.Models;
using DeleteMe.Data;
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
            using (var context = new testContext())
            {
                Pspot[] pspot = new Pspot[] {
                    new Pspot {  Spot = 1,
                    Reg = "ABC123",
                    Arrival = new DateTime(2020, 01, 01),
                    Type = "Car"},
                    new Pspot {  Spot = 2,
                    Reg = "ACC123",
                    Arrival = new DateTime(2020, 01, 07),
                    Type = "Car" },
                    new Pspot {  Spot = 3,
                    Reg = "ACD123",
                    Arrival = new DateTime(2020, 01, 06),
                    Type = "Car" },
                    new Pspot {  Spot = 4,
                    Reg = "ACB223",
                    Arrival = new DateTime(2020, 01, 04),
                    Type = "Car" },
                    new Pspot {  Spot = 5,
                    Reg = "CCC123",
                    Arrival = new DateTime(2020, 01, 03),
                    Type = "Car" },
                    new Pspot {  Spot = 6,
                    Reg = "ECC123",
                    Arrival = new DateTime(2020, 01, 02),
                    Type = "Car" },
                    new Pspot {  Spot = 7,
                    Reg = "DCC123",
                    Arrival = new DateTime(2020, 04, 01),
                    Type = "Car" },
                    new Pspot {  Spot = 8,
                    Reg = "RCC123",
                    Arrival = new DateTime(2020, 05, 01),
                    Type = "Car" },
                    new Pspot {  Spot = 9,
                    Reg = "TCC123",
                    Arrival = new DateTime(2020, 03, 01),
                    Type = "MC" },
                    new Pspot {  Spot = 10,
                    Reg = "QCC123",
                    Arrival = new DateTime(2021, 01, 01),
                    Type = "MC" } };
                context.AddRange(pspot);
                context.SaveChanges();
            }
        }
    }
}
