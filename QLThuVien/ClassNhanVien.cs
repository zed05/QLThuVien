using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassNhanVien
    {
        ClassConnection db;

        public ClassNhanVien()
        {
            db = new ClassConnection();
        }

        public void loadAllData(NhanVienFrm f)
        {
            var data = db.database().NHANVIEN_PROC().ToList();
            f.nhanVienGridControl.DataSource = data;

            f.nhanVienGridView.Columns[5].Visible = false;
        }

        public void setNull(NhanVienFrm f)
        {
            f.maNVTxt.Text = "";
            f.tenNVTxt.Text = "";
            f.ngaySinhDT.EditValue = DateTime.Now;
            f.diaChiTxt.Text = "";
            f.dienThoaiTxt.Text = "";
            f.chucVuCb.DisplayMember = "Nhân viên";
        }

        public void setButton(NhanVienFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
            f.inBtn.Enabled = val;
        }

        public void enableObject(NhanVienFrm f, bool val)
        {
            f.maNVTxt.Enabled = false;
            f.tenNVTxt.Enabled = val;
            f.ngaySinhDT.Enabled = val;
            f.diaChiTxt.Enabled = val;
            f.dienThoaiTxt.Enabled = val;
            f.chucVuCb.Enabled = val;
            if(f.chucVuCb.Enabled == true)
            {
                f.chucVuCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }
        }

        public void loadChucVuData(NhanVienFrm f)
        {
            var data = db.database().CHUCVUs.ToList();
            f.chucVuCb.DataSource = data;
            f.chucVuCb.DisplayMember = "TenCV";
            f.chucVuCb.ValueMember = "MaCV";
        }

        public void loadRowSelected(NhanVienFrm f)
        {
            int currentCell = f.nhanVienGridView.FocusedRowHandle;
            f.maNVTxt.Text = f.nhanVienGridView.GetRowCellValue(currentCell, "MaNhanVien").ToString();
            f.tenNVTxt.Text = f.nhanVienGridView.GetRowCellValue(currentCell, "HoTenNhanVien").ToString();
            f.ngaySinhDT.Text = f.nhanVienGridView.GetRowCellValue(currentCell, "NgaySinh").ToString();
            f.diaChiTxt.Text = f.nhanVienGridView.GetRowCellValue(currentCell, "DiaChi").ToString();
            f.dienThoaiTxt.Text = f.nhanVienGridView.GetRowCellValue(currentCell, "DienThoai").ToString();
            f.chucVuCb.Text = f.nhanVienGridView.GetRowCellValue(currentCell, "TenCV").ToString();
        }

        public void add(NhanVienFrm f)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MaNhanVien = int.Parse(f.maNVTxt.Text);
            nv.HoTenNhanVien = f.tenNVTxt.Text;
            nv.NgaySinh = Convert.ToDateTime(f.ngaySinhDT.Text);
            nv.DiaChi = f.diaChiTxt.Text;
            nv.DienThoai = f.dienThoaiTxt.Text;
            nv.MaCV = int.Parse(f.chucVuCb.SelectedValue.ToString());

            db.database().NHANVIENs.InsertOnSubmit(nv);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(NhanVienFrm f)
        {
            var nv = db.database().NHANVIENs.SingleOrDefault(a => a.MaNhanVien == int.Parse(f.maNVTxt.Text));
            nv.MaNhanVien = int.Parse(f.maNVTxt.Text);
            nv.HoTenNhanVien = f.tenNVTxt.Text;
            nv.NgaySinh = Convert.ToDateTime(f.ngaySinhDT.Text);
            nv.DiaChi = f.diaChiTxt.Text;
            nv.DienThoai = f.dienThoaiTxt.Text;
            nv.MaCV = int.Parse(f.chucVuCb.SelectedValue.ToString());

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(NhanVienFrm f)
        {
            var nv = db.database().NHANVIENs.SingleOrDefault(a => a.MaNhanVien == int.Parse(f.maNVTxt.Text));

            db.database().NHANVIENs.DeleteOnSubmit(nv);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
