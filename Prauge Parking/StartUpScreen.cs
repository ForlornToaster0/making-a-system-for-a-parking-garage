﻿using Core;
using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
using System;
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
    public partial class StartUpScreen : Form
    {
        public StartUpScreen()
        {
            testContext context = new();
            context.Database.EnsureCreated();
            if (context.Pspots.Count() == 0)
            {
                PopulateDbWithTestData populateDbWithTestData = new();
                populateDbWithTestData.Populate();
            }
            string message = "Do you want to configure the program?";
            string title = "Config";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {

            }
            else
            {
                InitializeComponent();
            }


        }
        private void CreateConfig_Click(object sender, EventArgs e)
        {

            XMLWriter xmlWritre = new XMLWriter();
            int may = int.Parse(SpotsMany.Text);
            float Price = float.Parse(PriceHour.Text);
            var test = VechicleTypes.CheckedItems;
            List<string> config = new List<string>();
            for (int i = 0; i < test.Count; i++)
            {
                test[i].ToString().Trim();
                config.Add(test[i].ToString());
            }
            int size = int.Parse(CarsSpot.Text);
            xmlWritre.TestWriter(may, Price, config, size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parking t = new Parking();
            t.TopLevel = false;
            pnlContent.Controls.Add(t);
            t.BringToFront();
            t.Show();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            Cars t = new Cars();
            t.TopLevel = false;
            pnlContent.Controls.Add(t);
            t.BringToFront();
            t.Show();
        }

        private void btnMotorcycles_Click(object sender, EventArgs e)
        {
            Motorcycles t = new Motorcycles();
            t.TopLevel = false;
            pnlContent.Controls.Add(t);
            t.BringToFront();
            t.Show();
        }
    }
}
