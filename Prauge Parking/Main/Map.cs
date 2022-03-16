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
            Phouse phouse = new(10, 10, 100);
            MainScreen mainScreen = new();
            Inzilasing inizilasing = new();

            IconButton[] maps = mapGenerating.Creating(phouse);
            if (Controls.Find("MapSpot0", true) != null)
            {
                Controls.AddRange(maps);
            }
            DetailedView.Location = new Point(0, maps.Last().Location.Y + maps.Last().Size.Height + 10);

            this.Location = new Point(mainScreen.PanelMenu.Width + 30, 0);
            this.Width = maps.Last().Location.X + maps.Last().Size.Width;
            this.Height = DetailedView.Location.Y + DetailedView.Size.Height;
            Inzilasing mapInfo = new();

            List<Vehicle> vehicles = mapInfo.NewCars();

            List<ParkingSpots> parkingSpots = mapInfo.parkings();
            Spot_inizilase spot_Inizilase = new();
            spot_Inizilase.SpotIni(parkingSpots, vehicles, maps, 4);
            for (int i = 0; i < parkingSpots.Count; i++)
            {
                var rows = inizilasing.DetailedList(parkingSpots[i], vehicles[i], 20);
                DetailedView.Rows.Add(rows);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
