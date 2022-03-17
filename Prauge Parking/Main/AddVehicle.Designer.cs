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
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.txtPspot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbTypeVehicle
            // 
            this.cmbTypeVehicle.FormattingEnabled = true;
            this.cmbTypeVehicle.Location = new System.Drawing.Point(138, 87);
            this.cmbTypeVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTypeVehicle.Name = "cmbTypeVehicle";
            this.cmbTypeVehicle.Size = new System.Drawing.Size(114, 28);
            this.cmbTypeVehicle.TabIndex = 1;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLicensePlate.Location = new System.Drawing.Point(17, 87);
            this.txtLicensePlate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(114, 27);
            this.txtLicensePlate.TabIndex = 0;
            this.txtLicensePlate.Text = "License Plate";
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            this.txtLicensePlate.Enter += new System.EventHandler(this.txtLicensePlate_Text);
            // 
            // btnSaveVehicle
            // 
            this.btnSaveVehicle.Location = new System.Drawing.Point(259, 87);
            this.btnSaveVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveVehicle.Name = "btnSaveVehicle";
            this.btnSaveVehicle.Size = new System.Drawing.Size(114, 31);
            this.btnSaveVehicle.TabIndex = 2;
            this.btnSaveVehicle.Text = "Add";
            this.btnSaveVehicle.UseVisualStyleBackColor = true;
            this.btnSaveVehicle.Click += new System.EventHandler(this.btnSaveVehicle_Click);
            // 
            // LabelVehicle
            // 
            this.LabelVehicle.AutoSize = true;
            this.LabelVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelVehicle.Location = new System.Drawing.Point(17, 20);
            this.LabelVehicle.Name = "LabelVehicle";
            this.LabelVehicle.Size = new System.Drawing.Size(172, 41);
            this.LabelVehicle.TabIndex = 6;
            this.LabelVehicle.Text = "Add vehicle";
            // 
            // BoxPspot
            // 
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.Black;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 16;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(441, 309);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(86, 31);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtPspot
            // 
            this.txtPspot.Location = new System.Drawing.Point(138, 122);
            this.txtPspot.Name = "txtPspot";
            this.txtPspot.Size = new System.Drawing.Size(114, 27);
            this.txtPspot.TabIndex = 8;
            // 
            // LabelAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtPspot);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LabelVehicle);
            this.Controls.Add(this.cmbTypeVehicle);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.btnSaveVehicle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LabelAddVehicle";
            this.Size = new System.Drawing.Size(543, 359);
            this.Load += new System.EventHandler(this.CmbForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbTypeVehicle;
        private TextBox txtLicensePlate;
        private Button btnSaveVehicle;
        private Label LabelVehicle;
        private FontAwesome.Sharp.IconButton BtnClose;
        private TextBox txtPspot;
    }
}
