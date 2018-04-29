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
    public partial class ChucVuFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassChucVu cv;

        bool addBtn = false;

        public string loginName;

        public ChucVuFrm(string id)
        {
            InitializeComponent();
            cv = new ClassChucVu();
            cv.loadAllData(this);
            cv.loadRowSelected(this);
            cv.setButton(this, true);
            cv.enableObject(this, false);

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

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            cv.setNull(this);
            cv.setButton(this, false);
            cv.enableObject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            cv.setButton(this, false);
            cv.enableObject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa chức vụ \"" + tenChucVuTxt.Text + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                cv.delete(this);
                cv.loadAllData(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                cv.add(this);
            }
            else
            {
                cv.edit(this);
            }

            cv.loadRowSelected(this);
            cv.setButton(this, true);
            cv.enableObject(this, false);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            cv.loadRowSelected(this);
            cv.setButton(this, true);
            cv.enableObject(this, false);
        }

        private void chucVuGridView_Click(object sender, EventArgs e)
        {
            cv.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                cv.loadRowSelected(this);
                cv.setButton(this, true);
                cv.enableObject(this, false);
            }
        }

        private void thongTinDangNhapFrmBtn_Click(object sender, EventArgs e)
        {
            ThongTinDangNhapFrm f = new ThongTinDangNhapFrm(loginName);
            f.Show();
            this.Close();
        }

        private void exitFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chucVuGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                cv.loadRowSelected(this);
                if (addBtn)
                {
                    addBtn = false;
                    cv.enableObject(this, false);
                    cv.setButton(this, true);
                    cv.loadRowSelected(this);
                }
            }
        }
    }
}