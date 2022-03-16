namespace Prauge_Parking
{
    partial class RemoveVehicle
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
            this.BtnRemoveVehicle = new System.Windows.Forms.Button();
            this.BoxLicensePlate = new System.Windows.Forms.TextBox();
            this.LabelRemoveVehicle = new System.Windows.Forms.Label();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // BtnRemoveVehicle
            // 
            this.BtnRemoveVehicle.Location = new System.Drawing.Point(259, 87);
            this.BtnRemoveVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRemoveVehicle.Name = "BtnRemoveVehicle";
            this.BtnRemoveVehicle.Size = new System.Drawing.Size(114, 31);
            this.BtnRemoveVehicle.TabIndex = 1;
            this.BtnRemoveVehicle.Text = "Remove";
            this.BtnRemoveVehicle.UseVisualStyleBackColor = true;
            // 
            // BoxLicensePlate
            // 
            this.BoxLicensePlate.Location = new System.Drawing.Point(17, 87);
            this.BoxLicensePlate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoxLicensePlate.Name = "BoxLicensePlate";
            this.BoxLicensePlate.Size = new System.Drawing.Size(114, 27);
            this.BoxLicensePlate.TabIndex = 0;
            this.BoxLicensePlate.Text = "License Plate";
            // 
            // LabelRemoveVehicle
            // 
            this.LabelRemoveVehicle.AutoSize = true;
            this.LabelRemoveVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRemoveVehicle.Location = new System.Drawing.Point(17, 20);
            this.LabelRemoveVehicle.Name = "LabelRemoveVehicle";
            this.LabelRemoveVehicle.Size = new System.Drawing.Size(224, 41);
            this.LabelRemoveVehicle.TabIndex = 4;
            this.LabelRemoveVehicle.Text = "Remove vehicle";
            // 
            // BtnClose
            // 
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnClose.IconColor = System.Drawing.Color.Black;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 16;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(386, 232);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // RemoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LabelRemoveVehicle);
            this.Controls.Add(this.BtnRemoveVehicle);
            this.Controls.Add(this.BoxLicensePlate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RemoveVehicle";
            this.Size = new System.Drawing.Size(543, 359);
            this.Load += new System.EventHandler(this.RemoveVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnRemoveVehicle;
        private TextBox BoxLicensePlate;
        private Label LabelRemoveVehicle;
        private FontAwesome.Sharp.IconButton BtnClose;
    }
}
