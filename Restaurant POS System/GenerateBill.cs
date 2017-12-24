using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnAddToBill_Click(object sender, EventArgs e)
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
