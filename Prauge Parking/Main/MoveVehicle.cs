using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
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
    public partial class MoveVehicle : UserControl
    {
        static MainScreen scr = new();
        static Map m = new Map();
        public MoveVehicle()
        {
            InitializeComponent();
        }

        private void MoveVehicle_Load(object sender, EventArgs e)
        {
            
            MainScreen mainScreen = new();

            this.Location = new Point(mainScreen.PanelMenu.Size.Width, 600);
            this.Width = mainScreen.Size.Width + -800;
            this.BorderStyle = BorderStyle.None;



        }

        private void BtnMoveVehicle_Click(object sender, EventArgs e)
        {
            DataInitialiser dataInitialiser = new();
            dataInitialiser.update(BoxLicensePlate.Text,int.Parse(BoxPspot.Text));
            MessageBox.Show("Vehicle " + BoxLicensePlate.Text + " has moved to parking Spot: " + BoxPspot.Text, "Success!");

        }
        private void txtLicensePlate_TextChanged(object sender, EventArgs e)
        {
            BoxLicensePlate.Text = BoxLicensePlate.Text.ToUpper();
            BoxLicensePlate.Select(BoxLicensePlate.Text.Length, 0);
            if (IsLicence_OK(BoxLicensePlate.Text))
            {
                BtnMoveVehicle.Enabled = true;
                BoxLicensePlate.BackColor = Color.LightGreen;

            }
            else
            {
                BoxLicensePlate.BackColor = Color.LightSalmon;
                BtnMoveVehicle.Enabled = false;
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
