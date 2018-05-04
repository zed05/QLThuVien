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
        ClassMainFrm mainf;

        public string loginName;
        public MainFrm(string userID)
        {
            InitializeComponent();
            mainf = new ClassMainFrm();
            userNameLabel.Text = userID;
            loginName = userID;

            if(userNameLabel.Text != "")
            {
                mainf.checkPermission(this);
            }
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void docGiaFrmBtn_Click(object sender, EventArgs e)
        {
            DocGiaFrm f = new DocGiaFrm(loginName);
            f.Show();
            this.Hide();
        }

        private void sachFrmBtn_Click(object sender, EventArgs e)
        {
            SachFrm f = new SachFrm(loginName);
            f.Show();
            this.Hide();
        }

        private void nhanVienFrmBtn_Click(object sender, EventArgs e)
        {
            NhanVienFrm f = new NhanVienFrm(loginName);
            f.Show();
            this.Hide();
        }

        private void loaiSachFrmBtn_Click(object sender, EventArgs e)
        {
            LoaiSachFrm f = new LoaiSachFrm(loginName);
            f.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginFrm f = new LoginFrm();
            f.Show();
            this.Close();
        }

        private void phieuMuonSachFrmBtn_Click(object sender, EventArgs e)
        {
            PhieuMuonSachFrm f = new PhieuMuonSachFrm(loginName);
            f.Show();
            this.Hide();
        }

        private void chucVuFrmBtn_Click(object sender, EventArgs e)
        {
            ChucVuFrm f = new ChucVuFrm(loginName);
            f.Show();
            this.Hide();
        }

        private void thongTinDangNhapFrmBtn_Click(object sender, EventArgs e)
        {
            ThongTinDangNhapFrm f = new ThongTinDangNhapFrm(loginName);
            f.Show();
            this.Hide();
        }
    }
}