using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassPhieuThuTien
    {
        ClassConnection db;

        public ClassPhieuThuTien()
        {
            db = new ClassConnection();
        }

        public void loadAllData(PhieuThuTienFrm f)
        {
            var data = db.database().PHIEUTHU_PROC().ToList();
            f.phieuThuTienGridControl.DataSource = data;
        }

        public void loadDocGiaData(PhieuThuTienFrm f)
        {
            var data = db.database().DOCGIA_PROC().ToList();
            f.tenDocGiaCb.DataSource = data;
            f.tenDocGiaCb.DisplayMember = "HoTenDocGia";
            f.tenDocGiaCb.ValueMember = "MaDocGia";
        }

        public void loadNhanVienData(PhieuThuTienFrm f)
        {
            var data = db.database().NHANVIEN_PROC().ToList();
            f.tenNhanVienCb.DataSource = data;
            f.tenNhanVienCb.DisplayMember = "HoTenNhanVien";
            f.tenNhanVienCb.ValueMember = "MaNhanVien";
        }

        public void setNull(PhieuThuTienFrm f)
        {
            f.maPhieuThuTienTxt.Text = "";
            f.soTienNoTxt.Text = "";
            f.soTienThuTxt.Text = "";
            f.tenDocGiaCb.Text = "";
            f.tenNhanVienCb.Text = "";
        }

        public void setButton(PhieuThuTienFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
            f.inBtn.Enabled = val;
        }

        public void enableObject(PhieuThuTienFrm f, bool val)
        {
            f.maPhieuThuTienTxt.Enabled = false;
            f.soTienNoTxt.Enabled = val;
            f.soTienThuTxt.Enabled = val;
            f.tenDocGiaCb.Enabled = val;
            f.tenNhanVienCb.Enabled = val;

            if(f.tenNhanVienCb.Enabled == true && f.tenDocGiaCb.Enabled == true)
            {
                f.tenDocGiaCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
                f.tenNhanVienCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }
        }

        public void loadRowSelected(PhieuThuTienFrm f)
        {
            int currentCell = f.phieuThuTienGridView.FocusedRowHandle;

            f.maPhieuThuTienTxt.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "MaPhieuThuTien").ToString();
            f.soTienNoTxt.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "SoTienNo").ToString();
            f.soTienThuTxt.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "SoTienThu").ToString();
            f.tenDocGiaCb.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "HoTenDocGia").ToString();
            f.tenNhanVienCb.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "HoTenNhanVien").ToString();
        }

        public void add(PhieuThuTienFrm f)
        {
            PHIEUTHUTIEN pt = new PHIEUTHUTIEN();
            pt.SoTienNo = float.Parse(f.soTienNoTxt.Text);
            pt.SoTienThu = float.Parse(f.soTienThuTxt.Text);
            pt.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            pt.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

            db.database().PHIEUTHUTIENs.InsertOnSubmit(pt);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(PhieuThuTienFrm f)
        {
            var pt = db.database().PHIEUTHUTIENs.SingleOrDefault(a => a.MaPhieuThuTien == int.Parse(f.maPhieuThuTienTxt.Text));
            pt.MaPhieuThuTien = int.Parse(f.maPhieuThuTienTxt.Text);
            pt.SoTienNo = float.Parse(f.soTienNoTxt.Text);
            pt.SoTienThu = float.Parse(f.soTienThuTxt.Text);
            pt.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            pt.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(PhieuThuTienFrm f)
        {
            var pt = db.database().PHIEUTHUTIENs.SingleOrDefault(a => a.MaPhieuThuTien == int.Parse(f.maPhieuThuTienTxt.Text));
            db.database().PHIEUTHUTIENs.DeleteOnSubmit(pt);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
