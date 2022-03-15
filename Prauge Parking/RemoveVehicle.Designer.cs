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
            this.SuspendLayout();
            // 
            // BtnRemoveVehicle
            // 
            this.BtnRemoveVehicle.Location = new System.Drawing.Point(124, 19);
            this.BtnRemoveVehicle.Name = "BtnRemoveVehicle";
            this.BtnRemoveVehicle.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveVehicle.TabIndex = 3;
            this.BtnRemoveVehicle.Text = "Remove";
            this.BtnRemoveVehicle.UseVisualStyleBackColor = true;
            // 
            // BoxLicensePlate
            // 
            this.BoxLicensePlate.Location = new System.Drawing.Point(18, 19);
            this.BoxLicensePlate.Name = "BoxLicensePlate";
            this.BoxLicensePlate.Size = new System.Drawing.Size(100, 23);
            this.BoxLicensePlate.TabIndex = 2;
            this.BoxLicensePlate.Text = "License Plate";
            // 
            // RemoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BtnRemoveVehicle);
            this.Controls.Add(this.BoxLicensePlate);
            this.Name = "RemoveVehicle";
            this.Size = new System.Drawing.Size(475, 269);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnRemoveVehicle;
        private TextBox BoxLicensePlate;
    }
}
