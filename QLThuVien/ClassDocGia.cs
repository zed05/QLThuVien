using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.LinQ;

namespace QLThuVien
{
    class ClassDocGia
    {
        ClassConnection db;

        string madg;

        public ClassDocGia()
        {
            db = new ClassConnection();
        }

       public void loadAllData(DocGiaFrm f)
        {
            var data = db.database().DOCGIA_PROC().ToList();
            f.docGiaGridControl.DataSource = data;

            f.docGiaGridView.Columns[0].Caption = "Mã đọc giả";
            f.docGiaGridView.Columns[1].Caption = "Tên đọc giả";
            f.docGiaGridView.Columns[2].Caption = "Ngày sinh";
            f.docGiaGridView.Columns[3].Caption = "Địa chỉ";
            f.docGiaGridView.Columns[4].Caption = "Email";
            f.docGiaGridView.Columns[5].Caption = "Ngày lập thẻ";
            f.docGiaGridView.Columns[6].Caption = "Ngày hết hạn";
        }

        public void setNull(DocGiaFrm f)
        {
            f.tenDocGiaTxt.Text = "";
            f.ngaySinhDT.EditValue = DateTime.Now;
            f.diaChiTxt.Text = "";
            f.emailTxt.Text = "";
            f.ngayLapTheDT.EditValue = DateTime.Now;
            f.ngayHetHanDT.EditValue = DateTime.Now;
        }

        public void setButton(DocGiaFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
            f.inBtn.Enabled = val;
        }

        public void enableObject(DocGiaFrm f, bool val)
        {
            f.tenDocGiaTxt.Enabled = val;
            f.ngaySinhDT.Enabled = val;
            f.diaChiTxt.Enabled = val;
            f.emailTxt.Enabled = val;
            f.ngayLapTheDT.Enabled = val;
            f.ngayHetHanDT.Enabled = val;
        }

        public void loadRowSelected(DocGiaFrm f)
        {
            int currentCell = f.docGiaGridView.FocusedRowHandle;

            madg = f.docGiaGridView.GetRowCellValue(currentCell, "MaDocGia").ToString();
            f.tenDocGiaTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "HoTenDocGia").ToString();
            f.ngaySinhDT.Text = f.docGiaGridView.GetRowCellValue(currentCell, "NgaySinh").ToString();
            f.diaChiTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "DiaChi").ToString();
            f.emailTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "Email").ToString();
            f.ngayLapTheDT.Text = f.docGiaGridView.GetRowCellValue(currentCell, "NgayLapThe").ToString();
            f.ngayHetHanDT.Text = f.docGiaGridView.GetRowCellValue(currentCell, "NgayHetHan").ToString();
        }

        public void add(DocGiaFrm f)
        {
            DOCGIA dg = new DOCGIA();
            PHIEUMUONSACH pm = new PHIEUMUONSACH();

            if(f.emailTxt.Text == "" || f.tenDocGiaTxt.Text == "")
            {
                MessageBox.Show("Tên và Email không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dg.HoTenDocGia = f.tenDocGiaTxt.Text;
                dg.NgaySinh = Convert.ToDateTime(f.ngaySinhDT.Text);
                dg.DiaChi = f.diaChiTxt.Text;
                dg.Email = f.emailTxt.Text;
                dg.NgayLapThe = Convert.ToDateTime(f.ngayLapTheDT.Text);
                dg.NgayHetHan = Convert.ToDateTime(f.ngayHetHanDT.Text);

                db.database().DOCGIAs.InsertOnSubmit(dg);
                db.database().SubmitChanges();

                pm.TinhTrangThanhToan = "Chưa thanh toán";
                pm.MaDocGia = db.database().LAST_DOCGIA_FUNC().Value;
                pm.MaNhanVien = 1;
                pm.NgayMuon = DateTime.Now;
                pm.MaSach = 1;

                db.database().PHIEUMUONSACHes.InsertOnSubmit(pm);
                db.database().SubmitChanges();
                loadAllData(f);
            }
        }

        public void edit(DocGiaFrm f)
        {
            if (f.emailTxt.Text == "" || f.tenDocGiaTxt.Text == "")
            {
                MessageBox.Show("Tên và Email không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var dg = db.database().DOCGIAs.SingleOrDefault(a => a.MaDocGia == int.Parse(madg));

                dg.HoTenDocGia = f.tenDocGiaTxt.Text;
                dg.NgaySinh = Convert.ToDateTime(f.ngaySinhDT.Text);
                dg.DiaChi = f.diaChiTxt.Text;
                dg.Email = f.emailTxt.Text;
                dg.NgayLapThe = Convert.ToDateTime(f.ngayLapTheDT.Text);
                dg.NgayHetHan = Convert.ToDateTime(f.ngayHetHanDT.Text);

                db.database().SubmitChanges();
                loadAllData(f);
            }
        } 

        public void delete(DocGiaFrm f)
        {
            var dg = db.database().DOCGIAs.SingleOrDefault(a => a.MaDocGia == int.Parse(madg));
            db.database().DOCGIAs.DeleteOnSubmit(dg);

            var pm = db.database().PHIEUMUONSACHes.SingleOrDefault(a => a.MaDocGia == int.Parse(madg));
            db.database().PHIEUMUONSACHes.DeleteOnSubmit(pm);
            db.database().SubmitChanges();
            
            loadAllData(f);
        }
    }
}
