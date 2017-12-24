using System;
using System.Windows.Forms;

namespace Restaurant_POS_System
{
    public partial class AddItem : Form
    {
        public delegate void IdentityHandler(object sender, IdentityEventArgs e);
        public event IdentityHandler IdentityUpdate;
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

                IdentityEventArgs args = new IdentityEventArgs(newItem);
                IdentityUpdate(this, args);
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
