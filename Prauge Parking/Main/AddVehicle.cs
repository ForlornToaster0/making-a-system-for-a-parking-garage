using Core;
using DataAccess;
using DataAccess.Models;
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
    public partial class AddVehicle : UserControl
    {
        public AddVehicle()
        {
            MainScreen mainScreen = new();
            this.Location = new Point(mainScreen.PanelMenu.Width + 30, 30);
            InitializeComponent();
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLicensePlate.Text) && !(txtLicensePlate.Text.Length <= 3))
            {
                try
                {
                    DataInitialiser data = new DataInitialiser();
                    data.InsertVehicle(txtLicensePlate.Text, (int)cmbTypeVehicle.SelectedItem, DateTime.Now);
                    txtLicensePlate.Text = "";
                    MessageBox.Show("Inserted vehicle to database!", "Success");
                }
                catch
                {
                    MessageBox.Show("Failed to insert vehicle to database", "Failed");
                }
            }

        }
        private void cmbForm_Load(object sender, EventArgs e)
        {
            cmbTypeVehicle.DataSource = Enum.GetValues(typeof(VehicleTypeEnum));
        }

        private void txtLicensePlate_TextChanged(object sender, EventArgs e)
        {
            txtLicensePlate.Text = txtLicensePlate.Text.ToUpper();
            txtLicensePlate.Select(txtLicensePlate.Text.Length, 0);
            if (IsLicence_OK(txtLicensePlate.Text))
            {
                btnSaveVehicle.Enabled = true;
                txtLicensePlate.BackColor = Color.LightGreen;

            }
            else
            {
                txtLicensePlate.BackColor = Color.LightSalmon;
                btnSaveVehicle.Enabled = false;
            }
            if (txtLicensePlate.Text == "") txtLicensePlate.BackColor = SystemColors.ButtonHighlight;
        }
        private bool IsLicence_OK(string regnum)
        {
            if (regnum.Any(c => !char.IsLetterOrDigit(c))) return false;
            if (regnum.Length > 10 || regnum.Length < 4) return false;
            return true;
        }

        private void txtLicensePlate_Text(object sender, EventArgs e)
        {
            if (txtLicensePlate.Text == "Licence Plate Number")
            {
                txtLicensePlate.Text = "";
                txtLicensePlate.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
