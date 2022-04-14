using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyHomeWork
{
    public partial class FrmAdventureWorks : Form
    {
        public FrmAdventureWorks()
        {
            InitializeComponent();

            //Year
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT distinct Year(ModifiedDate) as d  FROM Production.ProductPhoto", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for(int i=0; i<=ds.Tables[0].Rows.Count-1; i++)
            {
                this.comboBox1.Items.Add(ds.Tables[0].Rows[i]["d"]);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal date = Convert.ToDecimal(comboBox1.Text);
            this.productPhotoTableAdapter1.FillByYear(this.awDataSet1.ProductPhoto, date);
            this.dataGridView1.DataSource = this.awDataSet1.ProductPhoto;

            //SqlConnection conn1 = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks;Integrated Security=True");
            //string connString = $"SELECT * FROM Production.ProductPhoto where Year(ModifiedDate)='{comboBox1.Text}'";
            //SqlDataAdapter adapter = new SqlDataAdapter(connString,conn1);
            //DataSet ds1 = new DataSet();
            //adapter.Fill(ds1);
            //this.dataGridView1.DataSource = ds1.Tables[0];

            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            this.lblPosition.Text = $"{this.bindingSource1.Position + 1} / {this.bindingSource1.Count}";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position -= 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = bindingSource1.Count+1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.bindingSource1.Position = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);

            //某日期區間的腳踏車
            this.productPhotoTableAdapter1.FillByDate(awDataSet1.ProductPhoto,dateTimePicker1.Value,dateTimePicker2.Value);
            this.dataGridView1.DataSource = this.awDataSet1.ProductPhoto;

            //Binding Source & Navigator
            this.bindingSource1.DataSource = this.awDataSet1.ProductPhoto;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
        }
    }
}
