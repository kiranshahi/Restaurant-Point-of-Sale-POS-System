using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Restaurant_POS_System
{
    public partial class ResturentPOS : Form
    {
        private int row;
        public ResturentPOS()
        {
            InitializeComponent();
        }

        private void ImportData()
        {
            using (OpenFileDialog openDialog = new OpenFileDialog()
            {
                Filter = "CSV|*.csv",
                ValidateNames = true,
                Multiselect = false
            })
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string[]> menuList = new List<string[]>();
                    try
                    {
                        using (Stream stream = null)
                        {
                            string[] rows = File.ReadAllLines(openDialog.FileName);
                            foreach (string csvRow in rows)
                            {
                                bool inQuotes = false;
                                List<string> fields = new List<string>();
                                string field = "";
                                for (int i = 0; i < csvRow.Length; i++)
                                {
                                    if (inQuotes)
                                    {
                                        if (i < csvRow.Length - 1 && csvRow[i] == '"' && csvRow[i + 1] == '"')
                                        {
                                            i = i++;
                                            field += '"';
                                        }
                                        else if (csvRow[i] == '"')
                                        {
                                            inQuotes = false;
                                        }
                                        else
                                        {
                                            if (csvRow[i - 1] == '"')
                                            {
                                                field = "";
                                                field += csvRow[i];
                                            }
                                            else
                                            {
                                                field += csvRow[i];
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (csvRow[i] == '"')
                                        {
                                            inQuotes = true;
                                        }
                                        if (csvRow[i] == ',')
                                        {
                                            fields.Add(field);
                                            field = "";
                                        }
                                        else
                                        {
                                            field += csvRow[i];
                                        }
                                    }
                                }
                                if (!string.IsNullOrEmpty(field))
                                {
                                    fields.Add(field);
                                    field = "";
                                }
                                menuList.Add(fields.ToArray());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    int count = menuGrid.Rows.Count;
                    foreach (string[] value in menuList)
                    {
                        menuGrid.Rows.Add(count, value[0], value[1]);
                        count++;
                    }
                }
        }

        public void AddItemToGrid(object sender, IdentityEventArgs e)
        {
            int count = menuGrid.Rows.Count - 1;
            menuGrid.Rows.Add();
            menuGrid.Rows[count].Cells[0].Value = count + 1;
            menuGrid.Rows[count].Cells[1].Value = e.item.ItemName;
            menuGrid.Rows[count].Cells[2].Value = e.item.ItemPrice;
        }

        private void AddItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem addForm = new AddItem();
            addForm.IdentityUpdate += new AddItem.IdentityHandler(this.AddItemToGrid);
            addForm.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                menuGrid.Rows.RemoveAt(menuGrid.CurrentCell.RowIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while deleting menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Item itemObj = new Item();
                row = menuGrid.CurrentCell.RowIndex;
                itemObj.ItemName = menuGrid.Rows[row].Cells[1].Value.ToString();
                itemObj.ItemPrice = Convert.ToDecimal(menuGrid.Rows[row].Cells[2].Value);

                AddItem addItem = new AddItem();
                addItem.loadData(itemObj);
                addItem.IdentityUpdate += new AddItem.IdentityHandler(this.UpdateMenu);
                addItem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateMenu(object sender, IdentityEventArgs e)
        {
            menuGrid.Rows[row].Cells[1].Value = e.item.ItemName;
            menuGrid.Rows[row].Cells[2].Value = e.item.ItemPrice;
        }

        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to close the system. Do you want to close?", "Resturent POS System", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportData();
        }

        private void GenerateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Item> itemList = GenerateListFromGrid();

            GenerateBill billObj = new GenerateBill(itemList);
            billObj.Show();
        }

        private List<Item> GenerateListFromGrid()
        {
            List<Item> itemList = new List<Item>();
            for (int i = 0; i < menuGrid.Rows.Count - 1; i++)
            {
                int SN = Convert.ToInt32(menuGrid.Rows[i].Cells[0].Value);
                string ItemName = menuGrid.Rows[i].Cells[1].Value.ToString();
                decimal ItemPrice = Convert.ToDecimal(menuGrid.Rows[i].Cells[2].Value);
                itemList.Add(new Item() { SN = SN, ItemName = ItemName, ItemPrice = ItemPrice });
            }
            return itemList;
        }

        private void ListToGrid(List<Item> itemList)
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                menuGrid.Rows[i].Cells[0].Value = i + 1;
                menuGrid.Rows[i].Cells[1].Value = itemList[i].ItemName;
                menuGrid.Rows[i].Cells[2].Value = itemList[i].ItemPrice;
            }
        }

        private void ItemAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool sorted = false;
            List<Item> itemList = GenerateListFromGrid();
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < itemList.Count - 1; i++)
                {
                    if (String.Compare(itemList[i].ItemName, itemList[i + 1].ItemName) > 0)
                    {
                        sorted = false;
                        Item tempItem = itemList[i];
                        itemList[i] = itemList[i + 1];
                        itemList[i + 1] = tempItem;
                    }
                }
            }
            ListToGrid(itemList);
        }

        private void ItemDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool sorted = false;
            List<Item> itemList = GenerateListFromGrid();
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < itemList.Count - 1; i++)
                {
                    if (String.Compare(itemList[i].ItemName, itemList[i + 1].ItemName) < 0)
                    {
                        sorted = false;
                        Item tempItem = itemList[i];
                        itemList[i] = itemList[i + 1];
                        itemList[i + 1] = tempItem;
                    }
                }
            }
            ListToGrid(itemList);
        }

        private void PriceAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool sorted = false;
            List<Item> itemList = GenerateListFromGrid();
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < itemList.Count - 1; i++)
                {
                    if (itemList[i].ItemPrice > itemList[i + 1].ItemPrice)
                    {
                        sorted = false;
                        Item tempItem = itemList[i];
                        itemList[i] = itemList[i + 1];
                        itemList[i + 1] = tempItem;
                    }
                }
            }
            ListToGrid(itemList);
        }

        private void PriceDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool sorted = false;
            List<Item> itemList = GenerateListFromGrid();
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < itemList.Count - 1; i++)
                {
                    if (itemList[i].ItemPrice < itemList[i + 1].ItemPrice)
                    {
                        sorted = false;
                        Item tempItem = itemList[i];
                        itemList[i] = itemList[i + 1];
                        itemList[i + 1] = tempItem;
                    }
                }
            }
            ListToGrid(itemList);
        }
    }
}