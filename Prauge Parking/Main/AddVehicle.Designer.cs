namespace Prauge_Parking.Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTypeVehicle = new System.Windows.Forms.ComboBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbTypeVehicle
            // 
            this.cmbTypeVehicle.FormattingEnabled = true;
            this.cmbTypeVehicle.Location = new System.Drawing.Point(275, 4);
            this.cmbTypeVehicle.Name = "cmbTypeVehicle";
            this.cmbTypeVehicle.Size = new System.Drawing.Size(121, 23);
            this.cmbTypeVehicle.TabIndex = 5;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(127, 4);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(142, 23);
            this.txtLicensePlate.TabIndex = 4;
            this.txtLicensePlate.Text = "License Plate Number";
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            this.txtLicensePlate.Enter += new System.EventHandler(this.txtLicensePlate_Text);
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(18, 3);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(103, 23);
            this.btnSaveVehicle.TabIndex = 3;
            this.btnSaveVehicle.Text = "Add";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmbTypeVehicle);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.btnSaveVehicle);
            this.Controls.Add(this.button1);
            this.Name = "AddVehicle";
            this.Size = new System.Drawing.Size(475, 269);
            this.Load += new System.EventHandler(this.cmbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox cmbTypeVehicle;
        private TextBox txtLicensePlate;
        private Button btnSaveVehicle;
    }
}
