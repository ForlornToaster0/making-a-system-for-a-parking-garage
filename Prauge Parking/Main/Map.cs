using Core;
using DataAccess;
using FontAwesome.Sharp;
using Prauge_Parking.Moving_soon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prauge_Parking.Main
{
    public partial class Map : UserControl
    {
        public Map()
        {
            InitializeComponent();
        }
         
        private void Map_Load(object sender, EventArgs e)
        {
            MapGenerating mapGenerating = new();
            Phouse phouse = new(10, 10, 50);
            MainScreen mainScreen = new();


            IconButton[] maps = mapGenerating.Creating(phouse);
            if (Controls.Find("MapSpot0", true) != null)
            {
                Controls.AddRange(maps);
            }
            this.Location = new Point(mainScreen.PanelMenu.Width + 30, 0);
            this.Width = maps.Last().Location.X;
            this.Height = maps.Last().Location.Y;
            Inzilasing mapInfo = new();

            List<Vehicle> vehicles = mapInfo.NewCars();

            List<ParkingSpots> parkingSpots = mapInfo.parkings();
            Spot_inizilase spot_Inizilase = new();
            spot_Inizilase.SpotIni(parkingSpots, vehicles, maps, 4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
