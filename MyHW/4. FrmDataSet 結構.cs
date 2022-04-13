using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmDataSet_結構 : Form
    {
        public FrmDataSet_結構()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.categoriesTableAdapter1.Fill(this.nwDataSet1.Categories);
            this.customersTableAdapter1.Fill(this.nwDataSet1.Customers);

            this.dataGridView1.DataSource = this.nwDataSet1.Products;
            this.dataGridView2.DataSource = this.nwDataSet1.Categories;
            this.dataGridView3.DataSource = this.nwDataSet1.Customers;

            for(int i=0; i<=nwDataSet1.Tables.Count-1; i++)
            {
                DataTable table = this.nwDataSet1.Tables[i];
                this.listBox1.Items.Add(table.TableName);

                string columnName = "";
                for(int column=0; column<=table.Columns.Count-1; column++)
                {
                    columnName += table.Columns[column].ColumnName+"  ";
                }
                this.listBox1.Items.Add(columnName);

                string rowData = "";
                for (int row = 0; row <= table.Rows.Count - 1; row++)
                {
                    rowData = "";
                    for (int c = 0; c <= table.Columns.Count - 1; c++)
                    {
                        rowData+=table.Rows[row][c]+"\t";
                    }
                    this.listBox1.Items.Add(rowData);
                }
                this.listBox1.Items.Add("\n");
            }
        }
    }
}
