﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmPicture : Form
    {
        public FrmPicture()
        {
            InitializeComponent();
            photo_V2TableAdapter1.Fill(myAlbumDataSet1.Photo_V2);
            
        }

    }
}
