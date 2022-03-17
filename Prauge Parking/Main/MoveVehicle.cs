using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
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
    public partial class MoveVehicle : UserControl
    {
        public MoveVehicle()
        {
            MainScreen mainScreen = new();
            InitializeComponent();
        }

        private void MoveVehicle_Load(object sender, EventArgs e)
        {
            
            MainScreen mainScreen = new();

            Map map = new();
            this.Location = new Point(mainScreen.PanelMenu.Size.Width, 0);
            this.Width = mainScreen.Size.Width + 200;

            this.Height = (map.DetailedView.Location.Y - 10 + map.DetailedView.Location.Y / 3);
            this.BorderStyle = BorderStyle.None;
        }

        private void BtnMoveVehicle_Click(object sender, EventArgs e)
        {
            DataInitialiser dataInitialiser = new();
            dataInitialiser.update(BoxLicensePlate.Text,int.Parse(BoxPspot.Text));
        }
    }
}
