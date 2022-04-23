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
    public partial class FrmToolCRUD : Form
    {
        public FrmToolCRUD()
        {
            InitializeComponent();          
        }

        private void photoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(myAlbumDataSet);
            //this.photoTableAdapter.Update(myAlbumDataSet.Photo);
        }

        private void FrmToolCRUD_Load(object sender, EventArgs e)
        {
            this.photoTableAdapter.Fill(this.myAlbumDataSet.Photo);
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
