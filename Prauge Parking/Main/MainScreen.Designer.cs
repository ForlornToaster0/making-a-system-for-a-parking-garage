namespace Prauge_Parking
{
    partial class MainScreen
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnVehicles = new System.Windows.Forms.Button();
            this.BtnParking = new System.Windows.Forms.Button();
            this.LabConfig = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.PanelMenu.Size = new System.Drawing.Size(229, 451);
            this.PanelMenu.TabIndex = 20;
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
            this.BtnVehicles.Click += new System.EventHandler(this.BtnVehicles_Click);
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
            this.BtnParking.Click += new System.EventHandler(this.BtnParking_Click);
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
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.PanelMenu);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel PanelMenu;
        private Button BtnVehicles;
        private Button BtnParking;
        private Label LabConfig;
    }
}