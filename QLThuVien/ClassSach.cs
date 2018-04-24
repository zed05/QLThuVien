using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassSach
    {
        ClassConnection db;

        public ClassSach()
        {
            db = new ClassConnection();
        }

        public void loadAllData(SachFrm f)
        {
            var data = db.database().SACH_PROC().ToList();
            f.sachGridControl.DataSource = data;

            f.sachGridView.Columns[5].Visible = false;
        }

        public void loadLoaiData(SachFrm f)
        {
            var data = db.database().LOAIs.ToList();
            f.loaiSachCb.DataSource = data;
            f.loaiSachCb.DisplayMember = "TenLoai";
            f.loaiSachCb.ValueMember = "MaLoai";
        }

        public void setNull(SachFrm f)
        {
            f.maSachTxt.Text = "";
            f.tenSachTxt.Text = "";
            f.tacGiaTxt.Text = "";
            f.namXuatBanTxt.Text = "";
            f.nhaXuatBanTxt.Text = "";
            f.loaiSachCb.Text = "";
        }

        public void setButton(SachFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
            f.inBtn.Enabled = val;
        }


        public void enableObject(SachFrm f, bool val)
        {
            f.maSachTxt.Enabled = false;
            f.tenSachTxt.Enabled = val;
            f.tacGiaTxt.Enabled = val;
            f.namXuatBanTxt.Enabled = val;
            f.nhaXuatBanTxt.Enabled = val;
            f.loaiSachCb.Enabled = val;
            if (f.loaiSachCb.Enabled)
            {
                f.loaiSachCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }
        }

        public void loadRowSelected(SachFrm f)
        {
            int currentCell = f.sachGridView.FocusedRowHandle;
            f.maSachTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "MaSach").ToString();
            f.tenSachTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "TenSach").ToString();
            f.tacGiaTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "TacGia").ToString();
            f.namXuatBanTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "NamXuatBan").ToString();
            f.nhaXuatBanTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "NhaXuatBan").ToString();
            f.loaiSachCb.Text = f.sachGridView.GetRowCellValue(currentCell, "TenLoai").ToString();
        }

        public void add(SachFrm f)
        {
            SACH s = new SACH();
            s.TenSach = f.tenSachTxt.Text;
            s.TacGia = f.tacGiaTxt.Text;
            s.NamXuatBan = int.Parse(f.namXuatBanTxt.Text);
            s.NhaXuatBan = f.nhaXuatBanTxt.Text;
            s.MaLoai = int.Parse(f.loaiSachCb.SelectedValue.ToString());

            db.database().SACHes.InsertOnSubmit(s);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(SachFrm f)
        {
            var s = db.database().SACHes.SingleOrDefault(a => a.MaSach == int.Parse(f.maSachTxt.Text));
            s.MaSach = int.Parse(f.maSachTxt.Text);
            s.TenSach = f.tenSachTxt.Text;
            s.TacGia = f.tacGiaTxt.Text;
            s.NamXuatBan = int.Parse(f.namXuatBanTxt.Text);
            s.NhaXuatBan = f.nhaXuatBanTxt.Text;
            s.MaLoai = int.Parse(f.loaiSachCb.SelectedValue.ToString());

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(SachFrm f)
        {
            var s = db.database().SACHes.SingleOrDefault(a => a.MaSach == int.Parse(f.maSachTxt.Text));
            db.database().SACHes.DeleteOnSubmit(s);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
