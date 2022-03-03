using DeleteMe.Data;
using System;
﻿using System;
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
    public partial class StartUpScreen : Form
    {
        public StartUpScreen()
        {
            var context = new testContext();
            context.Database.EnsureCreated();


            string message = "Do you want to configure the program?";
            string title = "Config";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {

            }
            else
            {
                InitializeComponent();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
