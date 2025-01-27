﻿
namespace MyHomeWork
{
    partial class FrmLogon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogon));
            this.button1 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(572, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "建立帳號 (&A)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cancel.Location = new System.Drawing.Point(420, 262);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(106, 34);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "取消(&C)";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OK.Location = new System.Drawing.Point(308, 262);
            this.OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(106, 34);
            this.OK.TabIndex = 19;
            this.OK.Text = "確定(&O)";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(312, 194);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(247, 30);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUsername.Location = new System.Drawing.Point(312, 124);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(247, 30);
            this.txtUsername.TabIndex = 16;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PasswordLabel.Location = new System.Drawing.Point(310, 170);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(248, 28);
            this.PasswordLabel.TabIndex = 17;
            this.PasswordLabel.Text = "密碼(&P)";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UsernameLabel.Location = new System.Drawing.Point(310, 100);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(248, 28);
            this.UsernameLabel.TabIndex = 14;
            this.UsernameLabel.Text = "使用者名稱(&U)";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(74, 81);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(186, 232);
            this.LogoPictureBox.TabIndex = 15;
            this.LogoPictureBox.TabStop = false;
            // 
            // FrmLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.LogoPictureBox);
            this.Name = "FrmLogon";
            this.Text = "FrmLogon";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button OK;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label PasswordLabel;
        internal System.Windows.Forms.Label UsernameLabel;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
    }
}