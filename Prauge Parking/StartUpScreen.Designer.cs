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
            this.BtnMainScreen = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.IconSpots = new FontAwesome.Sharp.IconPictureBox();
            this.LabelSpots = new System.Windows.Forms.Label();
            this.PhouseSpot = new System.Windows.Forms.TextBox();
            this.IconCars = new FontAwesome.Sharp.IconPictureBox();
            this.LabelCars = new System.Windows.Forms.Label();
            this.SizeLot = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowConfig = new System.Windows.Forms.Button();
            this.PriceHour = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.IconPrice = new FontAwesome.Sharp.IconPictureBox();
            this.TipConfig = new System.Windows.Forms.ToolTip(this.components);
            this.ListVehicle = new System.Windows.Forms.CheckedListBox();
            this.XAxis = new System.Windows.Forms.TextBox();
            this.YAxis = new System.Windows.Forms.TextBox();
            this.BtnOpenLocation = new System.Windows.Forms.Button();
            this.LabelVehicle = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.LabelY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAbout = new FontAwesome.Sharp.IconButton();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSpots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPrice)).BeginInit();
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
            this.PanelMenu.Controls.Add(this.BtnMainScreen);
            this.PanelMenu.Controls.Add(this.LabConfig);
            this.PanelMenu.Controls.Add(this.BtnExit);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 466);
            this.PanelMenu.TabIndex = 19;
            // 
            // BtnMainScreen
            // 
            this.BtnMainScreen.Location = new System.Drawing.Point(37, 58);
            this.BtnMainScreen.Name = "BtnMainScreen";
            this.BtnMainScreen.Size = new System.Drawing.Size(109, 31);
            this.BtnMainScreen.TabIndex = 55;
            this.BtnMainScreen.Text = "MainScreen";
            this.BtnMainScreen.UseVisualStyleBackColor = true;
            this.BtnMainScreen.Click += new System.EventHandler(this.btnAddVehicle_Form_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(552, 101);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(154, 23);
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
            this.TipConfig.SetToolTip(this.PhouseSpot, "How many spots?");
            // 
            // IconCars
            // 
            this.IconCars.BackColor = System.Drawing.SystemColors.Control;
            this.IconCars.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconCars.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.IconCars.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconCars.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCars.IconSize = 48;
            this.IconCars.Location = new System.Drawing.Point(552, 12);
            this.IconCars.Name = "IconCars";
            this.IconCars.Size = new System.Drawing.Size(48, 48);
            this.IconCars.TabIndex = 37;
            this.IconCars.TabStop = false;
            // 
            // LabelCars
            // 
            this.LabelCars.AutoSize = true;
            this.LabelCars.Location = new System.Drawing.Point(606, 12);
            this.LabelCars.Name = "LabelCars";
            this.LabelCars.Size = new System.Drawing.Size(76, 15);
            this.LabelCars.TabIndex = 36;
            this.LabelCars.Text = "Cars per spot";
            // 
            // SizeLot
            // 
            this.SizeLot.Location = new System.Drawing.Point(606, 30);
            this.SizeLot.Name = "SizeLot";
            this.SizeLot.Size = new System.Drawing.Size(100, 23);
            this.SizeLot.TabIndex = 3;
            this.SizeLot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.SizeLot, "What size per lot?");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(206, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(658, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnShowConfig
            // 
            this.btnShowConfig.Location = new System.Drawing.Point(710, 227);
            this.btnShowConfig.Name = "btnShowConfig";
            this.btnShowConfig.Size = new System.Drawing.Size(154, 23);
            this.btnShowConfig.TabIndex = 7;
            this.btnShowConfig.Text = "Show Config";
            this.TipConfig.SetToolTip(this.btnShowConfig, "Shows config file");
            this.btnShowConfig.UseVisualStyleBackColor = true;
            this.btnShowConfig.Click += new System.EventHandler(this.btnShowConfig_Click);
            // 
            // PriceHour
            // 
            this.PriceHour.Location = new System.Drawing.Point(260, 84);
            this.PriceHour.Name = "PriceHour";
            this.PriceHour.Size = new System.Drawing.Size(100, 23);
            this.PriceHour.TabIndex = 1;
            this.PriceHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.PriceHour, "What price per hour?");
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(260, 66);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(81, 15);
            this.LabelPrice.TabIndex = 43;
            this.LabelPrice.Text = "Price per hour";
            // 
            // IconPrice
            // 
            this.IconPrice.BackColor = System.Drawing.SystemColors.Control;
            this.IconPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.IconPrice.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconPrice.IconSize = 48;
            this.IconPrice.Location = new System.Drawing.Point(206, 66);
            this.IconPrice.Name = "IconPrice";
            this.IconPrice.Size = new System.Drawing.Size(48, 48);
            this.IconPrice.TabIndex = 44;
            this.IconPrice.TabStop = false;
            // 
            // ListVehicle
            // 
            this.ListVehicle.CheckOnClick = true;
            this.ListVehicle.FormattingEnabled = true;
            this.ListVehicle.Items.AddRange(new object[] {
            "Cars",
            "Mcs"});
            this.ListVehicle.Location = new System.Drawing.Point(395, 30);
            this.ListVehicle.Name = "ListVehicle";
            this.ListVehicle.Size = new System.Drawing.Size(120, 94);
            this.ListVehicle.TabIndex = 2;
            this.TipConfig.SetToolTip(this.ListVehicle, "What vehicle types?");
            // 
            // XAxis
            // 
            this.XAxis.Location = new System.Drawing.Point(251, 192);
            this.XAxis.Name = "XAxis";
            this.XAxis.Size = new System.Drawing.Size(75, 23);
            this.XAxis.TabIndex = 5;
            this.XAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.XAxis, "Value for X axis");
            // 
            // YAxis
            // 
            this.YAxis.Location = new System.Drawing.Point(395, 192);
            this.YAxis.Name = "YAxis";
            this.YAxis.Size = new System.Drawing.Size(75, 23);
            this.YAxis.TabIndex = 6;
            this.YAxis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TipConfig.SetToolTip(this.YAxis, "Value for Y axis");
            // 
            // BtnOpenLocation
            // 
            this.BtnOpenLocation.Location = new System.Drawing.Point(206, 227);
            this.BtnOpenLocation.Name = "BtnOpenLocation";
            this.BtnOpenLocation.Size = new System.Drawing.Size(154, 23);
            this.BtnOpenLocation.TabIndex = 55;
            this.BtnOpenLocation.Text = "Open location";
            this.TipConfig.SetToolTip(this.BtnOpenLocation, "Shows config file");
            this.BtnOpenLocation.UseVisualStyleBackColor = true;
            this.BtnOpenLocation.Click += new System.EventHandler(this.BtnOpenLocation_Click);
            // 
            // LabelVehicle
            // 
            this.LabelVehicle.AutoSize = true;
            this.LabelVehicle.Location = new System.Drawing.Point(395, 12);
            this.LabelVehicle.Name = "LabelVehicle";
            this.LabelVehicle.Size = new System.Drawing.Size(75, 15);
            this.LabelVehicle.TabIndex = 46;
            this.LabelVehicle.Text = "Vehicle types";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Location = new System.Drawing.Point(206, 195);
            this.LabelX.Name = "LabelX";
            this.LabelX.Size = new System.Drawing.Size(39, 15);
            this.LabelX.TabIndex = 49;
            this.LabelX.Text = "X Axis";
            // 
            // LabelY
            // 
            this.LabelY.AutoSize = true;
            this.LabelY.Location = new System.Drawing.Point(350, 195);
            this.LabelY.Name = "LabelY";
            this.LabelY.Size = new System.Drawing.Size(39, 15);
            this.LabelY.TabIndex = 50;
            this.LabelY.Text = "Y Axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 51;
            this.label1.Text = "Assign map size";
            // 
            // BtnAbout
            // 
            this.BtnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.BtnAbout.IconColor = System.Drawing.Color.Black;
            this.BtnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAbout.IconSize = 16;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnAbout.Location = new System.Drawing.Point(37, 200);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(100, 23);
            this.BtnAbout.TabIndex = 52;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnExit.IconColor = System.Drawing.Color.Black;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 16;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(37, 227);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(100, 23);
            this.BtnExit.TabIndex = 53;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Location = new System.Drawing.Point(712, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 38);
            this.textBox1.TabIndex = 54;
            this.textBox1.Text = "1 car = 4 spots\r\n1 mc = 2 spots";
            // 
            // StartUpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 466);
            this.Controls.Add(this.BtnOpenLocation);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelY);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.YAxis);
            this.Controls.Add(this.XAxis);
            this.Controls.Add(this.LabelVehicle);
            this.Controls.Add(this.ListVehicle);
            this.Controls.Add(this.IconPrice);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.PriceHour);
            this.Controls.Add(this.btnShowConfig);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.IconCars);
            this.Controls.Add(this.LabelCars);
            this.Controls.Add(this.SizeLot);
            this.Controls.Add(this.IconSpots);
            this.Controls.Add(this.LabelSpots);
            this.Controls.Add(this.PhouseSpot);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartUpScreen";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconSpots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabConfig;
        private Panel PanelMenu;
        private Button BtnCreate;
        private FontAwesome.Sharp.IconPictureBox IconSpots;
        private Label LabelSpots;
        public TextBox PhouseSpot;
        public FontAwesome.Sharp.IconPictureBox IconCars;
        public Label LabelCars;
        public TextBox SizeLot;
        private DataGridView dataGridView1;
        private Button btnShowConfig;
        public TextBox PriceHour;
        public Label LabelPrice;
        public FontAwesome.Sharp.IconPictureBox IconPrice;
        private ToolTip TipConfig;
        private CheckedListBox ListVehicle;
        private Label LabelVehicle;
        private TextBox XAxis;
        private TextBox YAxis;
        private Label LabelX;
        private Label LabelY;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnAbout;
        private FontAwesome.Sharp.IconButton BtnExit;
        private TextBox textBox1;
        private Button BtnMainScreen;
        private Button BtnOpenLocation;
    }
}