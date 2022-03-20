using Core;
using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
using Prauge_Parking.Main;
using Prauge_Parking.Moving_soon;
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
    public partial class RemoveVehicle : UserControl
    {
        XML xml = new();
        testContext context = new testContext();
        XmlManager xmlManager = new XmlManager();
        public RemoveVehicle()
        {
            MainScreen mainScreen = new();
            InitializeComponent();
        }

        private void RemoveVehicle_Load(object sender, EventArgs e)
        {

            MainScreen mainScreen = new();

            Map map = new();
            this.Location = new Point(mainScreen.PanelMenu.Size.Width, 0);
            this.Width = mainScreen.Size.Width + 200;

            this.Height = (map.DetailedView.Location.Y - 10 + map.DetailedView.Location.Y / 3);
            this.BorderStyle = BorderStyle.None;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnRemoveVehicle_Click(object sender, EventArgs e)
        {
            xml = XmlManager.XmlDataReader("Config.xml");

            try
            {
                int priceAmount = 0;
                var vehicle = context.Pspots.SingleOrDefault(p => p.Reg == BoxLicensePlate.Text.ToUpper());
                var span = (Math.Round(DateTime.Now.Subtract(vehicle.Arrival.AddMinutes(10)).TotalHours));


                var type = vehicle.Type;
                var prisCar = Convert.ToInt32(xml.VehiclePrice[0]);
                var calculatedCar = prisCar * span;

                var prisMc = Convert.ToInt32(xml.VehiclePrice[1]);
                var calculatedMc = prisMc * span;

                if (type == "1")
                {
                    MessageBox.Show($"{BoxLicensePlate.Text} has been removed\nTotal parktime: {span} hours. \nPrice to pay: {calculatedCar} CZK", "Vehicle Removed");
                }
                else
                {
                    MessageBox.Show($"{BoxLicensePlate.Text} has been removed\nTotal parktime: {span} hours. \nPrice to pay: {calculatedMc} CZK", "Vehicle Removed");
                }

                context.Pspots.Remove(vehicle);
                context.SaveChanges();


            }
            catch (Exception)
            {
                MessageBox.Show("Vehicle couldn't be found", "Error");
            }
            MainScreen mainScreen = new MainScreen();
            mainScreen.Show();
            this.Hide();
            Hide();

        }

        public object[] DetailedList(ParkingSpots spot, Vehicle vehicles, int[] Prize)
        {

            double priceAmount = 0;
            var vehicle = context.Pspots.SingleOrDefault(p => p.Reg == BoxLicensePlate.Text.ToUpper());

            var type = vehicle.Type;
            var span = Math.Round(DateTime.Now.Subtract(vehicles.ParkTime.AddMinutes(10)).TotalHours);
            if (vehicles.GetType() == typeof(Car))
            {
                priceAmount = span * Prize[1];
            }
            else if (vehicles.GetType() == typeof(MC))
            {
                priceAmount = span * Prize[0];
            }
            object[] row = new object[4] { spot.Position, vehicles.RegNumber, vehicles.ParkTime, priceAmount };
            return row;

        }

        private void txtLicensePlate_TextChanged(object sender, EventArgs e)
        {
            BoxLicensePlate.Text = BoxLicensePlate.Text.ToUpper();
            BoxLicensePlate.Select(BoxLicensePlate.Text.Length, 0);
            if (IsLicence_OK(BoxLicensePlate.Text))
            {
                BtnRemoveVehicle.Enabled = true;
                BoxLicensePlate.BackColor = Color.LightGreen;

            }
            else
            {
                BoxLicensePlate.BackColor = Color.LightSalmon;
                BtnRemoveVehicle.Enabled = false;
            }
            if (BoxLicensePlate.Text == "") BoxLicensePlate.BackColor = SystemColors.ButtonHighlight;
        }
        private bool IsLicence_OK(string regnum)
        {
            if (regnum.Any(c => !char.IsLetterOrDigit(c))) return false;
            if (regnum.Length > 10 || regnum.Length < 4) return false;
            return true;
        }
        private void txtLicensePlate_Text(object sender, EventArgs e)
        {
            if (BoxLicensePlate.Text == "License Plate")
            {
                BoxLicensePlate.Text = "";
                BoxLicensePlate.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
