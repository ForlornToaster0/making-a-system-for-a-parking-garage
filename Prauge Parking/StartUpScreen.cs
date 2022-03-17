using Core;
using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
using System.Xml.Serialization;
using System.Xml;
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
using System.Diagnostics;
using Prauge_Parking.Main;

namespace Prauge_Parking
{
    public partial class StartUpScreen : Form
    {
        private LabelAddVehicle addVehicle = new LabelAddVehicle();

        XML xml = new XML();
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
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                StartUpScreen startUpScreen = new StartUpScreen();
                startUpScreen.Close();
            }
            else
            {
                InitializeComponent();
            }

        }    

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    xml.CZK = "CZK";
            //    xml.CarSize = 4;
            //    xml.MCSize = 2;
            //    // xml.mPrice = Convert.ToDouble(McPrice.Text);
            //    xml.cPrice = Convert.ToDouble(PriceHour.Text);
            //    xml.SizePerLot = Convert.ToInt32(SizeLot.Text);
            //    xml.PhouseSize = Convert.ToInt32(PhouseSpot.Text);
            //    XmlManager.XmlDataWriter(xml, "Config.xml");
            //    MessageBox.Show("Data Saved", "XML file is now updated");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error " + ex.ToString());
            //    throw;
            //}
        }

        private void btnShowConfig_Click(object sender, EventArgs e)
        {
            //DataSet dataset = new DataSet();
            //dataset.ReadXml("Config.xml");
            //dataGridView1.DataSource = dataset.Tables[0];

            //xml = XmlManager.XmlDataReader("Config.xml");
            //// McPrice.Text = Convert.ToString(xml.mPrice);
            //PriceHour.Text = Convert.ToString(xml.cPrice);
            //SizeLot.Text = Convert.ToString(xml.SizePerLot);
            //PhouseSpot.Text = Convert.ToString(xml.PhouseSize);
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prague Parking v2.0", "About");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddVehicle_Form_Click(object sender, EventArgs e)
        {
            this.Hide();
            LabelAddVehicle addVehicleForm = new LabelAddVehicle();
            addVehicleForm.Show();
        }

        private void BtnOpenLocation_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"c:\"); // Kan denna peka mot xml-filens mapp?
        }
    }
}
