using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassLoaiSach
    {
        ClassConnection db;
        
        public ClassLoaiSach()
        {
            db = new ClassConnection();
        }

        public void loadAllData(LoaiSachFrm f)
        {
            var data = db.database().LOAISACH_PROC().ToList();
            f.loaiSachGridControl.DataSource = data;

            f.loaiSachGridView.Columns[0].Caption = "Mã loại";
            f.loaiSachGridView.Columns[1].Caption = "Tên loại";
        }

        public void setNull(LoaiSachFrm f)
        {
            f.maLoaiTxt.Text = "";
            f.tenLoaiTxt.Text = "";
        }

        public void setButton(LoaiSachFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
            f.inBtn.Enabled = val;
        }

        public void enableOnject(LoaiSachFrm f, bool val)
        {
            f.maLoaiTxt.Enabled = false;
            f.tenLoaiTxt.Enabled = val;
        }

        public void loadRowSelected(LoaiSachFrm f)
        {
            int currentCell = f.loaiSachGridView.FocusedRowHandle;

            f.maLoaiTxt.Text = f.loaiSachGridView.GetRowCellValue(currentCell, "MaLoai").ToString();
            f.tenLoaiTxt.Text = f.loaiSachGridView.GetRowCellValue(currentCell, "TenLoai").ToString();
        }

        public void add(LoaiSachFrm f)
        {
            LOAI ls = new LOAI();
            ls.TenLoai = f.tenLoaiTxt.Text;

            db.database().LOAIs.InsertOnSubmit(ls);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(LoaiSachFrm f)
        {
            var ls = db.database().LOAIs.SingleOrDefault(a => a.MaLoai == int.Parse(f.maLoaiTxt.Text));
            ls.MaLoai = int.Parse(f.maLoaiTxt.Text);
            ls.TenLoai = f.tenLoaiTxt.Text;

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(LoaiSachFrm f)
        {
            var ls = db.database().LOAIs.SingleOrDefault(a => a.MaLoai == int.Parse(f.maLoaiTxt.Text));
            db.database().LOAIs.DeleteOnSubmit(ls);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
