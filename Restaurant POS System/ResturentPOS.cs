using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_POS_System
{
    public partial class ResturentPOS : Form
    {
        public ResturentPOS()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            string itemName = txtItemName.Text;

            if (decimal.TryParse(txtItemPrice.Text, out price) && !String.IsNullOrWhiteSpace(itemName))
            {
                int count = menuGrid.Rows.Count - 1;
                menuGrid.Rows.Add();
                menuGrid.Rows[count].Cells[0].Value = count + 1;
                menuGrid.Rows[count].Cells[1].Value = itemName;
                menuGrid.Rows[count].Cells[2].Value = price;
            }
            else
            {
                MessageBox.Show("You have entered invalid input.", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
