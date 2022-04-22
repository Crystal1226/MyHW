using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmQuiz : Form
    {
        public FrmQuiz()
        {
            InitializeComponent();
            AddCountryList();
            CreateTreeView();
        }

        List<string> Country = new List<string>();
        List<string> CountryCount = new List<string>();
        private void AddCountryList()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select Country, Count(City) as Count from Customers group by Country order by Country", conn);
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Country.Add(dataReader["Country"].ToString());
                        string CountryAndCount = dataReader["Country"] + " (" + dataReader["Count"] + ")";
                        CountryCount.Add(CountryAndCount);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateTreeView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                   
                    for (int i = 0; i <= Country.Count - 1; i++)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand($"select distinct city, country from Customers where Country='{Country[i]}' order by country", conn);
                        SqlDataReader dataReader = cmd.ExecuteReader();

                        TreeNode nodeCountry = new TreeNode();
                        nodeCountry.Tag = 1; //Country ID
                        nodeCountry.Text = CountryCount[i];
                        treeView1.Nodes.Add(nodeCountry);

                        while (dataReader.Read())
                        {
                            TreeNode nodeCity = new TreeNode();
                            nodeCity.Tag = 2; //City ID
                            nodeCity.Text= dataReader["City"].ToString();
                            treeView1.Nodes[i].Nodes.Add(nodeCity);
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Tag is 2) //判斷selectNode是否為City
                {
                    customersTableAdapter1.FillByCity(nwDataSet1.Customers, treeView1.SelectedNode.Text);
                    dataGridView1.DataSource = nwDataSet1.Customers;
                    string count = Convert.ToString(dataGridView1.Rows.Count - 1);
                    lblResult.Text = "共 " + count + " 個" + " ' " + treeView1.SelectedNode.Text + " ' Customers";
                }
                else
                { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
