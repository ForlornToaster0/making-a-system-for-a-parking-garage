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
using Microsoft.VisualBasic;
using Core.Configurations;
using DataAccess.Data;

namespace Prauge_Parking
{
    public partial class MainScreen : Form
    {
        XML xml = new XML();

        public MainScreen()
        {
            testContext context = new();
            context.Database.EnsureCreated();
            InitializeComponent();

            string fileName = "Config.xml";

            if (xml.ParkingPrice == 0)
            {
                xml.ParkingPrice = 20;
            }
            xml.CZK = "CZK";
            xml.CarSize = 4;
            xml.MCSize = 2;
            xml.SizePerLot = 4;
            xml.PhouseSize = 100;
            XmlManager.XmlDataWriter(xml, "Config.xml");
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            //    TopMost = true;
            //    FormBorderStyle = FormBorderStyle.Sizable;
            //    WindowState = FormWindowState.Maximized;
            Map map = new();
            this.Controls.Add(map);
            map.CreateControl();
            map.Show();
            map.BringToFront(); 
            BtnAdd.Location = new Point(BtnPrice.Location.X, BtnPrice.Location.Y + BtnPrice.Size.Height + BtnPrice.Size.Height/2);
            BtnAdd.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);


            BtnMove.Location = new Point(BtnAdd.Location.X, BtnAdd.Location.Y + BtnAdd.Size.Height + BtnAdd.Size.Height /2);
            BtnMove.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            iconButton1.Location = new Point(BtnMove.Location.X, BtnMove.Location.Y + BtnMove.Size.Height + BtnMove.Size.Height / 2);
            iconButton1.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            BtnHome.Location = new Point(iconButton1.Location.X, iconButton1.Location.Y + iconButton1.Size.Height + iconButton1.Size.Height * 2);
            BtnHome.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            BtnAbout.Location = new Point(BtnHome.Location.X, BtnHome.Location.Y + BtnHome.Size.Height + BtnHome.Size.Height * 2);
            BtnAbout.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            BtnExit.Location = new Point(BtnAbout.Location.X, BtnAbout.Location.Y + BtnAbout.Size.Height + BtnAbout.Size.Height / 2);
            BtnExit.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

        }

        private void BtnParking_Click(object sender, EventArgs e)
        {
            Map map = new();
            this.Controls.Add(map);
            map.CreateControl();
            map.Show();
            map.BringToFront();
        }

        private void BtnVehicles_Click(object sender, EventArgs e)
        {
            LabelAddVehicle map = new();
            this.Controls.Add(map);
            map.CreateControl();
            map.Show();
            map.BringToFront();
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            string price = Interaction.InputBox("Current Price: " + xml.ParkingPrice + "CZK", "Edit Price", "Enter New Price");
            if (price != "")
            {
                xml.ParkingPrice = Convert.ToDouble(price);
                XmlManager.XmlDataWriter(xml, "Config.xml");
                MessageBox.Show("New Price: " + xml.ParkingPrice + "CZK", "Added!");
            }
           
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prague Parking v2.0", "About");                        
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LabelAddVehicle AddVeh = new();  // Går det att maximera denna?
            Controls.Add(AddVeh);
            AddVeh.BringToFront();
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            MoveVehicle MovVeh = new();  // Går det att maximera denna?
            Controls.Add(MovVeh);            
            MovVeh.BringToFront();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            RemoveVehicle RemVeh = new();  // Går det att maximera denna?
            Controls.Add(RemVeh);
            RemVeh.BringToFront();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            //AddVehicle map = new();
            //map.CreateControl();
            //map.Show();
            //map.BringToFront();

            var home = new MainScreen();
            home.Show();
        }
    }
}
