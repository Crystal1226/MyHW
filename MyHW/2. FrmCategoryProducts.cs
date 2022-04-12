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
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            //Connected
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();

            SqlCommand command = new SqlCommand("select CategoryName from Categories", conn);

            SqlDataReader dataReader1 = command.ExecuteReader();
            while (dataReader1.Read())
            {
                this.comboBox1.Items.Add(dataReader1["CategoryName"]);
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            conn.Open();

            string cmdText = $"select ProductName from Products as p join Categories as c on p.CategoryID=c.CategoryID where CategoryName='{comboBox1.Text}'";
            SqlCommand command = new SqlCommand(cmdText, conn);

            SqlDataReader dataReader2 = command.ExecuteReader();
            this.listBox1.Items.Clear();
            while (dataReader2.Read())
            {
                this.listBox1.Items.Add(dataReader2["ProductName"]);
            }
            conn.Close();
        }
    }
}
