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


        public void addSalesToGrid(List<Sales> sales)
        {

            int count = salesGrid.Rows.Count - 1;
            for (int i = 0; i < sales.Count; i++)
            {
                salesGrid.Rows.Add();
                salesGrid.Rows[count].Cells[0].Value = count + 1;
                salesGrid.Rows[count].Cells[1].Value = sales[i].ItemName;
                salesGrid.Rows[count].Cells[2].Value = sales[i].Quantity;
                count++;
            }
        }
    }
}
