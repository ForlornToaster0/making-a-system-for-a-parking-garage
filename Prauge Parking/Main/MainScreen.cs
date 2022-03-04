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

namespace Prauge_Parking
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
            
            MapGenerating mapGenerating = new();
            DataExtration extration = new();
            var reg = extration.Reg();
            var type = extration.Type();

            var maps = mapGenerating.Creating(5, 20, type, reg);
            foreach(var map in maps)
            { 
            Controls.Add(map);
            }




        }
    }
}
