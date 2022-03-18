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
        XML xml = new XML();
        private LabelAddVehicle addVehicle = new LabelAddVehicle();

        public StartUpScreen()
        {
            {
                xml = XmlManager.XmlDataReader("Config.xml");
                InitializeComponent();
            }

        }    

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                xml.CarSize = 4;
                xml.MCSize = 2;
                xml.VehiclePrice = new int[] { Convert.ToInt32(txtCarPrice.Text), Convert.ToInt32(txtMcPrice.Text) };
                //xml.MCPrice = Convert.ToInt32(txtMcPrice.Text);
                xml.SizePerLot = Convert.ToInt32(SizeLot.Text);
                xml.PhouseSize = Convert.ToInt32(PhouseSpot.Text);
                xml.SizeX = Convert.ToInt32(XAxis.Text);
                xml.SizeY = Convert.ToInt32(YAxis.Text);
                xml.PhouseSize = xml.SizeY * xml.SizeX;
                XmlManager.XmlDataWriter(xml, "Config.xml");
                MessageBox.Show("Data Saved", "XML file is now updated");
                StartUpScreen startUpScreen = new StartUpScreen();
                startUpScreen.Show();
                this.Hide();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        private void btnShowConfig_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml("Config.xml");
            dataGridView1.DataSource = dataset.Tables[0];

            xml = XmlManager.XmlDataReader("Config.xml");
            // McPrice.Text = Convert.ToString(xml.mPrice);
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

        private void BtnOpenLocation_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe",  Directory.GetCurrentDirectory()); // Kan denna välja Config.xml?
            // "/select," + + "Config.txt"
        }

        private void BtnMainScreen_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
            Hide();
        }

        private void StartUpScreen_Load(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(xml.VehiclePrice[1]);
            label6.Text = Convert.ToString(xml.VehiclePrice[0]);
        }
    }
}
