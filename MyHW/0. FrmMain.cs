using MyHomeWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace MyHW
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        internal void ShowFrm(Form f)
        {
            splitContainer2.Panel2.Controls.Clear();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();
        }

        private void btnNW_Click(object sender, EventArgs e)
        {
            FrmCategoryProducts f = new FrmCategoryProducts();
            ShowFrm(f);
        }

        private void btnAW_Click(object sender, EventArgs e)
        {
            FrmAdventureWorks f = new FrmAdventureWorks();
            ShowFrm(f);
        }

        private void btnDs_Click(object sender, EventArgs e)
        {
            FrmDataSet_結構 f = new FrmDataSet_結構();
            ShowFrm(f);
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            FrmCustomers f = new FrmCustomers();
            ShowFrm(f);
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            FrmHomeWork f = new FrmHomeWork();
            ShowFrm(f);
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            FrmQuiz f = new FrmQuiz();
            ShowFrm(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProducts f = new FrmProducts();
            ShowFrm(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMyAlbum_V2 f = new FrmMyAlbum_V2();
            ShowFrm(f);
        }
    }
}
