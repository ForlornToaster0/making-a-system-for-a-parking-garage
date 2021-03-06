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
using DataAccess.Data;

namespace Prauge_Parking
{
    public partial class MainScreen : Form
    {
        XML xml = new XML();

        public MainScreen()
        {
            try
            {
                using (var adder = new testContext())
                {
                    bool insert = adder.Pspots.Any();

                    if (insert != true)
                    {
                        testContext.TestDataAdd();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            testContext context = new();
            context.Database.EnsureCreated(); //Skapa DB vid start av program.
            InitializeComponent();

            if (!File.Exists("Config.xml")) //Om xml filen ej finns så skapas den med default inställningar.
            {
                xml.VehiclePrice = new int[] { 10, 20 };
                xml.CarSize = 4;
                xml.SizePerLot = 4;
                xml.MCSize = 2;
                xml.CZK = "CZK";
                xml.PhouseSize = 100;
                xml.SizeX = 10;
                xml.SizeY = 10;
                XmlManager.XmlDataWriter(xml, "Config.xml");
            }
            xml = XmlManager.XmlDataReader("Config.xml");
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(xml.VehiclePrice[0]);
            label2.Text = Convert.ToString(xml.VehiclePrice[1]);

            Map map = new();
            this.Controls.Add(map);
            map.CreateControl();
            map.Show();
            map.BringToFront();

            BtnAdd.Location = new Point(BtnPrice.Location.X, BtnPrice.Location.Y + BtnPrice.Size.Height + BtnPrice.Size.Height / 2);
            BtnAdd.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);


            BtnMove.Location = new Point(BtnAdd.Location.X, BtnAdd.Location.Y + BtnAdd.Size.Height + BtnAdd.Size.Height / 2);
            BtnMove.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            BtnRemove.Location = new Point(BtnMove.Location.X, BtnMove.Location.Y + BtnMove.Size.Height + BtnMove.Size.Height / 2);
            BtnRemove.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            BtnMap.Location = new Point(BtnRemove.Location.X, BtnRemove.Location.Y + BtnRemove.Size.Height + BtnRemove.Size.Height * 2);
            BtnMap.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            BtnAbout.Location = new Point(BtnMap.Location.X, BtnMap.Location.Y + BtnMap.Size.Height + BtnMap.Size.Height * 2);
            BtnAbout.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

            BtnExit.Location = new Point(BtnAbout.Location.X, BtnAbout.Location.Y + BtnAbout.Size.Height + BtnAbout.Size.Height / 2);
            BtnExit.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);

        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
            StartUpScreen mainScreen = new StartUpScreen();
            mainScreen.Show();
            this.Hide();
            Hide();

        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prague Parking v2.0\nby Golden Bananas", "About");
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

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemoveVehicle RemVeh = new();  // Går det att maximera denna?
            Controls.Add(RemVeh);
            RemVeh.BringToFront();
        }

        private void BtnMap_Click(object sender, EventArgs e)
        {
            Map map = new();
            this.Controls.Add(map);
            map.CreateControl();
            map.Show();
            map.BringToFront();
            BtnAdd.Location = new Point(BtnPrice.Location.X, BtnPrice.Location.Y + BtnPrice.Size.Height + BtnPrice.Size.Height / 2);
            BtnAdd.Size = new Size(BtnPrice.Size.Width, BtnPrice.Size.Height);
        }
    }
}
