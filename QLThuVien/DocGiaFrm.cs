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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class DocGiaFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassDocGia dg;

        bool addBtn = false;

        public string loginName;

        public DocGiaFrm(string id)
        {
            InitializeComponent();
            dg = new ClassDocGia();
            dg.loadAllData(this);

            dg.enableObject(this, false);
            dg.setButton(this, true);
            dg.loadRowSelected(this);

            loginName = id;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm(loginName);
            f.Show();
        }

        private void docGiaGridView_Click(object sender, EventArgs e)
        {
            dg.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                dg.enableObject(this, false);
                dg.setButton(this, true);
                dg.loadRowSelected(this);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            dg.setNull(this);
            dg.enableObject(this, true);
            dg.setButton(this, false);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            dg.enableObject(this, true);
            dg.setButton(this, false);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa đọc giả \"" + tenDocGiaTxt.Text + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                dg.delete(this);
                dg.loadRowSelected(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                dg.add(this);
            }
            else
            {
                dg.edit(this);
            }

            dg.enableObject(this, false);
            dg.setButton(this, true);
            dg.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            dg.enableObject(this, false);
            dg.setButton(this, true);
            dg.loadRowSelected(this);
        }

        private void phieuMuonSachFrmBtn_Click(object sender, EventArgs e)
        {
            PhieuMuonSachFrm f = new PhieuMuonSachFrm(loginName);
            f.Show();
            this.Close();
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void docGiaGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dg.loadRowSelected(this);
                if (addBtn)
                {
                    addBtn = false;
                    dg.enableObject(this, false);
                    dg.setButton(this, true);
                    dg.loadRowSelected(this);
                }
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            DocGiaReport rp = new DocGiaReport();
            rp.ShowPreview();
        }
    }
}