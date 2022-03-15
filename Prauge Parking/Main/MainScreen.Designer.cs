namespace Prauge_Parking
{
    partial class MainScreen
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.BtnMove = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnPrice = new FontAwesome.Sharp.IconButton();
            this.LabConfig = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelMenu.Controls.Add(this.iconButton1);
            this.PanelMenu.Controls.Add(this.BtnMove);
            this.PanelMenu.Controls.Add(this.BtnAdd);
            this.PanelMenu.Controls.Add(this.BtnPrice);
            this.PanelMenu.Controls.Add(this.LabConfig);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(229, 451);
            this.PanelMenu.TabIndex = 20;
            // 
            // BtnMove
            // 
            this.BtnMove.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.BtnMove.IconColor = System.Drawing.Color.Black;
            this.BtnMove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMove.IconSize = 16;
            this.BtnMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMove.Location = new System.Drawing.Point(48, 175);
            this.BtnMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(114, 31);
            this.BtnMove.TabIndex = 15;
            this.BtnMove.Text = "Move vehicle";
            this.BtnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMove.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdd.IconSize = 16;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(48, 136);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(114, 31);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Add vehicle";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnPrice
            // 
            this.BtnPrice.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.BtnPrice.IconColor = System.Drawing.Color.Black;
            this.BtnPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrice.IconSize = 16;
            this.BtnPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrice.Location = new System.Drawing.Point(48, 97);
            this.BtnPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPrice.Name = "BtnPrice";
            this.BtnPrice.Size = new System.Drawing.Size(114, 31);
            this.BtnPrice.TabIndex = 0;
            this.BtnPrice.Text = "Edit price";
            this.BtnPrice.UseVisualStyleBackColor = true;
            this.BtnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
            // 
            // LabConfig
            // 
            this.LabConfig.AutoSize = true;
            this.LabConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabConfig.Location = new System.Drawing.Point(14, 12);
            this.LabConfig.Name = "LabConfig";
            this.LabConfig.Size = new System.Drawing.Size(217, 36);
            this.LabConfig.TabIndex = 13;
            this.LabConfig.Text = "Config car park";
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(48, 214);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(114, 31);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.Text = "Move vehicle";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.PanelMenu);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel PanelMenu;
        private Label LabConfig;
        private FontAwesome.Sharp.IconButton BtnPrice;
        private FontAwesome.Sharp.IconButton BtnAdd;
        private FontAwesome.Sharp.IconButton BtnMove;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}