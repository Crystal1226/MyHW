
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
            System.Windows.Forms.Label cityIDLabel;
            System.Windows.Forms.Label cityNameLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label introductionLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cityTableAdapter1 = new MyHW.MyAlbumDataSetTableAdapters.CityTableAdapter();
            this.photoTableAdapter1 = new MyHW.MyAlbumDataSetTableAdapters.PhotoTableAdapter();
            this.myAlbumDataSet1 = new MyHW.MyAlbumDataSet();
            this.panelCity = new System.Windows.Forms.Panel();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager();
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityIDTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.introductionTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridView = new System.Windows.Forms.DataGridView();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            cityIDLabel = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            introductionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityIDLabel
            // 
            cityIDLabel.AutoSize = true;
            cityIDLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityIDLabel.Location = new System.Drawing.Point(234, 121);
            cityIDLabel.Name = "cityIDLabel";
            cityIDLabel.Size = new System.Drawing.Size(63, 15);
            cityIDLabel.TabIndex = 6;
            cityIDLabel.Text = "City ID:";
            // 
            // cityNameLabel
            // 
            cityNameLabel.AutoSize = true;
            cityNameLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityNameLabel.Location = new System.Drawing.Point(234, 149);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(77, 15);
            cityNameLabel.TabIndex = 8;
            cityNameLabel.Text = "City Name:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(234, 177);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(63, 15);
            countryLabel.TabIndex = 10;
            countryLabel.Text = "Country:";
            // 
            // introductionLabel
            // 
            introductionLabel.AutoSize = true;
            introductionLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            introductionLabel.Location = new System.Drawing.Point(234, 205);
            introductionLabel.Name = "introductionLabel";
            introductionLabel.Size = new System.Drawing.Size(98, 15);
            introductionLabel.TabIndex = 12;
            introductionLabel.Text = "Introduction:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            photoLabel.Location = new System.Drawing.Point(522, 122);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(49, 15);
            photoLabel.TabIndex = 13;
            photoLabel.Text = "Photo:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(840, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tool CRUD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(133, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Album";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityTableAdapter1
            // 
            this.cityTableAdapter1.ClearBeforeFill = true;
            // 
            // photoTableAdapter1
            // 
            this.photoTableAdapter1.ClearBeforeFill = true;
            // 
            // myAlbumDataSet1
            // 
            this.myAlbumDataSet1.DataSetName = "MyAlbumDataSet";
            this.myAlbumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelCity
            // 
            this.panelCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCity.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panelCity.Location = new System.Drawing.Point(64, 96);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(128, 303);
            this.panelCity.TabIndex = 6;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.myAlbumDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter1;
            this.tableAdapterManager.PhotoTableAdapter = this.photoTableAdapter1;
            this.tableAdapterManager.UpdateOrder = MyHW.MyAlbumDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataMember = "Photo";
            this.photoBindingSource.DataSource = this.myAlbumDataSet1;
            // 
            // cityIDTextBox
            // 
            this.cityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityID", true));
            this.cityIDTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityIDTextBox.Location = new System.Drawing.Point(337, 118);
            this.cityIDTextBox.Name = "cityIDTextBox";
            this.cityIDTextBox.Size = new System.Drawing.Size(166, 23);
            this.cityIDTextBox.TabIndex = 7;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityName", true));
            this.cityNameTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityNameTextBox.Location = new System.Drawing.Point(337, 146);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(166, 23);
            this.cityNameTextBox.TabIndex = 9;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Country", true));
            this.countryTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryTextBox.Location = new System.Drawing.Point(337, 174);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(166, 23);
            this.countryTextBox.TabIndex = 11;
            // 
            // introductionTextBox
            // 
            this.introductionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Introduction", true));
            this.introductionTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introductionTextBox.Location = new System.Drawing.Point(337, 202);
            this.introductionTextBox.Name = "introductionTextBox";
            this.introductionTextBox.Size = new System.Drawing.Size(166, 23);
            this.introductionTextBox.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn2.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // photoDataGridView
            // 
            this.photoDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.photoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.photoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn2});
            this.photoDataGridView.DataSource = this.photoBindingSource;
            this.photoDataGridView.Location = new System.Drawing.Point(237, 248);
            this.photoDataGridView.Name = "photoDataGridView";
            this.photoDataGridView.RowTemplate.Height = 24;
            this.photoDataGridView.Size = new System.Drawing.Size(316, 151);
            this.photoDataGridView.TabIndex = 13;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photoBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(586, 122);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(274, 253);
            this.photoPictureBox.TabIndex = 14;
            this.photoPictureBox.TabStop = false;
            // 
            // FrmMyAlbum_V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 465);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.photoDataGridView);
            this.Controls.Add(cityIDLabel);
            this.Controls.Add(this.cityIDTextBox);
            this.Controls.Add(cityNameLabel);
            this.Controls.Add(this.cityNameTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(introductionLabel);
            this.Controls.Add(this.introductionTextBox);
            this.Controls.Add(this.panelCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMyAlbum_V1";
            this.Text = "FrmMyAlbum_V1";
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private MyAlbumDataSetTableAdapters.CityTableAdapter cityTableAdapter1;
        private MyAlbumDataSetTableAdapters.PhotoTableAdapter photoTableAdapter1;
        private MyAlbumDataSet myAlbumDataSet1;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private MyAlbumDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.TextBox cityIDTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox introductionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView photoDataGridView;
        private System.Windows.Forms.PictureBox photoPictureBox;
    }
}