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

namespace QLThuVien
{
    public partial class NhanVienFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassNhanVien nv;

        bool addBtn = false;

        public NhanVienFrm()
        {
            InitializeComponent();
            nv = new ClassNhanVien();
            nv.loadAllData(this);
            nv.setButton(this, true);
            nv.enableObject(this, false);
            nv.loadChucVuData(this);
            nv.loadRowSelected(this);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm();
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
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            nv.setButton(this, false);
            nv.enableObject(this, true);
        }

        private void DocGiaFrmBtn_Click(object sender, EventArgs e)
        {
            DocGiaFrm f = new DocGiaFrm();
            f.Show();
            this.Hide();
        }
    }
}