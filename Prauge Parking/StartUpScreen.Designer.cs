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
            this.TipConfig = new System.Windows.Forms.ToolTip(this.components);
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
            this.LabConfig.Location = new System.Drawing.Point(14, 12);
            this.LabConfig.Name = "LabConfig";
            this.LabConfig.Size = new System.Drawing.Size(217, 36);
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
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(229, 452);
            this.PanelMenu.TabIndex = 19;
            // 
            // BtnVehicles
            // 
            this.BtnVehicles.FlatAppearance.BorderSize = 0;
            this.BtnVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnVehicles.Location = new System.Drawing.Point(40, 141);
            this.BtnVehicles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnVehicles.Name = "BtnVehicles";
            this.BtnVehicles.Size = new System.Drawing.Size(153, 40);
            this.BtnVehicles.TabIndex = 1;
            this.BtnVehicles.Text = "Vehicles";
            this.BtnVehicles.UseVisualStyleBackColor = true;
            // 
            // BtnParking
            // 
            this.BtnParking.FlatAppearance.BorderSize = 0;
            this.BtnParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnParking.Location = new System.Drawing.Point(40, 93);
            this.BtnParking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnParking.Name = "BtnParking";
            this.BtnParking.Size = new System.Drawing.Size(153, 40);
            this.BtnParking.TabIndex = 0;
            this.BtnParking.Text = "Parking";
            this.BtnParking.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(235, 203);
            this.BtnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(176, 31);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "Create config";
            this.TipConfig.SetToolTip(this.BtnCreate, "Creates/updates config file");
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // IconSpots
            // 
            this.IconSpots.BackColor = System.Drawing.SystemColors.Control;
            this.IconSpots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconSpots.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.IconSpots.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconSpots.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconSpots.IconSize = 55;
            this.IconSpots.Location = new System.Drawing.Point(235, 16);
            this.IconSpots.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconSpots.Name = "IconSpots";
            this.IconSpots.Size = new System.Drawing.Size(55, 64);
            this.IconSpots.TabIndex = 33;
            this.IconSpots.TabStop = false;
            // 
            // LabelSpots
            // 
            this.LabelSpots.AutoSize = true;
            this.LabelSpots.Location = new System.Drawing.Point(297, 16);
            this.LabelSpots.Name = "LabelSpots";
            this.LabelSpots.Size = new System.Drawing.Size(120, 20);
            this.LabelSpots.TabIndex = 31;
            this.LabelSpots.Text = "Number of spots";
            // 
            // PhouseSpot
            // 
            this.PhouseSpot.Location = new System.Drawing.Point(297, 40);
            this.PhouseSpot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PhouseSpot.Name = "PhouseSpot";
            this.PhouseSpot.Size = new System.Drawing.Size(114, 27);
            this.PhouseSpot.TabIndex = 0;
            this.PhouseSpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.PhouseSpot, "How many spots?");
            // 
            // IconPrice
            // 
            this.IconPrice.BackColor = System.Drawing.SystemColors.Control;
            this.IconPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.IconPrice.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPrice.IconSize = 55;
            this.IconPrice.Location = new System.Drawing.Point(530, 88);
            this.IconPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconPrice.Name = "IconPrice";
            this.IconPrice.Size = new System.Drawing.Size(55, 64);
            this.IconPrice.TabIndex = 39;
            this.IconPrice.TabStop = false;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(592, 88);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(65, 20);
            this.LabelPrice.TabIndex = 38;
            this.LabelPrice.Text = "Mc Price";
            // 
            // McPrice
            // 
            this.McPrice.Location = new System.Drawing.Point(592, 112);
            this.McPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.McPrice.Name = "McPrice";
            this.McPrice.Size = new System.Drawing.Size(114, 27);
            this.McPrice.TabIndex = 3;
            this.McPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.McPrice, "What price for mc?");
            // 
            // IconCar
            // 
            this.IconCar.BackColor = System.Drawing.SystemColors.Control;
            this.IconCar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconCar.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.IconCar.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconCar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCar.IconSize = 55;
            this.IconCar.Location = new System.Drawing.Point(530, 16);
            this.IconCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IconCar.Name = "IconCar";
            this.IconCar.Size = new System.Drawing.Size(55, 64);
            this.IconCar.TabIndex = 37;
            this.IconCar.TabStop = false;
            // 
            // LabelCars
            // 
            this.LabelCars.AutoSize = true;
            this.LabelCars.Location = new System.Drawing.Point(592, 16);
            this.LabelCars.Name = "LabelCars";
            this.LabelCars.Size = new System.Drawing.Size(85, 20);
            this.LabelCars.TabIndex = 36;
            this.LabelCars.Text = "Size Per Lot";
            // 
            // SizeLot
            // 
            this.SizeLot.Location = new System.Drawing.Point(592, 40);
            this.SizeLot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeLot.Name = "SizeLot";
            this.SizeLot.Size = new System.Drawing.Size(100, 23);
            this.SizeLot.TabIndex = 1;
            this.SizeLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.SizeLot, "What size per lot?");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(420, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnShowConfig
            // 
            this.btnShowConfig.Location = new System.Drawing.Point(539, 203);
            this.btnShowConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowConfig.Name = "btnShowConfig";
            this.btnShowConfig.Size = new System.Drawing.Size(154, 23);
            this.btnShowConfig.TabIndex = 5;
            this.btnShowConfig.Text = "Show Config";
            this.TipConfig.SetToolTip(this.btnShowConfig, "Shows config file");
            this.btnShowConfig.UseVisualStyleBackColor = true;
            this.btnShowConfig.Click += new System.EventHandler(this.btnShowConfig_Click);
            // 
            // CarPrice
            // 
            this.CarPrice.Location = new System.Drawing.Point(297, 112);
            this.CarPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CarPrice.Name = "CarPrice";
            this.CarPrice.Size = new System.Drawing.Size(100, 23);
            this.CarPrice.TabIndex = 2;
            this.CarPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.CarPrice, "What price for car?");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Car Price";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 55;
            this.iconPictureBox1.Location = new System.Drawing.Point(235, 88);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(55, 64);
            this.iconPictureBox1.TabIndex = 44;
            this.iconPictureBox1.TabStop = false;
            // 
            // StartUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 452);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private ToolTip TipConfig;
    }
}