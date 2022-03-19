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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int flag = 1;

        private void btnImage_Click(object sender, EventArgs e)
        {
            flag *= -1;
            if (flag == -1)
            {
                Bitmap a = new Bitmap(@"C:\Users\Vikto\source\repos\ForlornToaster0\making-a-system-for-a-parking-garage\Prauge Parking\obj\b1.JPG");
                btnImage.Image = a;
            }
            else
            {
                Bitmap b = new Bitmap(@"C:\Users\Vikto\source\repos\ForlornToaster0\making-a-system-for-a-parking-garage\Prauge Parking\obj\b2.JPG");
                btnImage.Image = b;
            }
        }
    }
}
