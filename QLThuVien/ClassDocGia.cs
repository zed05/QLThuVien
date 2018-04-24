using System;
using System.Collections.Generic;
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

        public ClassDocGia()
        {
            db = new ClassConnection();
        }

       public void loadAllData(DocGiaFrm f)
        {
            var data = db.database().DOCGIA_PROC().ToList();
            f.docGiaGridControl.DataSource = data;

            f.docGiaGridView.Columns[8].Visible = false;
            f.docGiaGridView.Columns[9].Visible = false;
        }

        public void setNull(DocGiaFrm f)
        {
            f.maDocGiaTxt.Text = "";
            f.tenDocGiaTxt.Text = "";
            f.ngaySinhDT.EditValue = DateTime.Now;
            f.diaChiTxt.Text = "";
            f.emailTxt.Text = "";
            f.ngayLapTheDT.EditValue = DateTime.Now;
            f.ngayHetHanDT.EditValue = DateTime.Now;
            f.tienNoTxt.Text = "";
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
            f.maDocGiaTxt.Enabled = false;
            f.tenDocGiaTxt.Enabled = val;
            f.ngaySinhDT.Enabled = val;
            f.diaChiTxt.Enabled = val;
            f.emailTxt.Enabled = val;
            f.ngayLapTheDT.Enabled = val;
            f.ngayHetHanDT.Enabled = val;
            f.tienNoTxt.Enabled = val;
        }

        public void loadRowSelected(DocGiaFrm f)
        {
            int currentCell = f.docGiaGridView.FocusedRowHandle;

            f.maDocGiaTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "MaDocGia").ToString();
            f.tenDocGiaTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "HoTenDocGia").ToString();
            f.ngaySinhDT.Text = f.docGiaGridView.GetRowCellValue(currentCell, "NgaySinh").ToString();
            f.diaChiTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "DiaChi").ToString();
            f.emailTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "Email").ToString();
            f.ngayLapTheDT.Text = f.docGiaGridView.GetRowCellValue(currentCell, "NgayLapThe").ToString();
            f.ngayHetHanDT.Text = f.docGiaGridView.GetRowCellValue(currentCell, "NgayHetHan").ToString();
            f.tienNoTxt.Text = f.docGiaGridView.GetRowCellValue(currentCell, "TienNo").ToString();
        }

        public void add(DocGiaFrm f)
        {
            DOCGIA dg = new DOCGIA();
            dg.HoTenDocGia = f.tenDocGiaTxt.Text;
            dg.NgaySinh = Convert.ToDateTime(f.ngaySinhDT.Text);
            dg.DiaChi = f.diaChiTxt.Text;
            dg.Email = f.emailTxt.Text;
            dg.NgayLapThe = Convert.ToDateTime(f.ngayLapTheDT.Text);
            dg.NgayHetHan = Convert.ToDateTime(f.ngayHetHanDT.Text);
            dg.TienNo = float.Parse(f.tienNoTxt.Text);

            db.database().DOCGIAs.InsertOnSubmit(dg);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(DocGiaFrm f)
        {
            var dg = db.database().DOCGIAs.SingleOrDefault(a => a.MaDocGia == int.Parse(f.maDocGiaTxt.Text));
            dg.MaDocGia = int.Parse(f.maDocGiaTxt.Text);
            dg.HoTenDocGia = f.tenDocGiaTxt.Text;
            dg.NgaySinh = Convert.ToDateTime(f.ngaySinhDT.Text);
            dg.DiaChi = f.diaChiTxt.Text;
            dg.Email = f.emailTxt.Text;
            dg.NgayLapThe = Convert.ToDateTime(f.ngayLapTheDT.Text);
            dg.NgayHetHan = Convert.ToDateTime(f.ngayHetHanDT.Text);
            dg.TienNo = float.Parse(f.tienNoTxt.Text);

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(DocGiaFrm f)
        {
            var dg = db.database().DOCGIAs.SingleOrDefault(a => a.MaDocGia == int.Parse(f.maDocGiaTxt.Text));
            db.database().DOCGIAs.DeleteOnSubmit(dg);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
