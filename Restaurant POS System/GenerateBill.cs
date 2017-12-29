using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant_POS_System
{
    public partial class GenerateBill : Form
    {
        decimal totalAmount = 0;
        public GenerateBill(List<Item> items)
        {
            InitializeComponent();
            cbItem.DataSource = items;
            cbItem.ValueMember = "ItemPrice";
            cbItem.DisplayMember = "ItemName";
        }

        public GenerateBill()
        {
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                if (salesItemGrid.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in salesItemGrid.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value) == cbItem.Text)
                        {
                            row.Cells[3].Value = Convert.ToInt32(txtQuantity.Text) + Convert.ToInt32(row.Cells[3].Value);
                            row.Cells[4].Value = Convert.ToInt32(row.Cells[3].Value) * Convert.ToDecimal(cbItem.SelectedValue);
                            totalAmount += Convert.ToInt32(txtQuantity.Text) * Convert.ToDecimal(cbItem.SelectedValue);
                            lblTotalAmount.Text = totalAmount.ToString();
                            isExist = true;
                        }
                    }
                    if (!isExist)
                    {
                        int count = salesItemGrid.Rows.Count - 1;
                        salesItemGrid.Rows.Add();
                        salesItemGrid.Rows[count].Cells[0].Value = count + 1;
                        salesItemGrid.Rows[count].Cells[1].Value = cbItem.Text;
                        salesItemGrid.Rows[count].Cells[2].Value = cbItem.SelectedValue;
                        salesItemGrid.Rows[count].Cells[3].Value = txtQuantity.Text;
                        salesItemGrid.Rows[count].Cells[4].Value = Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(cbItem.SelectedValue);
                        totalAmount += Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(cbItem.SelectedValue);
                        lblTotalAmount.Text = totalAmount.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Quantity must be number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            List<Sales> salesList = new List<Sales>();
            for (int i = 0; i < salesItemGrid.Rows.Count - 1; i++)
            {

                int sn = Convert.ToInt32(salesItemGrid.Rows[i].Cells[0].Value);
                string itemName = salesItemGrid.Rows[i].Cells[1].Value.ToString();
                int quantity = Convert.ToInt32(salesItemGrid.Rows[i].Cells[3].Value);
                salesList.Add(new Sales() { SN = sn, ItemName = itemName, Quantity = quantity });
            }
            SalesChart salesChart = new SalesChart(salesList);
            salesChart.Show();
            this.Close();
        }
    }
}