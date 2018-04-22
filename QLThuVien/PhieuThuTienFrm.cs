﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLThuVien
{
    public partial class PhieuThuTienFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassPhieuThuTien pt;

        bool addBtn = false;

        public PhieuThuTienFrm()
        {
            InitializeComponent();
            pt = new ClassPhieuThuTien();
            pt.loadAllData(this);
            pt.loadDocGiaData(this);
            pt.loadNhanVienData(this);
            pt.setButton(this, true);
            pt.enableObject(this, false);
            pt.loadRowSelected(this);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm();
            f.Show();
        }

        private void phieuThuTienGridView_Click(object sender, EventArgs e)
        {
            pt.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                pt.setButton(this, true);
                pt.enableObject(this, false);
                pt.loadRowSelected(this);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            pt.setNull(this);
            pt.setButton(this, false);
            pt.enableObject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            pt.setButton(this, false);
            pt.enableObject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa phiếu thu số \"" + maPhieuThuTienTxt.Text + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                pt.delete(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                pt.add(this);
            }
            else
            {
                pt.edit(this);
            }

            pt.setButton(this, true);
            pt.enableObject(this, false);
            pt.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            pt.setButton(this, true);
            pt.enableObject(this, false);
            pt.loadRowSelected(this);
        }

        private void tenDocGiaCb_MouseClick(object sender, MouseEventArgs e)
        {
            pt.loadDocGiaData(this);
        }

        private void tenNhanVienCb_MouseClick(object sender, MouseEventArgs e)
        {
            pt.loadNhanVienData(this);
        }
    }
}