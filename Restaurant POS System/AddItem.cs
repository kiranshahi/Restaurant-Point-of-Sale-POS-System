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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            string itemName = txtItemName.Text;

            if (decimal.TryParse(txtItemPrice.Text, out price) && !String.IsNullOrWhiteSpace(itemName))
            {
                Item newItem = new Item();
                newItem.ItemName = itemName;
                newItem.ItemPrice = price;

                ResturentPOS mainFormObj = new ResturentPOS();
                mainFormObj.addItemToGrid(newItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("You have entered invalid input.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
