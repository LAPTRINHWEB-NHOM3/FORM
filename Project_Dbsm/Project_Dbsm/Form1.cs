﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Dbsm
{
    public partial class DangKyVaQuanLy : Form
    {
        public DangKyVaQuanLy()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDKKhaiSinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new Form2();
            form.MdiParent = this;
            form.Show();
        }

        private void btnDKKetHon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new ToKhaiKetHon();
            form.MdiParent = this;
            form.Show();
        }
    }
}
