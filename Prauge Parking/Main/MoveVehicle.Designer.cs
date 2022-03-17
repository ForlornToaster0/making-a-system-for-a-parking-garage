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
            this.BoxPspot = new System.Windows.Forms.TextBox();
            this.LabelMoveVehicle = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // BtnMoveVehicle
            // 
            this.BtnMoveVehicle.Location = new System.Drawing.Point(381, 87);
            this.BtnMoveVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMoveVehicle.Name = "BtnMoveVehicle";
            this.BtnMoveVehicle.Size = new System.Drawing.Size(114, 31);
            this.BtnMoveVehicle.TabIndex = 2;
            this.BtnMoveVehicle.Text = "Move";
            this.BtnMoveVehicle.UseVisualStyleBackColor = true;
            this.BtnMoveVehicle.Click += new System.EventHandler(this.BtnMoveVehicle_Click);
            // 
            // BoxPspot
            // 
            this.BoxPspot.Location = new System.Drawing.Point(259, 87);
            this.BoxPspot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BoxPspot.Name = "BoxPspot";
            this.BoxPspot.Size = new System.Drawing.Size(114, 27);
            this.BoxPspot.TabIndex = 1;
            this.BoxPspot.Text = "Pspot";
            // 
            // LabelMoveVehicle
            // 
            this.LabelMoveVehicle.AutoSize = true;
            this.LabelMoveVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMoveVehicle.Location = new System.Drawing.Point(17, 20);
            this.LabelMoveVehicle.Name = "LabelMoveVehicle";
            this.LabelMoveVehicle.Size = new System.Drawing.Size(192, 41);
            this.LabelMoveVehicle.TabIndex = 3;
            this.LabelMoveVehicle.Text = "Move vehicle";
            // 
            // MoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LabelMoveVehicle);
            this.Controls.Add(this.BoxPspot);
            this.Controls.Add(this.BtnMoveVehicle);
            this.Controls.Add(this.BoxLicensePlate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MoveVehicle";
            this.Size = new System.Drawing.Size(543, 359);
            this.Load += new System.EventHandler(this.MoveVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BoxLicensePlate;
        private Button BtnMoveVehicle;
        private TextBox BoxPspot;
        private Label LabelMoveVehicle;
    }
}
