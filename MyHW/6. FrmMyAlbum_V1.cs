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
            try
            {
                this.bindingSource1.DataSource = myAlbumDataSet1.Photo;
                this.bindingSource2.DataSource = myAlbumDataSet1.City;
                
                //動態建立LinkLabel
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
                    for (int i = 0; i <= ds.Tables[0].Rows.Count-1; i++)
                    {
                        LinkLabel x = new LinkLabel();
                        x.Text=ds.Tables[0].Rows[i]["CityName"].ToString();
                        x.Left = 5;
                        x.Top = 30 * i;
                        x.Tag = i;
                        this.panelCity.Controls.Add(x);
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
            try
            {
                LinkLabel x = sender as LinkLabel;

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf"; //Application.StartupPath：exe檔所在位置
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    conn.Open();
                    this.photoTableAdapter1.FillByCity(myAlbumDataSet1.Photo,x.Text);
                    photoDataGridView.DataSource = myAlbumDataSet1.Photo;
                }
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    conn.Open();
                    cityTableAdapter1.FillByCity2(myAlbumDataSet1.City, x.Text);
                    txtCityID.DataBindings.Add("Text",bindingSource2, "CityID");
                    txtCityName.DataBindings.Add("Text", bindingSource2, "CityName");
                    txtCountry.DataBindings.Add("Text", bindingSource2, "Country");

                    txtCityID.DataBindings.Clear();
                    txtCityName.DataBindings.Clear();
                    txtCountry.DataBindings.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmToolCRUD crud = new FrmToolCRUD();
            crud.Show();
        }
    }
}
