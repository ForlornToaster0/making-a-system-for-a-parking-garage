namespace Prauge_Parking
{
    partial class MoveVehicle
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
            this.BoxLicensePlate = new System.Windows.Forms.TextBox();
            this.BtnMoveVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxLicensePlate
            // 
            this.BoxLicensePlate.Location = new System.Drawing.Point(3, 3);
            this.BoxLicensePlate.Name = "BoxLicensePlate";
            this.BoxLicensePlate.Size = new System.Drawing.Size(100, 23);
            this.BoxLicensePlate.TabIndex = 0;
            // 
            // BtnMoveVehicle
            // 
            this.BtnMoveVehicle.Location = new System.Drawing.Point(109, 3);
            this.BtnMoveVehicle.Name = "BtnMoveVehicle";
            this.BtnMoveVehicle.Size = new System.Drawing.Size(75, 23);
            this.BtnMoveVehicle.TabIndex = 1;
            this.BtnMoveVehicle.Text = "Move";
            this.BtnMoveVehicle.UseVisualStyleBackColor = true;
            // 
            // MoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnMoveVehicle);
            this.Controls.Add(this.BoxLicensePlate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MoveVehicle";
            this.Size = new System.Drawing.Size(595, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BoxLicensePlate;
        private Button BtnMoveVehicle;
    }
}
