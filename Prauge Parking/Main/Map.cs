using DataAccess;
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
    public partial class Map : UserControl
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            MapGenerating mapGenerating = new MapGenerating();
          
            
            
        }
    }
}
