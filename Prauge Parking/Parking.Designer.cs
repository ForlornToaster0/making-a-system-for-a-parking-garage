namespace Prauge_Parking
{
    partial class Parking
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
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.VechicleTypes = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpotsMany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 48;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBox2.TabIndex = 23;
            this.iconPictureBox2.TabStop = false;
            // 
            // VechicleTypes
            // 
            this.VechicleTypes.CheckOnClick = true;
            this.VechicleTypes.FormattingEnabled = true;
            this.VechicleTypes.Items.AddRange(new object[] {
            "Cars",
            "Motorcycles"});
            this.VechicleTypes.Location = new System.Drawing.Point(66, 84);
            this.VechicleTypes.Name = "VechicleTypes";
            this.VechicleTypes.Size = new System.Drawing.Size(120, 94);
            this.VechicleTypes.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Vechicle types";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Number of spots";
            // 
            // SpotsMany
            // 
            this.SpotsMany.Location = new System.Drawing.Point(66, 30);
            this.SpotsMany.Name = "SpotsMany";
            this.SpotsMany.Size = new System.Drawing.Size(100, 23);
            this.SpotsMany.TabIndex = 0;
            this.SpotsMany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 450);
            this.ControlBox = false;
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.VechicleTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpotsMany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private CheckedListBox VechicleTypes;
        private Label label3;
        private Label label1;
        private TextBox SpotsMany;
    }
}