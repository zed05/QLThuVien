using System;
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
    public partial class ThongTinDangNhapFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassThongTinDangNhap dn;

        bool addBtn = false;

        public string loginName;

        public ThongTinDangNhapFrm(string id)
        {
            InitializeComponent();
            dn = new ClassThongTinDangNhap();
            dn.loadAllData(this);
            dn.setButton(this, true);
            dn.enableObject(this, false);
            dn.loadRowSelected(this);
            dn.loadNhanVienData(this);

            loginName = id;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            MainFrm f = new MainFrm(loginName);
            f.Show();
            this.Close();
        }

        private void nhanVienFrmBtn_Click(object sender, EventArgs e)
        {
            NhanVienFrm f = new NhanVienFrm(loginName);
            f.Show();
            this.Close();
        }

        private void chucVuFrmBtn_Click(object sender, EventArgs e)
        {
            ChucVuFrm f = new ChucVuFrm(loginName);
            f.Show();
            this.Close();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            dn.setNull(this);
            dn.setButton(this, false);
            dn.enableObject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            dn.setButton(this, false);
            dn.enableObject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa ID \"" + idTxt.Text + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                dn.delete(this);
                dn.loadRowSelected(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                dn.add(this);
            }
            else
            {
                dn.edit(this);
            }

            dn.setButton(this, true);
            dn.enableObject(this, false);
            dn.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            dn.setButton(this, true);
            dn.enableObject(this, false);
            dn.loadRowSelected(this);
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thongTinDangNhapGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dn.loadRowSelected(this);
                if (addBtn)
                {
                    addBtn = false;
                    dn.enableObject(this, false);
                    dn.setButton(this, true);
                    dn.loadRowSelected(this);
                }
            }
        }

        private void thongTinDangNhapGridView_Click(object sender, EventArgs e)
        {
            dn.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                dn.setButton(this, true);
                dn.enableObject(this, false);
                dn.loadRowSelected(this);
            }
        }
    }
}