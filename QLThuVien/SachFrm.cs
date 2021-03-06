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
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class SachFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassSach s;

        bool addBtn = false;

        public string loginName;

        public SachFrm(string id)
        {
            InitializeComponent();
            s = new ClassSach();
            s.loadAllData(this);
            s.setButton(this, true);
            s.enableObject(this, false);
            s.loadRowSelected(this);
            s.loadLoaiData(this);

            loginName = id;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm(loginName);
            f.Show();
        }

        private void sachGridView_Click(object sender, EventArgs e)
        {
            s.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                s.setButton(this, true);
                s.enableObject(this, false);
                s.loadRowSelected(this);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            s.setNull(this);
            s.setButton(this, false);
            s.enableObject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            s.setButton(this, false);
            s.enableObject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa cuốn \"" + s.masach.ToString() + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                s.delete(this);
                s.loadRowSelected(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                s.add(this);
            }
            else
            {
                s.edit(this);
            }

            s.setButton(this, true);
            s.enableObject(this, false);
            s.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            s.setButton(this, true);
            s.enableObject(this, false);
            s.loadRowSelected(this);
        }

        private void loaiSachFrmBtn_Click(object sender, EventArgs e)
        {
            LoaiSachFrm f = new LoaiSachFrm(loginName);
            f.Show();
            this.Close();
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sachGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                s.loadRowSelected(this);
                if (addBtn)
                {
                    addBtn = false;
                    s.enableObject(this, false);
                    s.setButton(this, true);
                    s.loadRowSelected(this);
                }
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            SachReport rp = new SachReport();
            rp.ShowPreview();
        }
    }
}