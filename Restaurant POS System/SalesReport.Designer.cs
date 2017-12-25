namespace Restaurant_POS_System
{
    partial class SalesReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.salesGrid = new System.Windows.Forms.DataGridView();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenChart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salesGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 462);
            this.panel1.TabIndex = 0;
            // 
            // salesGrid
            // 
            this.salesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.itemName,
            this.itemQuantity});
            this.salesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesGrid.Location = new System.Drawing.Point(0, 0);
            this.salesGrid.Name = "salesGrid";
            this.salesGrid.RowHeadersVisible = false;
            this.salesGrid.Size = new System.Drawing.Size(787, 462);
            this.salesGrid.TabIndex = 0;
            // 
            // sn
            // 
            this.sn.HeaderText = "SN";
            this.sn.Name = "sn";
            this.sn.Width = 50;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            // 
            // itemQuantity
            // 
            this.itemQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemQuantity.HeaderText = "Item Quantity";
            this.itemQuantity.Name = "itemQuantity";
            // 
            // btnGenChart
            // 
            this.btnGenChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnGenChart.FlatAppearance.BorderSize = 0;
            this.btnGenChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenChart.ForeColor = System.Drawing.Color.White;
            this.btnGenChart.Location = new System.Drawing.Point(635, 468);
            this.btnGenChart.Name = "btnGenChart";
            this.btnGenChart.Size = new System.Drawing.Size(152, 35);
            this.btnGenChart.TabIndex = 17;
            this.btnGenChart.Text = "Generate Chart";
            this.btnGenChart.UseVisualStyleBackColor = false;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 503);
            this.Controls.Add(this.btnGenChart);
            this.Controls.Add(this.panel1);
            this.Name = "SalesReport";
            this.Text = "SalesReport";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView salesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.Button btnGenChart;
    }
}