using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassMainFrm
    {
        ClassConnection db;
        public ClassMainFrm()
        {
            db = new ClassConnection();
        }

        public void checkPermission(MainFrm f)
        {
            var data = db.database().LOGINs.SingleOrDefault(a => a.IDLOGIN == f.userNameLabel.Text);
            var data2 = db.database().NHANVIENs.SingleOrDefault(a => a.MaNhanVien == data.MaNhanVien);
           if(data2.MaCV == 1)
            {
                f.nhanVienFrmBtn.Enabled = true;
                f.chucVuFrmBtn.Enabled = true;
                f.thongTinDangNhapFrmBtn.Enabled = true;
            }
            else
            {
                f.nhanVienFrmBtn.Enabled = false;
                f.chucVuFrmBtn.Enabled = false;
                f.thongTinDangNhapFrmBtn.Enabled = false;
            }
        }
    }
}
