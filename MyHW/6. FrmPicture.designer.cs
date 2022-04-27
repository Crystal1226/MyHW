
namespace MyHW
{
    partial class FrmPicture
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.photo_V2TableAdapter1 = new MyHW.MyAlbumDataSetTableAdapters.Photo_V2TableAdapter();
            this.myAlbumDataSet1 = new MyHW.MyAlbumDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // photo_V2TableAdapter1
            // 
            this.photo_V2TableAdapter1.ClearBeforeFill = true;
            // 
            // myAlbumDataSet1
            // 
            this.myAlbumDataSet1.DataSetName = "MyAlbumDataSet";
            this.myAlbumDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 380);
            this.Name = "FrmPicture";
            this.Text = "FrmPicture";
            ((System.ComponentModel.ISupportInitialize)(this.myAlbumDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MyAlbumDataSetTableAdapters.Photo_V2TableAdapter photo_V2TableAdapter1;
        private MyAlbumDataSet myAlbumDataSet1;
    }
}