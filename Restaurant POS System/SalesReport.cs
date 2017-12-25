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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void addSalesToGrid()
        {
            GenerateBill generateBill = new GenerateBill();
            generateBill.IdentityUpdate += new GenerateBill.IdentityHandler(this.addSalesToGrid);
        }

        public void addSalesToGrid(object sender, IdentityEventArgs e)
        {
            int count = salesGrid.Rows.Count - 1;
            foreach (Sales item in e.sales)
            {
                salesGrid.Rows.Add();
                salesGrid.Rows[count].Cells[0].Value = count + 1;
                salesGrid.Rows[count].Cells[1].Value = item.ItemName;
                salesGrid.Rows[count].Cells[2].Value = item.Quantity;
                count++;
            }
        }
    }
}
