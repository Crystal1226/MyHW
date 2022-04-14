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

            //Disconnected - DataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter("select CategoryName from Categories", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            for(int i=0; i<=ds.Tables[0].Rows.Count-1; i++)
            {
                this.comboBox2.Items.Add(ds.Tables[0].Rows[i]["CategoryName"]);
            }
            // todo disconnected

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
