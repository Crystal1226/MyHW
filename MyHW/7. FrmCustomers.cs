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
using SortOrder = System.Data.SqlClient.SortOrder;

namespace MyHW
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
            this.listView1.View = View.Details;
            LoadCountryToComboBox();
            CreateListViewColumns();
        }

        private void LoadCountryToComboBox()
        {
            //Add country to comboBox
            string connString = Settings.Default.NorthwindConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("select distinct Country from Customers",conn);                  
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        for (int i = 0; i <= dataReader.FieldCount - 1; i++)
                        {
                            this.comboBox1.Items.Add(dataReader[i]);
                        }
                        this.comboBox1.Text = "Select Country";
                    }
                    this.comboBox1.Items.Add("All Country");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateListViewColumns()
        {
            //Add Column Head
            string connString = Settings.Default.NorthwindConnectionString;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("select*from Customers", conn);
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    DataTable table = dataReader.GetSchemaTable();
                    for (int i = 0; i <= table.Rows.Count - 1; i++)
                    {
                        this.listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = Settings.Default.NorthwindConnectionString;
            try
            {
                if(comboBox1.Text=="All Country")
                {
                    //Select all Country
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        SqlCommand command = new SqlCommand("select*from Customers", conn);
                        conn.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        this.listView1.Items.Clear();
                        Random random = new Random();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString()); //加入主Item
                            for (int i = 0; i <= dataReader.FieldCount - 1; i++) //加入次Item
                            {
                                lvi.ImageIndex = random.Next(0, this.ImageList2.Images.Count);  //隨機加入國旗
                                if (dataReader.IsDBNull(i)) //判斷是否為空值
                                {
                                    lvi.SubItems.Add("null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
                            }
                            if (lvi.Index % 2 == 1)
                            {
                                lvi.BackColor = Color.WhiteSmoke;
                            }
                            else
                            {
                                lvi.BackColor = Color.Lavender;
                            }
                        }
                    }
                }
                else
                {
                    //Select specific country
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"select*from Customers where Country='{comboBox1.Text}'";
                        command.Connection = conn;
                        conn.Open();
                        SqlDataReader dataReader = command.ExecuteReader();

                        this.listView1.Items.Clear();
                        Random random = new Random();
                        while (dataReader.Read())
                        {
                            ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString()); //加入主Item
                            for (int i = 0; i <= dataReader.FieldCount - 1; i++) //加入次Item
                            {
                                lvi.ImageIndex = random.Next(0, this.ImageList2.Images.Count);  //隨機加入國旗
                                if (dataReader.IsDBNull(i)) //判斷是否為空值
                                {
                                    lvi.SubItems.Add("null");
                                }
                                else
                                {
                                    lvi.SubItems.Add(dataReader[i].ToString());
                                }
                            }
                            if (lvi.Index % 2 == 1)
                            {
                                lvi.BackColor = Color.WhiteSmoke;
                            }
                            else
                            {
                                lvi.BackColor = Color.Lavender;
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Details
            listView1.View = View.Details;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Large Icon
            listView1.View = View.LargeIcon;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Small Icon
            listView1.View = View.SmallIcon;
        }

        private void customerIDAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Order by CustomerID Asc
           
        }

        private void customerIDDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Order by CustomerID Desc
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Group by Country
           
            
        }
    }
}


        

        //TODO HW

        //1. All Country
       

        //================================
         //2. ContextMenuStrip2
         //選擇性作業
        //Groups
        //USA (100) 
        //UK (20)

        //this.listview1.visible = false;
        //ListViewItem lvi = this.listView1.Items.Add(dataReader[0].ToString());

        //if (this.listView1.Groups["USA"] == null)
        //{                       {
        //    ListViewGroup group = this.listView1.Groups.Add("USA", "USA"); //Add(string key, string headerText);
        //    group.Tag = 0;
        //    lvi.Group = group; 
        //}
        //else
        //{
        //    ListViewGroup group = this.listView1.Groups["USA"]; 
        //    lvi.Group = group;
        //}

        //this.listView1.Groups["USA"].Tag = 
        //this.listView1.Groups["USA"].Header = 
                                 
