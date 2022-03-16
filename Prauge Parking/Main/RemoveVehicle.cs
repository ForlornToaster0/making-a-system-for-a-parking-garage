﻿using System;
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
    public partial class RemoveVehicle : UserControl
    {
        public RemoveVehicle()
        {
            MainScreen mainScreen = new();
            this.Location = new Point(mainScreen.PanelMenu.Width + 30, 30);
            InitializeComponent();
        }

        private void RemoveVehicle_Load(object sender, EventArgs e)
        {

            MainScreen mainScreen = new();


            this.Location = new Point(mainScreen.PanelMenu.Size.Width, 0);
            this.Width = mainScreen.Size.Width + 200;
            this.Height = (mainScreen.Size.Height);
            this.BorderStyle = BorderStyle.None;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
