using Microsoft.Build.Framework.XamlTypes;
using MyHW.Properties;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace MyHW
{
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            CreateLinkLabel();
            LoadCitytoComboBox();
            LoadDatatoTool();

            //flpCity Drag Drop
            flpCityPic2.AllowDrop = true;
            flpCityPic2.DragEnter += FlpCityPic_DragEnter;
            flpCityPic2.DragDrop += FlpCityPic_DragDrop;
        }
        #region //瀏覽相片
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
            //Click LinkLabel show City pic
            flpCityPic1.Controls.Clear();
            LinkLabel x = sender as LinkLabel;
            int cityID = (int)x.Tag + 1; //將LinkLabel Tag轉換為cityID(for TableAdapter參數)

            //Fill隱藏的dataGridView
            photo_V2TableAdapter1.FillByCity(myAlbumDataSet1.Photo_V2, cityID);
            bindingSource1.DataSource = myAlbumDataSet1.Photo_V2;
            dataGridView1.DataSource = bindingSource1;
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
                            pic.MouseEnter += Pic_MouseEnter;
                            pic.MouseLeave += Pic_MouseLeave;
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
        FrmPicture f;
        PictureBox pic;
        private void Pic_Click(object sender, EventArgs e)
        {
            //Click single pic
            f = new FrmPicture();
            pic = new PictureBox();
            int position = flpCityPic1.Controls.IndexOf((PictureBox)sender);
            bindingSource1.Position = position;
            pic.DataBindings.Add("Image", bindingSource1, "Photo", true);
            ShowPicToFrmPicture();
        }

        private void ShowPicToFrmPicture()
        {
            f.Controls.Add(pic);
            pic.Dock = DockStyle.Fill;
            pic.SizeMode = PictureBoxSizeMode.Zoom;

            ToolStrip t = new ToolStrip();
            t.Dock = DockStyle.Bottom;
            f.Controls.Add(t);

            ToolStripButton btnSize = new ToolStripButton();
            btnSize.Text = "實際大小";
            t.Items.Add(btnSize);
            btnSize.Click += BtnSize_Click;

            ToolStripButton btnPrevious = new ToolStripButton();
            btnPrevious.Text = "上一張";
            t.Items.Add(btnPrevious);
            btnPrevious.Click += BtnPrevious_Click;

            ToolStripButton btnPlay = new ToolStripButton();
            btnPlay.Text = "自動播放";
            t.Items.Add(btnPlay);
            btnPlay.Click += BtnPlay_Click;
            
            ToolStripButton btnNext = new ToolStripButton();
            btnNext.Text = "下一張";
            t.Items.Add(btnNext);
            btnNext.Click += BtnNext_Click;

            f.Show();
        }
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bindingSource1.Position == bindingSource1.Count - 1)
            {
                bindingSource1.Position = 0;
            }
            else
            {
                bindingSource1.Position += 1;
            }
        }

        bool OriginalSize = false;
        private void BtnSize_Click(object sender, EventArgs e)
        {
            if (OriginalSize == false)
            {
                pic.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            }
            OriginalSize = !OriginalSize;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            bindingSource1.Position += 1;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            bindingSource1.Position -= 1;
        }

        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.Padding = new Padding(5);
            p.BackColor = Color.CornflowerBlue; 
        }
        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.Padding = new Padding(0);
            p.BackColor = Color.Transparent;
        }
        #endregion

        #region //新增相片管理
        private void FlpCityPic_DragDrop(object sender, DragEventArgs e)
        {
            //DragDrop
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
            builder.IntegratedSecurity = true;
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); //取得Drop檔案的資料
                for (int i = 0; i <= files.Length - 1; i++)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Insert into Photo_V2 (Photo, CityID, Date) values (@Photo, @CityID, @Date)";
                    cmd.Connection = conn;

                    //建立PictureBox
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(files[i]);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Width = 240;
                    pic.Height = 160;
                    pic.MouseEnter += Pic_MouseEnter;
                    pic.MouseLeave += Pic_MouseLeave;
                    flpCityPic2.Controls.Add(pic);

                    //建立MemoryStream - 將pic存入
                    MemoryStream ms = new MemoryStream();
                    pic.Image.Save(ms, ImageFormat.Jpeg);

                    //將MemoryStream資料存入byte陣列
                    byte[] bytes;
                    bytes = ms.GetBuffer();

                    //Insert to DB
                    cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = bytes;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Now;
                    if (cmbCity.Text == "Seoul") //ToDo try better method-connecting table "City" to insert CityID
                    {
                        cmd.Parameters.Add("@CityID", SqlDbType.Int).Value = 1;
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
                    conn.Close();
                }
            }
        }

        private void FlpCityPic_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
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
                            pic.MouseEnter += Pic_MouseEnter;
                            pic.MouseLeave += Pic_MouseLeave;
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
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"(LocalDB)\MSSQLLocalDB";
                builder.AttachDBFilename = Application.StartupPath + @"\MyAlbum.mdf";
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath); //取得Folder中的資料
                    for (int i = 0; i <= files.Length - 1; i++) //加入每張pic為picBox & insert to DB
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = $"Insert into Photo_V2 (Photo, CityID, Date) values (@Photo, @CityID, @Date)";
                        cmd.Connection = conn;

                        //建立PictureBox
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(files[i]);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        pic.Width = 240;
                        pic.Height = 160;
                        flpCityPic2.Controls.Add(pic);

                        
                        //建立MemoryStream - 將pic存入
                        MemoryStream ms = new MemoryStream();
                        pic.Image.Save(ms, ImageFormat.Jpeg); //Pic存進資料流

                        //將MemoryStream資料存入byte陣列
                        byte[] bytes;
                        bytes = ms.GetBuffer();

                        //Insert to DB
                        cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = bytes;
                        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Now;
                        if (cmbCity.Text == "Seoul")
                        {
                            cmd.Parameters.Add("@CityID", SqlDbType.Int).Value = 1;
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
                        conn.Close();
                    }
                }
            }
            else { }
        }
        #endregion

        #region //Tool
        private void LoadDatatoTool()
        {
            //Load Data to Photo City
            city_V2TableAdapter1.Fill(myAlbumDataSet1.City_V2);
            city_V2DataGridView.DataSource = myAlbumDataSet1.City_V2;
            city_V2DataGridView.DataSource = city_V2BindingSource;

            //Load Data to Photos
            photo_V2TableAdapter1.FillByCity(myAlbumDataSet1.Photo_V2, city_V2BindingSource.Position + 1);
            photo_V2DataGridView.DataSource = myAlbumDataSet1.Photo_V2;
            city_V2BindingSource.CurrentChanged += City_V2BindingSource_CurrentChanged;
            photo_V2DataGridView.DataSource = photo_V2BindingSource;
            bindingNavigator1.BindingSource = photo_V2BindingSource;
        }

        private void City_V2BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //When Photo City changes
            photo_V2TableAdapter1.FillByCity(myAlbumDataSet1.Photo_V2, city_V2BindingSource.Position + 1);
            photo_V2DataGridView.DataSource = myAlbumDataSet1.Photo_V2;
            photo_V2DataGridView.DataSource = photo_V2BindingSource;
            bindingNavigator1.BindingSource = photo_V2BindingSource;
        }
        private void city_V2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.city_V2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbumDataSet1);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                photoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }
    }
}
#endregion