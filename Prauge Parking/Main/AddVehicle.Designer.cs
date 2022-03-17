namespace Prauge_Parking.Main
{
    partial class LabelAddVehicle
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
            this.cmbTypeVehicle = new System.Windows.Forms.ComboBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.btnSaveVehicle = new System.Windows.Forms.Button();
            this.LabelVehicle = new System.Windows.Forms.Label();
            this.txtPspot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbTypeVehicle
            // 
            this.cmbTypeVehicle.FormattingEnabled = true;
            this.cmbTypeVehicle.Location = new System.Drawing.Point(121, 65);
            this.cmbTypeVehicle.Name = "cmbTypeVehicle";
            this.cmbTypeVehicle.Size = new System.Drawing.Size(100, 23);
            this.cmbTypeVehicle.TabIndex = 1;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLicensePlate.Location = new System.Drawing.Point(15, 65);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(100, 23);
            this.txtLicensePlate.TabIndex = 0;
            this.txtLicensePlate.Text = "License Plate";
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            this.txtLicensePlate.Enter += new System.EventHandler(this.txtLicensePlate_Text);
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(121, 139);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(100, 23);
            this.btnSaveVehicle.TabIndex = 2;
            this.btnSaveVehicle.Text = "Add";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // LabelVehicle
            // 
            this.LabelVehicle.AutoSize = true;
            this.LabelVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelVehicle.Location = new System.Drawing.Point(15, 15);
            this.LabelVehicle.Name = "LabelVehicle";
            this.LabelVehicle.Size = new System.Drawing.Size(139, 32);
            this.LabelVehicle.TabIndex = 6;
            this.LabelVehicle.Text = "Add vehicle";
            // 
            // txtPspot
            // 
            this.txtPspot.Location = new System.Drawing.Point(227, 65);
            this.txtPspot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPspot.Name = "txtPspot";
            this.txtPspot.Size = new System.Drawing.Size(100, 23);
            this.txtPspot.TabIndex = 8;
            // 
            // LabelAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtPspot);
            this.Controls.Add(this.LabelVehicle);
            this.Controls.Add(this.cmbTypeVehicle);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.btnSaveVehicle);
            this.Name = "LabelAddVehicle";
            this.Size = new System.Drawing.Size(475, 269);
            this.Load += new System.EventHandler(this.CmbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbTypeVehicle;
        private TextBox txtLicensePlate;
        private Button btnSaveVehicle;
        private Label LabelVehicle;
        private TextBox txtPspot;
    }
}
