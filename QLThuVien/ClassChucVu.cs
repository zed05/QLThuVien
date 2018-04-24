using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassChucVu
    {
        ClassConnection db;

        public ClassChucVu()
        {
            db = new ClassConnection();
        }

        public void loadAllData(ChucVuFrm f)
        {
            var data = db.database().CHUCVU_PROC().ToList();
            f.chucVuGridControl.DataSource = data;
        }

        public void setNull(ChucVuFrm f)
        {
            f.maChucVuTxt.Text = "";
            f.tenChucVuTxt.Text = "";
            f.moTaTxt.Text = "";
        }

        public void setButton(ChucVuFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
            f.inBtn.Enabled = val;
        }

        public void enableObject(ChucVuFrm f, bool val)
        {
            f.maChucVuTxt.Enabled = false;
            f.tenChucVuTxt.Enabled = val;
            f.moTaTxt.Enabled = val;
        }

        public void add(ChucVuFrm f)
        {
            CHUCVU cv = new CHUCVU();
            cv.TenCV = f.tenChucVuTxt.Text;
            cv.MoTa = f.moTaTxt.Text;

            db.database().CHUCVUs.InsertOnSubmit(cv);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(ChucVuFrm f)
        {
            var cv = db.database().CHUCVUs.SingleOrDefault(a => a.MaCV == int.Parse(f.maChucVuTxt.Text));
            cv.TenCV = f.tenChucVuTxt.Text;
            cv.MoTa = f.moTaTxt.Text;

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(ChucVuFrm f)
        {
            var cv = db.database().CHUCVUs.SingleOrDefault(a => a.MaCV == int.Parse(f.maChucVuTxt.Text));
            db.database().CHUCVUs.DeleteOnSubmit(cv);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void loadRowSelected(ChucVuFrm f)
        {
            int currentCell = f.chucVuGridView.FocusedRowHandle;

            f.maChucVuTxt.Text = f.chucVuGridView.GetRowCellValue(currentCell, "MaCV").ToString();
            f.tenChucVuTxt.Text = f.chucVuGridView.GetRowCellValue(currentCell, "TenCV").ToString();
            f.moTaTxt.Text = f.chucVuGridView.GetRowCellValue(currentCell, "MoTa").ToString();
        }
    }
}
