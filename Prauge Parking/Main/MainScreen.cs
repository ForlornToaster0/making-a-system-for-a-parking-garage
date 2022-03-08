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
           
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;

            MapGenerating mapGenerating = new();
            Inzilasing mapInfo = new();
            
      
            Vehicle[] vehicles = mapInfo.NewCars();
   
            ParkingSpots[] parkingSpots = mapInfo.parkings();
            Phouse phouse = new Phouse(10,10,100);
            var maps = mapGenerating.Creating(parkingSpots,phouse, vehicles);
            foreach (var map in maps)
            {
                Controls.Add(map);
            }




        }
    }
}
