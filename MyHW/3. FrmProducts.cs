using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
            this.productsTableAdapter1.Fill(this.nwDataSet1.Products);
            this.dataGridView1.DataSource = nwDataSet1.Products;
            Binding();
        }

        private void Binding()
        {
            this.bindingSource1.DataSource = this.nwDataSet1.Products;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void btnUnitPrice_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.FillByUnitPrice(this.nwDataSet1.Products,
                int.Parse(txtPriceBottom.Text), int.Parse(txtPriceTop.Text));
            this.dataGridView1.DataSource = nwDataSet1.Products;
            Binding();

            this.lblResult.Text = "結果共" + this.bindingSource1.Count+ "筆";
        }

        private void btnProductName_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.FillByProductName(this.nwDataSet1.Products, txtProductName.Text);
            this.dataGridView1.DataSource = nwDataSet1.Products;
            Binding();

            this.lblResult.Text = "結果共" + this.bindingSource1.Count+ "筆";
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.lblPosition.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position += 1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position -= 1;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = this.bindingSource1.Count - 1;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;
        }
    }
}
