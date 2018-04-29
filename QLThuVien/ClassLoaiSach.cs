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

        string maloai;
        
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

        public void enableObject(LoaiSachFrm f, bool val)
        {
            f.tenLoaiTxt.Enabled = val;
        }

        public void loadRowSelected(LoaiSachFrm f)
        {
            int currentCell = f.loaiSachGridView.FocusedRowHandle;

            maloai = f.loaiSachGridView.GetRowCellValue(currentCell, "MaLoai").ToString();
            f.tenLoaiTxt.Text = f.loaiSachGridView.GetRowCellValue(currentCell, "TenLoai").ToString();
        }

        public void add(LoaiSachFrm f)
        {
            LOAI ls = new LOAI();

            if(f.tenLoaiTxt.Text == "")
            {
                MessageBox.Show("Tên loại không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ls.TenLoai = f.tenLoaiTxt.Text;
                db.database().LOAIs.InsertOnSubmit(ls);
                db.database().SubmitChanges();
                loadAllData(f);
            }
           
        }

        public void edit(LoaiSachFrm f)
        {
            if (f.tenLoaiTxt.Text == "")
            {
                MessageBox.Show("Tên loại không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ls = db.database().LOAIs.SingleOrDefault(a => a.MaLoai == int.Parse(maloai));
                ls.MaLoai = int.Parse(maloai);
                ls.TenLoai = f.tenLoaiTxt.Text;

                db.database().SubmitChanges();
                loadAllData(f);
            }
        }

        public void delete(LoaiSachFrm f)
        {
            var ls = db.database().LOAIs.SingleOrDefault(a => a.MaLoai == int.Parse(maloai));
            db.database().LOAIs.DeleteOnSubmit(ls);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
