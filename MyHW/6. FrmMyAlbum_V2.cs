using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            CreateLinkLabel();
            LoadCitytoComboBox();

            //flpCity Drag Drop
            flpCityPic2.AllowDrop = true;
            flpCityPic2.DragEnter += FlpCityPic_DragEnter;
            flpCityPic2.DragDrop += FlpCityPic_DragDrop;
        }

        private void FlpCityPic_DragDrop(object sender, DragEventArgs e)
        {
            //新增相片管理 - DragDrop
            #region
            PictureBox pic = new PictureBox();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); //取得Drop檔案的資料
            for(int i=0; i <= files.Length - 1; i++)
            {
                pic.Image = Image.FromFile(files[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 240;
                pic.Height = 160;

                flpCityPic2.Controls.Add(pic);
            }

            //Insert to DB
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
            builder.IntegratedSecurity = true;
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"Insert into Photo_V2 (Photo, CityID, Date) values (@Photo, @CityID, @Date)";
                cmd.Connection = conn;

                byte[] bytes;
                MemoryStream ms = new MemoryStream();
                pic.Image.Save(ms, ImageFormat.Jpeg); //Pic存進資料流
                bytes = ms.GetBuffer(); //建立資料流陣列
                cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = bytes;
                cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Now;
                if (cmbCity.Text == "Seoul") //ToDo try a better method-connecting table "City" to insert CityID
                {
                    cmd.Parameters.Add("@CityID", SqlDbType.Int).Value =1;
                }
                else if (cmbCity.Text == "LosAngeles")
                {
                    cmd.Parameters.Add("@CityID", SqlDbType.Int).Value = 2;
                }
                else
                {
                    cmd.Parameters.Add("@CityID", SqlDbType.Int).Value = 3;
                }
                conn.Open();
                cmd.ExecuteNonQuery();
                #endregion
            }
        }

        private void FlpCityPic_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void CreateLinkLabel()
        {
            //動態建立LinkLabel
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("select CityName from City_V2", conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        LinkLabel x = new LinkLabel();
                        x.Text = ds.Tables[0].Rows[i]["CityName"].ToString();
                        x.Left = 10;
                        x.Top = 50 * i;
                        x.Tag = i;
                        splitContainer2.Panel1.Controls.Add(x);
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
            //Click LinkLabel
            flpCityPic1.Controls.Clear();
            LinkLabel x = sender as LinkLabel;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"select Photo from Photo_V2 as p join City_V2 as c on p.CityID=c.CityID where CityName='{x.Text}'";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        byte[] bytes = (byte[])dataReader["Photo"];
                        MemoryStream ms = new MemoryStream(bytes);

                        for (int i = 0; i <= dataReader.FieldCount - 1; i++)
                        {
                            PictureBox pic = new PictureBox();
                            pic.Image = Image.FromStream(ms);
                            pic.Width = 240;
                            pic.Height = 160;
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.Click += Pic_Click;
                            flpCityPic1.Controls.Add(pic);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            //Click single pic
            Form f = new Form();
            f.BackgroundImage = ((PictureBox)sender).Image;
            f.BackgroundImageLayout = ImageLayout.Zoom;
            f.Show();
        }

        private void LoadCitytoComboBox()
        {
            //Load City to ComboBox
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("select CityName from City_V2", conn);
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string city = dataReader["CityName"].ToString();
                        cmbCity.Items.Add(city);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //After selecting City from cmbBox, show City pic
            flpCityPic2.Controls.Clear();
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"select Photo from Photo_V2 as p join City_V2 as c on p.CityID=c.CityID where CityName='{cmbCity.Text}'";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        byte[] bytes= (byte[])dataReader["Photo"];
                        MemoryStream ms = new MemoryStream(bytes);
                        
                        for(int i=0; i<=dataReader.FieldCount-1; i++)
                        {
                            PictureBox pic = new PictureBox();
                            pic.Image = Image.FromStream(ms);
                            pic.Width = 240;
                            pic.Height = 160;
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            flpCityPic2.Controls.Add(pic);
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            //Folder...
            DialogResult result = folderBrowserDialog1.ShowDialog();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = true;

            if (result == DialogResult.OK)
            {
                //ToDo insert to DB from folder
            }
            else {}
        }
    }
}
