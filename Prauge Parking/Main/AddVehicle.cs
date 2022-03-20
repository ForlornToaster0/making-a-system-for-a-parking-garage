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
    public partial class LabelAddVehicle : UserControl
    {
        public LabelAddVehicle()
        {
            InitializeComponent();
            Map map = new();
            MainScreen mainScreen = new();


            this.Location = new Point(mainScreen.PanelMenu.Size.Width, 600);
            this.Width = mainScreen.Size.Width + -800;
            this.BorderStyle = BorderStyle.None;
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {

            Inzilasing inz = new Inzilasing();
            List<ParkingSpots> pSpots = inz.ParkingHouse();
            var maxsize = XmlManager.XmlDataReader("Config.xml");
            
            if (!string.IsNullOrEmpty(txtLicensePlate.Text) && !(txtLicensePlate.Text.Length <= 3))
            {
                try
                {
                    DataInitialiser data = new();

                    if (int.TryParse(txtPspot.Text, out int spot))
                    {
                        bool added = false;
                        var tester = pSpots.Where(p => p.Position == spot).Count();
                        var tester1 = pSpots.Select(p => p.Position).ToList();
                        for (int i = 0; i < pSpots.Count; i++)
                        {
                            if (pSpots[i].Position == spot && pSpots[i].SpotSize != maxsize.SizePerLot)
                                
                            {
                                data.InsertVehicle(txtLicensePlate.Text, (int)cmbTypeVehicle.SelectedItem, spot);
                                added = true;
                                MessageBox.Show("Inserted vehicle to database!", "Success");
                                break;
                            }
                        
                        }
                        if (tester1.Contains(spot)&&added==false)
                        {
                            int oldspot = spot;
                            while (tester1.Contains(spot))
                            {
                                spot++;

                            }

                            MessageBox.Show($"moved from {oldspot} to {spot}");
                            data.InsertVehicle(txtLicensePlate.Text, (int)cmbTypeVehicle.SelectedItem, spot);

                        }
                        else if (added==false)
                        {
                            data.InsertVehicle(txtLicensePlate.Text, (int)cmbTypeVehicle.SelectedItem, spot);

                            MessageBox.Show("Inserted vehicle to database!", "Successer");
                        }

                    }

                    txtLicensePlate.Text = "";
                }
                catch
                {
                }
            }

        }

        private void CmbForm_Load(object sender, EventArgs e)
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
            if (txtLicensePlate.Text == "License Plate")
            {
                txtLicensePlate.Text = "";
                txtLicensePlate.ForeColor = SystemColors.WindowText;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
