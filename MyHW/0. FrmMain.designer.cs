
namespace MyHW
{
    partial class FrmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnListView = new System.Windows.Forms.Button();
            this.btnDs = new System.Windows.Forms.Button();
            this.btnAW = new System.Windows.Forms.Button();
            this.btnNW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(789, 460);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSIT ADO.NET Homework";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btnPractice);
            this.splitContainer2.Panel1.Controls.Add(this.btnQuiz);
            this.splitContainer2.Panel1.Controls.Add(this.btnListView);
            this.splitContainer2.Panel1.Controls.Add(this.btnDs);
            this.splitContainer2.Panel1.Controls.Add(this.btnAW);
            this.splitContainer2.Panel1.Controls.Add(this.btnNW);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = global::MyHW.Properties.Resources.beach_5;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Size = new System.Drawing.Size(789, 381);
            this.splitContainer2.SplitterDistance = 142;
            this.splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(8, 230);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "相片管理_V2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(8, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Product Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPractice.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPractice.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.ForeColor = System.Drawing.Color.White;
            this.btnPractice.Location = new System.Drawing.Point(8, 267);
            this.btnPractice.Margin = new System.Windows.Forms.Padding(2);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(126, 33);
            this.btnPractice.TabIndex = 6;
            this.btnPractice.Text = "標準練習";
            this.btnPractice.UseVisualStyleBackColor = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuiz.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuiz.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiz.ForeColor = System.Drawing.Color.White;
            this.btnQuiz.Location = new System.Drawing.Point(8, 304);
            this.btnQuiz.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(126, 33);
            this.btnQuiz.TabIndex = 5;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnListView
            // 
            this.btnListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListView.BackColor = System.Drawing.Color.White;
            this.btnListView.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListView.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnListView.Location = new System.Drawing.Point(8, 193);
            this.btnListView.Margin = new System.Windows.Forms.Padding(2);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(126, 33);
            this.btnListView.TabIndex = 3;
            this.btnListView.Text = "List View";
            this.btnListView.UseVisualStyleBackColor = false;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnDs
            // 
            this.btnDs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDs.BackColor = System.Drawing.Color.White;
            this.btnDs.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDs.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDs.Location = new System.Drawing.Point(8, 156);
            this.btnDs.Margin = new System.Windows.Forms.Padding(2);
            this.btnDs.Name = "btnDs";
            this.btnDs.Size = new System.Drawing.Size(126, 33);
            this.btnDs.TabIndex = 2;
            this.btnDs.Text = "DataSet結構";
            this.btnDs.UseVisualStyleBackColor = false;
            this.btnDs.Click += new System.EventHandler(this.btnDs_Click);
            // 
            // btnAW
            // 
            this.btnAW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAW.BackColor = System.Drawing.Color.White;
            this.btnAW.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAW.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAW.Location = new System.Drawing.Point(8, 82);
            this.btnAW.Margin = new System.Windows.Forms.Padding(2);
            this.btnAW.Name = "btnAW";
            this.btnAW.Size = new System.Drawing.Size(126, 33);
            this.btnAW.TabIndex = 1;
            this.btnAW.Text = "AdventureWorks";
            this.btnAW.UseVisualStyleBackColor = false;
            this.btnAW.Click += new System.EventHandler(this.btnAW_Click);
            // 
            // btnNW
            // 
            this.btnNW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNW.BackColor = System.Drawing.Color.White;
            this.btnNW.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNW.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnNW.Location = new System.Drawing.Point(8, 45);
            this.btnNW.Margin = new System.Windows.Forms.Padding(2);
            this.btnNW.Name = "btnNW";
            this.btnNW.Size = new System.Drawing.Size(126, 33);
            this.btnNW.TabIndex = 0;
            this.btnNW.Text = "Northwind";
            this.btnNW.UseVisualStyleBackColor = false;
            this.btnNW.Click += new System.EventHandler(this.btnNW_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 460);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnListView;
        private System.Windows.Forms.Button btnDs;
        private System.Windows.Forms.Button btnAW;
        private System.Windows.Forms.Button btnNW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}