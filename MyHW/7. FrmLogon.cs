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
using MyHW.Properties;
using MyHW;

namespace MyHomeWork
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NorthwindConnectionString;
            try
            {
                string UserName = txtUsername.Text;
                string Password = txtPassword.Text;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"Insert into MyMember(UserName,Password) values (@UserName,@Password)";
                    command.Connection = conn;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value = UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = Password;

                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insert Member successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string connString = Settings.Default.NorthwindConnectionString;
            try
            {
                string UserName = txtUsername.Text;
                string Password = txtPassword.Text;
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"select*from MyMember where UserName=@UserName and Password=@Password";
                    command.Connection = conn;

                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 16).Value=UserName;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value=Password;
                    conn.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("Log on 成功");

                        //跳轉至FrmMain
                        FrmMain logon = new FrmMain();
                        logon.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Log on 失敗");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
