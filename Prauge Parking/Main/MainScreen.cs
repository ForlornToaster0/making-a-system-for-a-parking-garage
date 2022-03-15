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

namespace Prauge_Parking
{
    public partial class MainScreen : Form
    {
        XML xml = new XML();

        public MainScreen()
        {
            InitializeComponent();
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
            AddVehicle map = new();
            this.Controls.Add(map);
            map.CreateControl();
            map.Show();
            map.BringToFront();
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            string price = Interaction.InputBox("Current Price: " + xml.cPrice + "CZK", "Edit Price", "Enter New Price");
            if (price != "")
            {
                xml.cPrice = Convert.ToDouble(price);
                MessageBox.Show("New Price: " + price + "CZK", "Added!");
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
            AddVehicle AddVeh = new();  // Går det att maximera denna?
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
            AddVehicle map = new();
            map.CreateControl();
            map.Show();
            map.BringToFront();



            //var home = new Map();
            //home.BringToFront();
        }
    }
}
