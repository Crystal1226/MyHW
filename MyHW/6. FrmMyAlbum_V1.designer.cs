
namespace MyHW
{
    partial class FrmMyAlbum_V1
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
            System.Windows.Forms.Label introductionLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityNameLabel;
            System.Windows.Forms.Label cityIDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label photoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAlbum_V1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntro = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtCityID = new System.Windows.Forms.TextBox();
            this.photoDataGridView = new System.Windows.Forms.DataGridView();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.panelCity = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myAlbumDataSet1 = new MyHW.MyAlbumDataSet();
            this.cityTableAdapter1 = new MyHW.MyAlbumDataSetTableAdapters.CityTableAdapter();
            this.photoTableAdapter1 = new MyHW.MyAlbumDataSetTableAdapters.PhotoTableAdapter();
            this.tableAdapterManager = new MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager();
            introductionLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            cityIDLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Consolas", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(1119, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tool CRUD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(915, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Album";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIntro
            // 
            this.txtIntro.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtIntro.Location = new System.Drawing.Point(506, 277);
            this.txtIntro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(247, 30);
            this.txtIntro.TabIndex = 13;
            // 
            // introductionLabel
            // 
            introductionLabel.AutoSize = true;
            introductionLabel.BackColor = System.Drawing.Color.Transparent;
            introductionLabel.Font = new System.Drawing.Font("Consolas", 9.75F);
            introductionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            introductionLabel.Location = new System.Drawing.Point(351, 282);
            introductionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            introductionLabel.Name = "introductionLabel";
            introductionLabel.Size = new System.Drawing.Size(153, 23);
            introductionLabel.TabIndex = 12;
            introductionLabel.Text = "Introduction:";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtCountry.Location = new System.Drawing.Point(506, 235);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(247, 30);
            this.txtCountry.TabIndex = 11;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.BackColor = System.Drawing.Color.Transparent;
            countryLabel.Font = new System.Drawing.Font("Consolas", 9.75F);
            countryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            countryLabel.Location = new System.Drawing.Point(351, 240);
            countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(98, 23);
            countryLabel.TabIndex = 10;
            countryLabel.Text = "Country:";
            // 
            // txtCityName
            // 
            this.txtCityName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtCityName.Location = new System.Drawing.Point(506, 193);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(247, 30);
            this.txtCityName.TabIndex = 9;
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.BackColor = System.Drawing.Color.Transparent;
            cityNameLabel.Font = new System.Drawing.Font("Consolas", 9.75F);
            cityNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cityNameLabel.Location = new System.Drawing.Point(351, 198);
            cityNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(120, 23);
            cityNameLabel.TabIndex = 8;
            cityNameLabel.Text = "City Name:";
            // 
            // txtCityID
            // 
            this.txtCityID.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtCityID.Location = new System.Drawing.Point(506, 151);
            this.txtCityID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCityID.Name = "txtCityID";
            this.txtCityID.Size = new System.Drawing.Size(247, 30);
            this.txtCityID.TabIndex = 7;
            // 
            // cityIDLabel
            // 
            cityIDLabel.AutoSize = true;
            cityIDLabel.BackColor = System.Drawing.Color.Transparent;
            cityIDLabel.Font = new System.Drawing.Font("Consolas", 9.75F);
            cityIDLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            cityIDLabel.Location = new System.Drawing.Point(351, 156);
            cityIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cityIDLabel.Name = "cityIDLabel";
            cityIDLabel.Size = new System.Drawing.Size(98, 23);
            cityIDLabel.TabIndex = 6;
            cityIDLabel.Text = "City ID:";
            // 
            // photoDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.photoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.photoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.photoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.photoDataGridView.Location = new System.Drawing.Point(334, 330);
            this.photoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.photoDataGridView.Name = "photoDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.photoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.photoDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.photoDataGridView.RowTemplate.Height = 24;
            this.photoDataGridView.Size = new System.Drawing.Size(474, 268);
            this.photoDataGridView.TabIndex = 13;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.photoPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.photoPictureBox.Location = new System.Drawing.Point(840, 198);
            this.photoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(415, 317);
            this.photoPictureBox.TabIndex = 14;
            this.photoPictureBox.TabStop = false;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.BackColor = System.Drawing.Color.Transparent;
            photoLabel.Font = new System.Drawing.Font("Consolas", 9.75F);
            photoLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            photoLabel.Location = new System.Drawing.Point(836, 167);
            photoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(76, 23);
            photoLabel.TabIndex = 13;
            photoLabel.Text = "Photo:";
            // 
            // panelCity
            // 
            this.panelCity.BackColor = System.Drawing.Color.Transparent;
            this.panelCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCity.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCity.Location = new System.Drawing.Point(96, 144);
            this.panelCity.Margin = new System.Windows.Forms.Padding(4);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(191, 454);
            this.panelCity.TabIndex = 6;
            // 
            // myAlbumDataSet1
            // 
            this.myAlbumDataSet1.DataSetName = "MyAlbumDataSet";
            this.myAlbumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // photoTableAdapter1
            // 
            this.photoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter1;
            this.tableAdapterManager.PhotoTableAdapter = this.photoTableAdapter1;
            this.tableAdapterManager.UpdateOrder = MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmMyAlbum_V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1379, 684);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.photoDataGridView);
            this.Controls.Add(cityIDLabel);
            this.Controls.Add(this.txtCityID);
            this.Controls.Add(cityNameLabel);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(introductionLabel);
            this.Controls.Add(this.txtIntro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelCity);
            this.Name = "FrmMyAlbum_V1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FrmMyAlbum_V1";
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private MyAlbumDataSetTableAdapters.CityTableAdapter cityTableAdapter1;
        private MyAlbumDataSetTableAdapters.PhotoTableAdapter photoTableAdapter1;
        private MyAlbumDataSet myAlbumDataSet1;
        private MyAlbumDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtIntro;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtCityID;
        private System.Windows.Forms.DataGridView photoDataGridView;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}