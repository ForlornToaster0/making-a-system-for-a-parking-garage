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
        XML xml = new XML();
        public Map()
        {
            InitializeComponent();

            xml = XmlManager.XmlDataReader("Config.xml"); // Läser in xml filen för kolla priset vid "xml.ParkingPrice, xml.SizePerLot, xml.sizeY/sizeX".
        }

        private void Map_Load(object sender, EventArgs e)
        {
            MapGenerating mapGenerating = new();
            Phouse phouse = new(xml.SizeX, xml.SizeY, xml.PhouseSize); //(xml)X & Y default size 10.
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
            spot_Inizilase.SpotIni(parkingSpots, vehicles, maps, xml.SizePerLot); //(xml) default SizePerLot is 4.
            if (vehicles.Count > 0)
            {
                for (int i = 0; i < parkingSpots.Count; i++)
                {
                    var rows = inizilasing.DetailedList(parkingSpots[i], vehicles[i], xml.VehiclePrice); //(xml) default parkingprice is 20.
                    DetailedView.Rows.Add(rows);
                }
            }

        }
    }
}
