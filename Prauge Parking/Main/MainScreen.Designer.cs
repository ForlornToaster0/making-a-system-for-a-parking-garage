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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnMap = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAbout = new FontAwesome.Sharp.IconButton();
            this.BtnRemove = new FontAwesome.Sharp.IconButton();
            this.BtnMove = new FontAwesome.Sharp.IconButton();
            this.BtnAdd = new FontAwesome.Sharp.IconButton();
            this.BtnPrice = new FontAwesome.Sharp.IconButton();
            this.LabConfig = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelMenu.Controls.Add(this.label4);
            this.PanelMenu.Controls.Add(this.label3);
            this.PanelMenu.Controls.Add(this.BtnMap);
            this.PanelMenu.Controls.Add(this.label2);
            this.PanelMenu.Controls.Add(this.BtnExit);
            this.PanelMenu.Controls.Add(this.label1);
            this.PanelMenu.Controls.Add(this.BtnAbout);
            this.PanelMenu.Controls.Add(this.BtnRemove);
            this.PanelMenu.Controls.Add(this.BtnMove);
            this.PanelMenu.Controls.Add(this.BtnAdd);
            this.PanelMenu.Controls.Add(this.BtnPrice);
            this.PanelMenu.Controls.Add(this.LabConfig);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 660);
            this.PanelMenu.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Car Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "MC Price";
            // 
            // BtnMap
            // 
            this.BtnMap.IconChar = FontAwesome.Sharp.IconChar.GlobeEurope;
            this.BtnMap.IconColor = System.Drawing.Color.Black;
            this.BtnMap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMap.IconSize = 16;
            this.BtnMap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMap.Location = new System.Drawing.Point(37, 157);
            this.BtnMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMap.Name = "BtnMap";
            this.BtnMap.Size = new System.Drawing.Size(88, 17);
            this.BtnMap.TabIndex = 4;
            this.BtnMap.Text = "Map";
            this.BtnMap.UseVisualStyleBackColor = true;
            this.BtnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // BtnExit
            // 
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnExit.IconColor = System.Drawing.Color.Black;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 16;
            this.BtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExit.Location = new System.Drawing.Point(37, 221);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(88, 17);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // BtnAbout
            // 
            this.BtnAbout.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.BtnAbout.IconColor = System.Drawing.Color.Black;
            this.BtnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAbout.IconSize = 16;
            this.BtnAbout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnAbout.Location = new System.Drawing.Point(37, 200);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(88, 17);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BtnRemove.IconColor = System.Drawing.Color.Black;
            this.BtnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRemove.IconSize = 16;
            this.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRemove.Location = new System.Drawing.Point(37, 120);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(88, 17);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Remove vehicle";
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnMove
            // 
            this.BtnMove.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.BtnMove.IconColor = System.Drawing.Color.Black;
            this.BtnMove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMove.IconSize = 16;
            this.BtnMove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMove.Location = new System.Drawing.Point(37, 98);
            this.BtnMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMove.Name = "BtnMove";
            this.BtnMove.Size = new System.Drawing.Size(88, 17);
            this.BtnMove.TabIndex = 2;
            this.BtnMove.Text = "Move vehicle";
            this.BtnMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMove.UseVisualStyleBackColor = true;
            this.BtnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAdd.IconColor = System.Drawing.Color.Black;
            this.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAdd.IconSize = 16;
            this.BtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdd.Location = new System.Drawing.Point(37, 76);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(88, 17);
            this.BtnAdd.TabIndex = 1;
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
            this.BtnPrice.Location = new System.Drawing.Point(42, 73);
            this.BtnPrice.Name = "BtnPrice";
            this.BtnPrice.Size = new System.Drawing.Size(100, 23);
            this.BtnPrice.TabIndex = 0;
            this.BtnPrice.Text = "Edit Config";
            this.BtnPrice.UseVisualStyleBackColor = true;
            this.BtnPrice.Click += new System.EventHandler(this.BtnPrice_Click);
            // 
            // LabConfig
            // 
            this.LabConfig.AutoSize = true;
            this.LabConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabConfig.Location = new System.Drawing.Point(37, 12);
            this.LabConfig.Name = "LabConfig";
            this.LabConfig.Size = new System.Drawing.Size(104, 29);
            this.LabConfig.TabIndex = 13;
            this.LabConfig.Text = "Car park";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 660);
            this.Controls.Add(this.PanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private FontAwesome.Sharp.IconButton BtnRemove;
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton BtnAbout;
        private FontAwesome.Sharp.IconButton BtnMap;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}