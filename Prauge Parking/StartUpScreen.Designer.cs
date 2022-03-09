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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUpScreen));
            this.LabConfig = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnVehicles = new System.Windows.Forms.Button();
            this.BtnParking = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.IconSpots = new FontAwesome.Sharp.IconPictureBox();
            this.LabelSpots = new System.Windows.Forms.Label();
            this.PhouseSpot = new System.Windows.Forms.TextBox();
            this.IconPrice = new FontAwesome.Sharp.IconPictureBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.McPrice = new System.Windows.Forms.TextBox();
            this.IconCar = new FontAwesome.Sharp.IconPictureBox();
            this.LabelCars = new System.Windows.Forms.Label();
            this.SizeLot = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowConfig = new System.Windows.Forms.Button();
            this.CarPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSpots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabConfig
            // 
            this.LabConfig.AutoSize = true;
            this.LabConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabConfig.Location = new System.Drawing.Point(12, 9);
            this.LabConfig.Name = "LabConfig";
            this.LabConfig.Size = new System.Drawing.Size(175, 29);
            this.LabConfig.TabIndex = 13;
            this.LabConfig.Text = "Config car park";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelMenu.Controls.Add(this.BtnVehicles);
            this.PanelMenu.Controls.Add(this.BtnParking);
            this.PanelMenu.Controls.Add(this.LabConfig);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 339);
            this.PanelMenu.TabIndex = 19;
            // 
            // BtnVehicles
            // 
            this.BtnVehicles.FlatAppearance.BorderSize = 0;
            this.BtnVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVehicles.Location = new System.Drawing.Point(35, 106);
            this.BtnVehicles.Name = "BtnVehicles";
            this.BtnVehicles.Size = new System.Drawing.Size(134, 30);
            this.BtnVehicles.TabIndex = 1;
            this.BtnVehicles.Text = "Vehicles";
            this.BtnVehicles.UseVisualStyleBackColor = true;
            // 
            // BtnParking
            // 
            this.BtnParking.FlatAppearance.BorderSize = 0;
            this.BtnParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnParking.Location = new System.Drawing.Point(35, 70);
            this.BtnParking.Name = "BtnParking";
            this.BtnParking.Size = new System.Drawing.Size(134, 30);
            this.BtnParking.TabIndex = 0;
            this.BtnParking.Text = "Parking";
            this.BtnParking.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(206, 152);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(154, 23);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Create config";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // IconSpots
            // 
            this.IconSpots.BackColor = System.Drawing.SystemColors.Control;
            this.IconSpots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconSpots.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.IconSpots.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconSpots.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconSpots.IconSize = 48;
            this.IconSpots.Location = new System.Drawing.Point(206, 12);
            this.IconSpots.Name = "IconSpots";
            this.IconSpots.Size = new System.Drawing.Size(48, 48);
            this.IconSpots.TabIndex = 33;
            this.IconSpots.TabStop = false;
            // 
            // LabelSpots
            // 
            this.LabelSpots.AutoSize = true;
            this.LabelSpots.Location = new System.Drawing.Point(260, 12);
            this.LabelSpots.Name = "LabelSpots";
            this.LabelSpots.Size = new System.Drawing.Size(96, 15);
            this.LabelSpots.TabIndex = 31;
            this.LabelSpots.Text = "Number of spots";
            // 
            // PhouseSpot
            // 
            this.PhouseSpot.Location = new System.Drawing.Point(260, 30);
            this.PhouseSpot.Name = "PhouseSpot";
            this.PhouseSpot.Size = new System.Drawing.Size(100, 23);
            this.PhouseSpot.TabIndex = 0;
            this.PhouseSpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IconPrice
            // 
            this.IconPrice.BackColor = System.Drawing.SystemColors.Control;
            this.IconPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.IconPrice.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPrice.IconSize = 48;
            this.IconPrice.Location = new System.Drawing.Point(464, 66);
            this.IconPrice.Name = "IconPrice";
            this.IconPrice.Size = new System.Drawing.Size(48, 48);
            this.IconPrice.TabIndex = 39;
            this.IconPrice.TabStop = false;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(518, 66);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(53, 15);
            this.LabelPrice.TabIndex = 38;
            this.LabelPrice.Text = "Mc Price";
            // 
            // McPrice
            // 
            this.McPrice.Location = new System.Drawing.Point(518, 84);
            this.McPrice.Name = "McPrice";
            this.McPrice.Size = new System.Drawing.Size(100, 23);
            this.McPrice.TabIndex = 3;
            this.McPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IconCar
            // 
            this.IconCar.BackColor = System.Drawing.SystemColors.Control;
            this.IconCar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconCar.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.IconCar.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCar.IconSize = 48;
            this.IconCar.Location = new System.Drawing.Point(464, 12);
            this.IconCar.Name = "IconCar";
            this.IconCar.Size = new System.Drawing.Size(48, 48);
            this.IconCar.TabIndex = 37;
            this.IconCar.TabStop = false;
            // 
            // LabelCars
            // 
            this.LabelCars.AutoSize = true;
            this.LabelCars.Location = new System.Drawing.Point(518, 12);
            this.LabelCars.Name = "LabelCars";
            this.LabelCars.Size = new System.Drawing.Size(67, 15);
            this.LabelCars.TabIndex = 36;
            this.LabelCars.Text = "Size Per Lot";
            // 
            // SizeLot
            // 
            this.SizeLot.Location = new System.Drawing.Point(518, 30);
            this.SizeLot.Name = "SizeLot";
            this.SizeLot.Size = new System.Drawing.Size(100, 23);
            this.SizeLot.TabIndex = 2;
            this.SizeLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(420, 150);
            this.dataGridView1.TabIndex = 40;
            // 
            // btnShowConfig
            // 
            this.btnShowConfig.Location = new System.Drawing.Point(472, 152);
            this.btnShowConfig.Name = "btnShowConfig";
            this.btnShowConfig.Size = new System.Drawing.Size(154, 23);
            this.btnShowConfig.TabIndex = 41;
            this.btnShowConfig.Text = "Show Config";
            this.btnShowConfig.UseVisualStyleBackColor = true;
            this.btnShowConfig.Click += new System.EventHandler(this.btnShowConfig_Click);
            // 
            // CarPrice
            // 
            this.CarPrice.Location = new System.Drawing.Point(260, 84);
            this.CarPrice.Name = "CarPrice";
            this.CarPrice.Size = new System.Drawing.Size(100, 23);
            this.CarPrice.TabIndex = 42;
            this.CarPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Car Price";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(206, 66);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox1.TabIndex = 44;
            this.iconPictureBox1.TabStop = false;
            // 
            // StartUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 339);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarPrice);
            this.Controls.Add(this.btnShowConfig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.IconPrice);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.McPrice);
            this.Controls.Add(this.IconCar);
            this.Controls.Add(this.LabelCars);
            this.Controls.Add(this.SizeLot);
            this.Controls.Add(this.IconSpots);
            this.Controls.Add(this.LabelSpots);
            this.Controls.Add(this.PhouseSpot);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUpScreen";
            this.Text = "StartUpScreen";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSpots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabConfig;
        private Panel PanelMenu;
        private Button BtnParking;
        private Button BtnVehicles;
        private Button BtnCreate;
        private FontAwesome.Sharp.IconPictureBox IconSpots;
        private Label LabelSpots;
        public TextBox PhouseSpot;
        public FontAwesome.Sharp.IconPictureBox IconPrice;
        public Label LabelPrice;
        public TextBox McPrice;
        public FontAwesome.Sharp.IconPictureBox IconCar;
        public Label LabelCars;
        public TextBox SizeLot;
        private DataGridView dataGridView1;
        private Button btnShowConfig;
        public TextBox CarPrice;
        public Label label1;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}