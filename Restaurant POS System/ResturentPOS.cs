using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Restaurant_POS_System
{
    public partial class ResturentPOS : Form
    {
        public ResturentPOS()
        {
            InitializeComponent();
        }



        private void btnImport_Click(object sender, EventArgs e)
        {
            importData();
        }

        private void importData()
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

        public void addItemToGrid(object sender, IdentityEventArgs e)
        {
            int count = menuGrid.Rows.Count - 1;
            menuGrid.Rows.Add();
            menuGrid.Rows[count].Cells[0].Value = count + 1;
            menuGrid.Rows[count].Cells[1].Value = e.item.ItemName;
            menuGrid.Rows[count].Cells[2].Value = e.item.ItemPrice;
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem addForm = new AddItem();
            addForm.IdentityUpdate += new AddItem.IdentityHandler(this.addItemToGrid);
            addForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
    }
}
