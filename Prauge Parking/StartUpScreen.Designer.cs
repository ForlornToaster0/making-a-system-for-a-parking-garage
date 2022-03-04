namespace Prauge_Parking
{
    partial class StartUpScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpScreen));
            this.SpotsMany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VechicleTypes = new System.Windows.Forms.CheckedListBox();
            this.CreateConfig = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CarsSpot = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MotorcyclesSpot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // SpotsMany
            // 
            this.SpotsMany.Location = new System.Drawing.Point(70, 77);
            this.SpotsMany.Name = "SpotsMany";
            this.SpotsMany.Size = new System.Drawing.Size(100, 23);
            this.SpotsMany.TabIndex = 0;
            this.SpotsMany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.SpotsMany, "How many parking spots");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of spots";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price per hour";
            // 
            // PriceHour
            // 
            this.PriceHour.Location = new System.Drawing.Point(70, 138);
            this.PriceHour.Name = "PriceHour";
            this.PriceHour.Size = new System.Drawing.Size(100, 23);
            this.PriceHour.TabIndex = 1;
            this.PriceHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip2.SetToolTip(this.PriceHour, "What is the price per hour");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vechicle types";
            // 
            // VechicleTypes
            // 
            this.VechicleTypes.FormattingEnabled = true;
            this.VechicleTypes.Items.AddRange(new object[] {
            "Cars",
            "Motorcycles"});
            this.VechicleTypes.Location = new System.Drawing.Point(206, 77);
            this.VechicleTypes.Name = "VechicleTypes";
            this.VechicleTypes.Size = new System.Drawing.Size(120, 94);
            this.VechicleTypes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.VechicleTypes, "Select vechicle types");
            // 
            // CreateConfig
            // 
            this.CreateConfig.Location = new System.Drawing.Point(367, 206);
            this.CreateConfig.Name = "CreateConfig";
            this.CreateConfig.Size = new System.Drawing.Size(150, 23);
            this.CreateConfig.TabIndex = 5;
            this.CreateConfig.Text = "Create config";
            this.CreateConfig.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cars in one spot";
            // 
            // CarsSpot
            // 
            this.CarsSpot.Location = new System.Drawing.Point(425, 77);
            this.CarsSpot.Name = "CarsSpot";
            this.CarsSpot.Size = new System.Drawing.Size(100, 23);
            this.CarsSpot.TabIndex = 3;
            this.CarsSpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.CarsSpot, "How many cars fit in one parking spot");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Motorcycles in one spot";
            // 
            // MotorcyclesSpot
            // 
            this.MotorcyclesSpot.Location = new System.Drawing.Point(425, 141);
            this.MotorcyclesSpot.Name = "MotorcyclesSpot";
            this.MotorcyclesSpot.Size = new System.Drawing.Size(100, 23);
            this.MotorcyclesSpot.TabIndex = 4;
            this.MotorcyclesSpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.MotorcyclesSpot, "How many motorcycles fit in one parking spot");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Config car park";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 120);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox1.TabIndex = 14;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 48;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 59);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox2.TabIndex = 15;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 48;
            this.iconPictureBox3.Location = new System.Drawing.Point(371, 59);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox3.TabIndex = 16;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 48;
            this.iconPictureBox4.Location = new System.Drawing.Point(371, 123);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox4.TabIndex = 17;
            this.iconPictureBox4.TabStop = false;
            // 
            // StartUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 510);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MotorcyclesSpot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarsSpot);
            this.Controls.Add(this.CreateConfig);
            this.Controls.Add(this.VechicleTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpotsMany);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUpScreen";
            this.Text = "StartUpScreen";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SpotsMany;
        private Label label1;
        private Label label2;
        private TextBox PriceHour;
        private Label label3;
        private CheckedListBox VechicleTypes;
        private Button CreateConfig;
        private Label label4;
        private TextBox CarsSpot;
        private Label label5;
        private TextBox MotorcyclesSpot;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}