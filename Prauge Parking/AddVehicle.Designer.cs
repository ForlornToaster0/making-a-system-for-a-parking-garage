namespace Prauge_Parking
{
    partial class AddVehicle
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
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.cmbTypeVehicle = new System.Windows.Forms.ComboBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnMove = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnPrice = new FontAwesome.Sharp.IconButton();
            this.LabConfig = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(249, 25);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(103, 23);
            this.btnSaveVehicle.TabIndex = 0;
            this.btnSaveVehicle.Text = "Add";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(358, 26);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(142, 23);
            this.txtLicensePlate.TabIndex = 1;
            this.txtLicensePlate.Text = "License Plate Number";
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            this.txtLicensePlate.Enter += new System.EventHandler(this.txtLicensePlate_Text);
            // 
            // cmbTypeVehicle
            // 
            this.cmbTypeVehicle.FormattingEnabled = true;
            this.cmbTypeVehicle.Location = new System.Drawing.Point(506, 26);
            this.cmbTypeVehicle.Name = "cmbTypeVehicle";
            this.cmbTypeVehicle.Size = new System.Drawing.Size(121, 23);
            this.cmbTypeVehicle.TabIndex = 2;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelMenu.Controls.Add(this.BtnMove);
            this.PanelMenu.Controls.Add(this.BtnAdd);
            this.PanelMenu.Controls.Add(this.BtnPrice);
            this.PanelMenu.Controls.Add(this.LabConfig);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 450);
            this.PanelMenu.TabIndex = 21;
            // 
            // BtnMove
            // 
            this.BtnMove.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.BtnMove.IconColor = System.Drawing.Color.Black;
            this.BtnMove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMove.IconSize = 16;
            this.BtnMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMove.Location = new System.Drawing.Point(42, 131);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(100, 23);
            this.BtnMove.TabIndex = 15;
            this.BtnMove.Text = "Move vehicle";
            this.BtnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMove.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdd.IconSize = 16;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(42, 102);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 23);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Add vehicle";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnPrice
            // 
            this.BtnPrice.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.BtnPrice.IconColor = System.Drawing.Color.Black;
            this.BtnPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrice.IconSize = 16;
            this.BtnPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrice.Location = new System.Drawing.Point(42, 73);
            this.BtnPrice.Name = "BtnPrice";
            this.BtnPrice.Size = new System.Drawing.Size(100, 23);
            this.BtnPrice.TabIndex = 0;
            this.BtnPrice.Text = "Edit price";
            this.BtnPrice.UseVisualStyleBackColor = true;
            this.BtnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
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
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.cmbTypeVehicle);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.btnSaveVehicle);
            this.Name = "AddVehicle";
            this.Text = "AddVehicle";
            this.Load += new System.EventHandler(this.cmbForm_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaveVehicle;
        private TextBox txtLicensePlate;
        private ComboBox cmbTypeVehicle;
        public Panel PanelMenu;
        private FontAwesome.Sharp.IconButton BtnMove;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private FontAwesome.Sharp.IconButton BtnPrice;
        private Label LabConfig;
    }
}