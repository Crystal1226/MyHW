﻿
namespace MyHW
{
    partial class FrmCustomers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerIDAscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerIDDescToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.無ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 30);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country:";
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip2;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ImageList2;
            this.listView1.Location = new System.Drawing.Point(0, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1137, 511);
            this.listView1.SmallImageList = this.ImageList1;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.orderByToolStripMenuItem,
            this.groupByToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(186, 154);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 30);
            this.toolStripMenuItem1.Text = "Details View";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 30);
            this.toolStripMenuItem2.Text = "Large Icon";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 30);
            this.toolStripMenuItem3.Text = "Small Icon";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // orderByToolStripMenuItem
            // 
            this.orderByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDAscToolStripMenuItem,
            this.customerIDDescToolStripMenuItem});
            this.orderByToolStripMenuItem.Name = "orderByToolStripMenuItem";
            this.orderByToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.orderByToolStripMenuItem.Text = "Order by";
            // 
            // customerIDAscToolStripMenuItem
            // 
            this.customerIDAscToolStripMenuItem.Name = "customerIDAscToolStripMenuItem";
            this.customerIDAscToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.customerIDAscToolStripMenuItem.Text = "CustomerID Asc";
            this.customerIDAscToolStripMenuItem.Click += new System.EventHandler(this.customerIDAscToolStripMenuItem_Click);
            // 
            // customerIDDescToolStripMenuItem
            // 
            this.customerIDDescToolStripMenuItem.Name = "customerIDDescToolStripMenuItem";
            this.customerIDDescToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.customerIDDescToolStripMenuItem.Text = "CustomerID Desc";
            this.customerIDDescToolStripMenuItem.Click += new System.EventHandler(this.customerIDDescToolStripMenuItem_Click);
            // 
            // groupByToolStripMenuItem
            // 
            this.groupByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.無ToolStripMenuItem});
            this.groupByToolStripMenuItem.Name = "groupByToolStripMenuItem";
            this.groupByToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.groupByToolStripMenuItem.Text = "Group by";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // 無ToolStripMenuItem
            // 
            this.無ToolStripMenuItem.Name = "無ToolStripMenuItem";
            this.無ToolStripMenuItem.Size = new System.Drawing.Size(178, 34);
            this.無ToolStripMenuItem.Text = "無";
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList2.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList2.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList2.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList2.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList2.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList2.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList2.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList2.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList2.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList2.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList2.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList2.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList2.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList2.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList2.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList2.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList2.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList2.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "FLGGERM.ICO");
            this.ImageList1.Images.SetKeyName(1, "CTRCAN.ICO");
            this.ImageList1.Images.SetKeyName(2, "CTRFRAN.ICO");
            this.ImageList1.Images.SetKeyName(3, "CTRGERM.ICO");
            this.ImageList1.Images.SetKeyName(4, "CTRITALY.ICO");
            this.ImageList1.Images.SetKeyName(5, "CTRJAPAN.ICO");
            this.ImageList1.Images.SetKeyName(6, "CTRMEX.ICO");
            this.ImageList1.Images.SetKeyName(7, "CTRSKOR.ICO");
            this.ImageList1.Images.SetKeyName(8, "CTRSPAIN.ICO");
            this.ImageList1.Images.SetKeyName(9, "CTRUK.ICO");
            this.ImageList1.Images.SetKeyName(10, "CTRUSA.ICO");
            this.ImageList1.Images.SetKeyName(11, "FLGASTRL.ICO");
            this.ImageList1.Images.SetKeyName(12, "FLGAUSTA.ICO");
            this.ImageList1.Images.SetKeyName(13, "FLGBELG.ICO");
            this.ImageList1.Images.SetKeyName(14, "FLGBRAZL.ICO");
            this.ImageList1.Images.SetKeyName(15, "FLGCAN.ICO");
            this.ImageList1.Images.SetKeyName(16, "FLGDEN.ICO");
            this.ImageList1.Images.SetKeyName(17, "FLGFIN.ICO");
            this.ImageList1.Images.SetKeyName(18, "FLGFRAN.ICO");
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1137, 610);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCustomers";
            this.Text = "FrmCustomers";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem orderByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerIDAscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerIDDescToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 無ToolStripMenuItem;
        internal System.Windows.Forms.ImageList ImageList2;
        internal System.Windows.Forms.ImageList ImageList1;
    }
}