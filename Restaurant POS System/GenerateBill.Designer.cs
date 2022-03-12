﻿namespace Restaurant_POS_System
{
    partial class GenerateBill
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
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.salesItemGrid = new System.Windows.Forms.DataGridView();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridpanel = new System.Windows.Forms.Panel();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.lblTotalLable = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesItemGrid)).BeginInit();
            this.gridpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbItem
            // 
            this.cbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.ItemHeight = 25;
            this.cbItem.Location = new System.Drawing.Point(3, 62);
            this.cbItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(409, 33);
            this.cbItem.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(433, 62);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(399, 30);
            this.txtQuantity.TabIndex = 1;
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(4, 28);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(130, 29);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Item Name";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.Location = new System.Drawing.Point(428, 28);
            this.lblItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(152, 29);
            this.lblItemQuantity.TabIndex = 2;
            this.lblItemQuantity.Text = "Item Quantity";
            // 
            // salesItemGrid
            // 
            this.salesItemGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesItemGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesItemGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.itemName,
            this.itemRate,
            this.itemQuantity,
            this.itemTotal});
            this.salesItemGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesItemGrid.Location = new System.Drawing.Point(0, 0);
            this.salesItemGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesItemGrid.Name = "salesItemGrid";
            this.salesItemGrid.RowHeadersVisible = false;
            this.salesItemGrid.RowHeadersWidth = 51;
            this.salesItemGrid.Size = new System.Drawing.Size(1043, 449);
            this.salesItemGrid.TabIndex = 3;
            // 
            // sn
            // 
            this.sn.FillWeight = 50F;
            this.sn.HeaderText = "SN";
            this.sn.MinimumWidth = 6;
            this.sn.Name = "sn";
            this.sn.Width = 50;
            // 
            // itemName
            // 
            this.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            // 
            // itemRate
            // 
            this.itemRate.HeaderText = "Rate";
            this.itemRate.MinimumWidth = 6;
            this.itemRate.Name = "itemRate";
            this.itemRate.Width = 150;
            // 
            // itemQuantity
            // 
            this.itemQuantity.HeaderText = "Quantity";
            this.itemQuantity.MinimumWidth = 6;
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Width = 150;
            // 
            // itemTotal
            // 
            this.itemTotal.HeaderText = "Total";
            this.itemTotal.MinimumWidth = 6;
            this.itemTotal.Name = "itemTotal";
            this.itemTotal.Width = 150;
            // 
            // gridpanel
            // 
            this.gridpanel.Controls.Add(this.salesItemGrid);
            this.gridpanel.Location = new System.Drawing.Point(3, 102);
            this.gridpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridpanel.Name = "gridpanel";
            this.gridpanel.Size = new System.Drawing.Size(1043, 449);
            this.gridpanel.TabIndex = 4;
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnAddToBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddToBill.FlatAppearance.BorderSize = 0;
            this.btnAddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToBill.ForeColor = System.Drawing.Color.White;
            this.btnAddToBill.Location = new System.Drawing.Point(848, 62);
            this.btnAddToBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(185, 34);
            this.btnAddToBill.TabIndex = 2;
            this.btnAddToBill.Text = "Add Item";
            this.btnAddToBill.UseVisualStyleBackColor = false;
            this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
            // 
            // lblTotalLable
            // 
            this.lblTotalLable.AutoSize = true;
            this.lblTotalLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLable.Location = new System.Drawing.Point(16, 566);
            this.lblTotalLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLable.Name = "lblTotalLable";
            this.lblTotalLable.Size = new System.Drawing.Size(161, 29);
            this.lblTotalLable.TabIndex = 6;
            this.lblTotalLable.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(193, 566);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(45, 29);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "0.0";
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.btnGenerateChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateChart.FlatAppearance.BorderSize = 0;
            this.btnGenerateChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateChart.ForeColor = System.Drawing.Color.White;
            this.btnGenerateChart.Location = new System.Drawing.Point(848, 561);
            this.btnGenerateChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(185, 34);
            this.btnGenerateChart.TabIndex = 7;
            this.btnGenerateChart.Text = "Generate Chart";
            this.btnGenerateChart.UseVisualStyleBackColor = false;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // GenerateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 619);
            this.Controls.Add(this.btnGenerateChart);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalLable);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.gridpanel);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cbItem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GenerateBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateBill";
            ((System.ComponentModel.ISupportInitialize)(this.salesItemGrid)).EndInit();
            this.gridpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.DataGridView salesItemGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotal;
        private System.Windows.Forms.Panel gridpanel;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.Label lblTotalLable;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnGenerateChart;
    }
}