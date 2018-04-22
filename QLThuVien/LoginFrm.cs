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
    public partial class LoginFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassConnection db;
        public LoginFrm()
        {
            InitializeComponent();
            db = new ClassConnection();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //string id = emailLoginTxt.Text.Trim();
            //string pwd = passLoginTxt.Text.Trim();

            string id = "Admin";
            string pwd = "1";

            var data = db.database().LOGINs.SingleOrDefault(a => a.IDLOGIN.Trim() == id && a.PWD.Trim() == pwd);

            if(data == null)
            {
                MessageBox.Show("Sai Email / Mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainFrm f = new MainFrm();
                f.Show();
                this.Hide();
            }
        }
    }
}