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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRemoveVehicle
            // 
            this.BtnRemoveVehicle.Location = new System.Drawing.Point(121, 65);
            this.BtnRemoveVehicle.Name = "BtnRemoveVehicle";
            this.BtnRemoveVehicle.Size = new System.Drawing.Size(100, 23);
            this.BtnRemoveVehicle.TabIndex = 1;
            this.BtnRemoveVehicle.Text = "Remove";
            this.BtnRemoveVehicle.UseVisualStyleBackColor = true;
            this.BtnRemoveVehicle.Click += new System.EventHandler(this.BtnRemoveVehicle_Click);
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
            // LabelRemoveVehicle
            // 
            this.LabelRemoveVehicle.AutoSize = true;
            this.LabelRemoveVehicle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelRemoveVehicle.Location = new System.Drawing.Point(15, 15);
            this.LabelRemoveVehicle.Name = "LabelRemoveVehicle";
            this.LabelRemoveVehicle.Size = new System.Drawing.Size(182, 32);
            this.LabelRemoveVehicle.TabIndex = 4;
            this.LabelRemoveVehicle.Text = "Remove vehicle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vehicle To Remove";
            // 
            // RemoveVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelRemoveVehicle);
            this.Controls.Add(this.BtnRemoveVehicle);
            this.Controls.Add(this.BoxLicensePlate);
            this.Name = "RemoveVehicle";
            this.Size = new System.Drawing.Size(244, 99);
            this.Load += new System.EventHandler(this.RemoveVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnRemoveVehicle;
        private TextBox BoxLicensePlate;
        private Label LabelRemoveVehicle;
        private Label label1;
    }
}
