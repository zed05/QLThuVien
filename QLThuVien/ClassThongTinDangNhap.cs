using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassThongTinDangNhap
    {
        ClassConnection db;

        public ClassThongTinDangNhap()
        {
            db = new ClassConnection();
        }

        public void loadAllData(ThongTinDangNhapFrm f)
        {
            var data = db.database().LOGIN_PROC().ToList();
            f.thongTinDangNhapGridControl.DataSource = data;

            f.thongTinDangNhapGridView.Columns[0].Caption = "ID";
            f.thongTinDangNhapGridView.Columns[1].Caption = "Password";
            f.thongTinDangNhapGridView.Columns[2].Caption = "Ghi chú";
            f.thongTinDangNhapGridView.Columns[3].Visible = false;
            f.thongTinDangNhapGridView.Columns[4].Caption = "Tên nhân viên";
        }

        public void setNull(ThongTinDangNhapFrm f)
        {
            f.idTxt.Text = "";
            f.pwdTxt.Text = "";
            f.ghiChuTxt.Text = "";
        }

        public void setButton(ThongTinDangNhapFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
        }

        public void enableObject(ThongTinDangNhapFrm f, bool val)
        {
            f.idTxt.Enabled = val;
            f.pwdTxt.Enabled = val;
            f.ghiChuTxt.Enabled = val;
            f.tenNhanVienCb.Enabled = val;

            if (f.tenNhanVienCb.Enabled)
            {
                f.tenNhanVienCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }
        }

        public void loadRowSelected(ThongTinDangNhapFrm f)
        {
            int currentCell = f.thongTinDangNhapGridView.FocusedRowHandle;

            f.idTxt.Text = f.thongTinDangNhapGridView.GetRowCellValue(currentCell, "IDLOGIN").ToString();
            f.pwdTxt.Text = f.thongTinDangNhapGridView.GetRowCellValue(currentCell, "PWD").ToString();
            f.ghiChuTxt.Text = f.thongTinDangNhapGridView.GetRowCellValue(currentCell, "GhiChu").ToString();
            f.tenNhanVienCb.Text = f.thongTinDangNhapGridView.GetRowCellValue(currentCell, "HoTenNhanVien").ToString();
        }

        public void add(ThongTinDangNhapFrm f)
        {
            LOGIN dn = new LOGIN();
            dn.IDLOGIN = f.idTxt.Text;
            dn.PWD = f.pwdTxt.Text;
            dn.GhiChu = f.ghiChuTxt.Text;
            dn.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

            db.database().LOGINs.InsertOnSubmit(dn);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(ThongTinDangNhapFrm f)
        {
            var dn = db.database().LOGINs.SingleOrDefault(a => a.IDLOGIN == f.idTxt.Text);

            dn.IDLOGIN = f.idTxt.Text;
            dn.PWD = f.pwdTxt.Text;
            dn.GhiChu = f.ghiChuTxt.Text;
            dn.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(ThongTinDangNhapFrm f)
        {
            var dn = db.database().LOGINs.SingleOrDefault(a => a.IDLOGIN == f.idTxt.Text);
            db.database().LOGINs.DeleteOnSubmit(dn);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void loadNhanVienData(ThongTinDangNhapFrm f)
        {
            var data = db.database().NHANVIENs.ToList();
            f.tenNhanVienCb.DataSource = data;
            f.tenNhanVienCb.DisplayMember = "HoTenNhanVien";
            f.tenNhanVienCb.ValueMember = "MaNhanVien";
        }
    }
}
