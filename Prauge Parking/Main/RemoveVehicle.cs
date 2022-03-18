using DataAccess.Data;
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

namespace Prauge_Parking
{
    public partial class RemoveVehicle : UserControl
    {
        Map map = new Map();
        testContext context = new testContext();
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
            try
            {
                var vehicle = context.Pspots.SingleOrDefault(p => p.Reg == BoxLicensePlate.Text.ToUpper());
                BoxLicensePlate.Text = "";
                MessageBox.Show($"Vehicle has been removed", "Vehicle Removed");


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
