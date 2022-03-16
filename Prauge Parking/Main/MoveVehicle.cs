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
        public MoveVehicle()
        {
            MainScreen mainScreen = new();
            this.Location = new Point(mainScreen.PanelMenu.Width + 30, 30);
            InitializeComponent();
        }
    }
}
