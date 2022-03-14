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
            Addingvechails map = new();
            this.Controls.Add(map);
            map.CreateControl();
            map.Show();
            map.BringToFront();
        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            string Price = Interaction.InputBox("New price?", "Title", "Default Text");
        }
    }
}
