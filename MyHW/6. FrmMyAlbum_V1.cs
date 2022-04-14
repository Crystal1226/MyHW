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

namespace MyHW
{
    public partial class FrmMyAlbum_V1 : Form
    {
        public FrmMyAlbum_V1()
        {
            InitializeComponent();

            //this.cityTableAdapter1.Fill(this.myAlbumDataSet1.City);
            //this.dataGridView1.DataSource = this.myAlbumDataSet1.City;

            SqlConnection conn = null;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
            builder.IntegratedSecurity = true;
            try
            {
                using (conn = new SqlConnection(builder.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select CityName from City", conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    for (int i = 0; i <= ds.Tables[0].Rows.Count-1; i++)
                    {
                        LinkLabel x = new LinkLabel();
                        x.Text=ds.Tables[0].Rows[i]["CityName"].ToString();
                        x.Left = 5;
                        x.Top = 30 * i;
                        x.Tag = i;
                        this.panelCity.Controls.Add(x);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
    }
}
