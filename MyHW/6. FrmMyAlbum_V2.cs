using Microsoft.Build.Framework.XamlTypes;
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
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            try
            {
                //Photo binding
                this.bindingSource1.DataSource = myAlbumDataSet1.Photo;
                //this.flowLayoutPanel2.
                //    DataSource = this.bindingSource1;

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select CityName from City", conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        LinkLabel x = new LinkLabel();
                        x.Text = ds.Tables[0].Rows[i]["CityName"].ToString();
                        x.Left = 5;
                        x.Top = 30 * i;
                        x.Tag = i;
                        //this.panelCity.Controls.Add(x);
                        x.Click += X_Click;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void X_Click(object sender, EventArgs e)
        {
            
        }
    }
}
