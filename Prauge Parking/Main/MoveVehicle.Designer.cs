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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxLicensePlate
            // 
            this.BoxLicensePlate.Location = new System.Drawing.Point(15, 65);
            this.BoxLicensePlate.Name = "BoxLicensePlate";
            this.BoxLicensePlate.Size = new System.Drawing.Size(100, 23);
            this.BoxLicensePlate.TabIndex = 0;
            this.BoxLicensePlate.Text = "License Plate";
            this.BoxLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            this.BoxLicensePlate.Enter += new System.EventHandler(this.txtLicensePlate_Text);
            // 
            // BtnMoveVehicle
            // 
            this.BtnMoveVehicle.Location = new System.Drawing.Point(333, 65);
            this.BtnMoveVehicle.Name = "BtnMoveVehicle";
            this.BtnMoveVehicle.Size = new System.Drawing.Size(100, 23);
            this.BtnMoveVehicle.TabIndex = 2;
            this.BtnMoveVehicle.Text = "Move";
            this.BtnMoveVehicle.UseVisualStyleBackColor = true;
            this.BtnMoveVehicle.Click += new System.EventHandler(this.BtnMoveVehicle_Click);
            // 
            // BoxPspot
            // 
            this.BoxPspot.Location = new System.Drawing.Point(227, 65);
            this.BoxPspot.Name = "BoxPspot";
            this.BoxPspot.Size = new System.Drawing.Size(100, 23);
            this.BoxPspot.TabIndex = 1;
            this.BoxPspot.Text = "Pspot";
            // 
            // LabelMoveVehicle
            // 
            this.LabelMoveVehicle.AutoSize = true;
            this.LabelMoveVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelMoveVehicle.Location = new System.Drawing.Point(15, 15);
            this.LabelMoveVehicle.Name = "LabelMoveVehicle";
            this.LabelMoveVehicle.Size = new System.Drawing.Size(157, 32);
            this.LabelMoveVehicle.TabIndex = 3;
            this.LabelMoveVehicle.Text = "Move vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vehicle To Move";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desired P-Spot";
            // 
            // MoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelMoveVehicle);
            this.Controls.Add(this.BoxPspot);
            this.Controls.Add(this.BtnMoveVehicle);
            this.Controls.Add(this.BoxLicensePlate);
            this.Name = "MoveVehicle";
            this.Size = new System.Drawing.Size(475, 269);
            this.Load += new System.EventHandler(this.MoveVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BoxLicensePlate;
        private Button BtnMoveVehicle;
        private TextBox BoxPspot;
        private Label LabelMoveVehicle;
        private Label label1;
        private Label label2;
    }
}
