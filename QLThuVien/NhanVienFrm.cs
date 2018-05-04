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
using QLThuVien.LinQ;
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class NhanVienFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassNhanVien nv;

        bool addBtn = false;

        public string loginName;

        public NhanVienFrm(string id)
        {
            InitializeComponent();
            nv = new ClassNhanVien();
            nv.loadAllData(this);
            nv.setButton(this, true);
            nv.enableObject(this, false);
            nv.loadChucVuData(this);
            nv.loadRowSelected(this);

            loginName = id;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm(loginName);
            f.Show();
        }

        private void nhanVienGridView_Click(object sender, EventArgs e)
        {
            nv.loadRowSelected(this);
            if (addBtn == true)
            {
                addBtn = false;
                nv.setButton(this, true);
                nv.enableObject(this, false);
                nv.loadRowSelected(this);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            nv.setNull(this);
            nv.setButton(this, false);
            nv.enableObject(this, true);
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn == true)
            {
                nv.add(this);
            }
            else
            {
                nv.edit(this);
            }
            nv.loadRowSelected(this);
            nv.setButton(this, true);
            nv.enableObject(this, false);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            nv.loadRowSelected(this);
            nv.setButton(this, true);
            nv.enableObject(this, false);
            nv.loadRowSelected(this);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa nhân viên \"" + tenNVTxt.Text + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                nv.delete(this);
                nv.loadRowSelected(this);
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            nv.setButton(this, false);
            nv.enableObject(this, true);
        }

        private void chucVuFrmBtn_Click(object sender, EventArgs e)
        {
            ChucVuFrm f = new ChucVuFrm(loginName);
            f.Show();
            this.Close();
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

        private void nhanVienGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                nv.loadRowSelected(this);
                if (addBtn)
                {
                    addBtn = false;
                    nv.enableObject(this, false);
                    nv.setButton(this, true);
                    nv.loadRowSelected(this);
                }
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            NhanVienReport rp = new NhanVienReport();
            rp.ShowPreview();
        }
    }
}