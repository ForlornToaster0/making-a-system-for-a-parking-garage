﻿using Core;
using DataAccess;
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
    public partial class Addingvechails : UserControl
    {
        public Addingvechails()
        {
            MainScreen mainScreen = new();
            this.Location = new Point(mainScreen.PanelMenu.Width + 30, 0);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataImport dataImport = new ();
            dataImport.import(DateTime.Now, "Car", "ABC123", 40);
        }
    }
}
