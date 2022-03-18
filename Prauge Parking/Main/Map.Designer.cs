namespace Prauge_Parking.Main
{
    partial class Map
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
            this.DetailedView = new System.Windows.Forms.DataGridView();
            this.Pos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetailedView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailedView
            // 
            this.DetailedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pos,
            this.Reg,
            this.Arrival,
            this.Price});
            this.DetailedView.Location = new System.Drawing.Point(62, 266);
            this.DetailedView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailedView.Name = "DetailedView";
            this.DetailedView.RowHeadersWidth = 51;
            this.DetailedView.RowTemplate.Height = 29;
            this.DetailedView.Size = new System.Drawing.Size(561, 258);
            this.DetailedView.TabIndex = 0;
            // 
            // Pos
            // 
            this.Pos.HeaderText = "Postion";
            this.Pos.MinimumWidth = 6;
            this.Pos.Name = "Pos";
            this.Pos.ReadOnly = true;
            this.Pos.Width = 125;
            // 
            // Reg
            // 
            this.Reg.HeaderText = "Regrestarion";
            this.Reg.MinimumWidth = 6;
            this.Reg.Name = "Reg";
            this.Reg.ReadOnly = true;
            this.Reg.Width = 125;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival ";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DetailedView);
            this.Name = "Map";
            this.Size = new System.Drawing.Size(1083, 602);
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailedView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView DetailedView;
        private DataGridViewTextBoxColumn Pos;
        private DataGridViewTextBoxColumn Reg;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Price;
    }
}
