using Core;
using DataAccess;
using FontAwesome.Sharp;
using Prauge_Parking.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prauge_Parking
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Inzilasing inzilasing = new();
            inzilasing.Cars();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;

            MapGenerating mapGenerating = new();


            Inzilasing mapInfo = new();
            Car[] car = mapInfo.Cars();
            MC[] mc = mapInfo.MC();
            Vehicle[] vehicles = car.Concat<Vehicle>(mc).ToArray();


            ParkingSpots phouse = new(10, 10, 100, 4);
            var maps = mapGenerating.Creating(phouse, vehicles);
            foreach (var map in maps)
            {
                Controls.Add(map);
            }




        }
    }
}
