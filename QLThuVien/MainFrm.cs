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
    public partial class MainFrm : DevExpress.XtraEditors.XtraForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void docGiaFrmBtn_Click(object sender, EventArgs e)
        {
            DocGiaFrm f = new DocGiaFrm();
            f.Show();
            this.Hide();
        }

        private void sachFrmBtn_Click(object sender, EventArgs e)
        {
            SachFrm f = new SachFrm();
            f.Show();
            this.Hide();
        }

        private void nhanVienFrmBtn_Click(object sender, EventArgs e)
        {
            NhanVienFrm f = new NhanVienFrm();
            f.Show();
            this.Hide();
        }

        private void loaiSachFrmBtn_Click(object sender, EventArgs e)
        {
            LoaiSachFrm f = new LoaiSachFrm();
            f.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginFrm f = new LoginFrm();
            f.Show();
            this.Close();
        }

        private void phieuThuTienFrmBtn_Click(object sender, EventArgs e)
        {
            PhieuThuTienFrm f = new PhieuThuTienFrm();
            f.Show();
            this.Hide();
        }
    }
}