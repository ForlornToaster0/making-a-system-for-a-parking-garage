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
            this.VehicleTypes = new System.Windows.Forms.CheckedListBox();
            this.LabelVehicle = new System.Windows.Forms.Label();
            this.LabelSpots = new System.Windows.Forms.Label();
            this.SpotsMany = new System.Windows.Forms.TextBox();
            this.IconPrice = new FontAwesome.Sharp.IconPictureBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.PriceHour = new System.Windows.Forms.TextBox();
            this.IconCar = new FontAwesome.Sharp.IconPictureBox();
            this.LabelCars = new System.Windows.Forms.Label();
            this.CarsSpot = new System.Windows.Forms.TextBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSpots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCar)).BeginInit();
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
            this.BtnCreate.Location = new System.Drawing.Point(457, 152);
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
            this.IconSpots.Location = new System.Drawing.Point(206, 9);
            this.IconSpots.Name = "IconSpots";
            this.IconSpots.Size = new System.Drawing.Size(48, 48);
            this.IconSpots.TabIndex = 33;
            this.IconSpots.TabStop = false;
            // 
            // VehicleTypes
            // 
            this.VehicleTypes.CheckOnClick = true;
            this.VehicleTypes.FormattingEnabled = true;
            this.VehicleTypes.Items.AddRange(new object[] {
            "Cars",
            "Motorcycles"});
            this.VehicleTypes.Location = new System.Drawing.Point(260, 81);
            this.VehicleTypes.Name = "VehicleTypes";
            this.VehicleTypes.Size = new System.Drawing.Size(100, 94);
            this.VehicleTypes.TabIndex = 1;
            // 
            // LabelVehicle
            // 
            this.LabelVehicle.AutoSize = true;
            this.LabelVehicle.Location = new System.Drawing.Point(260, 63);
            this.LabelVehicle.Name = "LabelVehicle";
            this.LabelVehicle.Size = new System.Drawing.Size(75, 15);
            this.LabelVehicle.TabIndex = 32;
            this.LabelVehicle.Text = "Vehicle types";
            // 
            // LabelSpots
            // 
            this.LabelSpots.AutoSize = true;
            this.LabelSpots.Location = new System.Drawing.Point(260, 9);
            this.LabelSpots.Name = "LabelSpots";
            this.LabelSpots.Size = new System.Drawing.Size(96, 15);
            this.LabelSpots.TabIndex = 31;
            this.LabelSpots.Text = "Number of spots";
            // 
            // SpotsMany
            // 
            this.SpotsMany.Location = new System.Drawing.Point(260, 27);
            this.SpotsMany.Name = "SpotsMany";
            this.SpotsMany.Size = new System.Drawing.Size(100, 23);
            this.SpotsMany.TabIndex = 0;
            this.SpotsMany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IconPrice
            // 
            this.IconPrice.BackColor = System.Drawing.SystemColors.Control;
            this.IconPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.IconPrice.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPrice.IconSize = 48;
            this.IconPrice.Location = new System.Drawing.Point(457, 66);
            this.IconPrice.Name = "IconPrice";
            this.IconPrice.Size = new System.Drawing.Size(48, 48);
            this.IconPrice.TabIndex = 39;
            this.IconPrice.TabStop = false;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(511, 66);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(81, 15);
            this.LabelPrice.TabIndex = 38;
            this.LabelPrice.Text = "Price per hour";
            // 
            // PriceHour
            // 
            this.PriceHour.Location = new System.Drawing.Point(511, 84);
            this.PriceHour.Name = "PriceHour";
            this.PriceHour.Size = new System.Drawing.Size(100, 23);
            this.PriceHour.TabIndex = 3;
            this.PriceHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IconCar
            // 
            this.IconCar.BackColor = System.Drawing.SystemColors.Control;
            this.IconCar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconCar.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.IconCar.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCar.IconSize = 48;
            this.IconCar.Location = new System.Drawing.Point(457, 12);
            this.IconCar.Name = "IconCar";
            this.IconCar.Size = new System.Drawing.Size(48, 48);
            this.IconCar.TabIndex = 37;
            this.IconCar.TabStop = false;
            // 
            // LabelCars
            // 
            this.LabelCars.AutoSize = true;
            this.LabelCars.Location = new System.Drawing.Point(511, 12);
            this.LabelCars.Name = "LabelCars";
            this.LabelCars.Size = new System.Drawing.Size(76, 15);
            this.LabelCars.TabIndex = 36;
            this.LabelCars.Text = "Cars per spot";
            // 
            // CarsSpot
            // 
            this.CarsSpot.Location = new System.Drawing.Point(511, 30);
            this.CarsSpot.Name = "CarsSpot";
            this.CarsSpot.Size = new System.Drawing.Size(100, 23);
            this.CarsSpot.TabIndex = 2;
            this.CarsSpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StartUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 339);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.IconPrice);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.PriceHour);
            this.Controls.Add(this.IconCar);
            this.Controls.Add(this.LabelCars);
            this.Controls.Add(this.CarsSpot);
            this.Controls.Add(this.IconSpots);
            this.Controls.Add(this.VehicleTypes);
            this.Controls.Add(this.LabelVehicle);
            this.Controls.Add(this.LabelSpots);
            this.Controls.Add(this.SpotsMany);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUpScreen";
            this.Text = "StartUpScreen";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSpots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCar)).EndInit();
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
        public CheckedListBox VehicleTypes;
        private Label LabelVehicle;
        private Label LabelSpots;
        public TextBox SpotsMany;
        public FontAwesome.Sharp.IconPictureBox IconPrice;
        public Label LabelPrice;
        public TextBox PriceHour;
        public FontAwesome.Sharp.IconPictureBox IconCar;
        public Label LabelCars;
        public TextBox CarsSpot;
    }
}