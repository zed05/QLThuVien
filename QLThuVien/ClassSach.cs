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

        public string masach;

        public ClassSach()
        {
            db = new ClassConnection();
        }

        public void loadAllData(SachFrm f)
        {
            var data = db.database().SACH_PROC().ToList();
            f.sachGridControl.DataSource = data;


            f.sachGridView.Columns[0].Caption = "Mã sách";
            f.sachGridView.Columns[1].Caption = "Tên sách";
            f.sachGridView.Columns[2].Caption = "Tác giả";
            f.sachGridView.Columns[3].Caption = "Năm xuất bản";
            f.sachGridView.Columns[4].Caption = "Nhà xuất bản";
            f.sachGridView.Columns[5].Visible = false;
            f.sachGridView.Columns[6].Caption = "Tên loại";
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
            f.tenSachTxt.Text = "";
            f.tacGiaTxt.Text = "";
            f.namXuatBanTxt.Text = "";
            f.nhaXuatBanTxt.Text = "";
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
            masach = f.sachGridView.GetRowCellValue(currentCell, "MaSach").ToString();
            f.tenSachTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "TenSach").ToString();
            f.tacGiaTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "TacGia").ToString();
            f.namXuatBanTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "NamXuatBan").ToString();
            f.nhaXuatBanTxt.Text = f.sachGridView.GetRowCellValue(currentCell, "NhaXuatBan").ToString();
            f.loaiSachCb.Text = f.sachGridView.GetRowCellValue(currentCell, "TenLoai").ToString();
        }

        public void add(SachFrm f)
        {
            SACH s = new SACH();

            if(f.tenSachTxt.Text == "")
            {
                MessageBox.Show("Tên sách không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int k = 0;

                if(f.namXuatBanTxt.Text == "")
                {
                    f.namXuatBanTxt.Text = "9999";
                }

                foreach(var c in f.namXuatBanTxt.Text)
                {
                    if (Char.IsDigit(c))
                    {
                        k = 1;
                    }
                    else
                    {
                        k = 0;
                    }
                }

                if(k == 1)
                {
                    s.TenSach = f.tenSachTxt.Text;
                    s.TacGia = f.tacGiaTxt.Text;
                    s.NamXuatBan = int.Parse(f.namXuatBanTxt.Text);
                    s.NhaXuatBan = f.nhaXuatBanTxt.Text;
                    s.MaLoai = int.Parse(f.loaiSachCb.SelectedValue.ToString());

                    db.database().SACHes.InsertOnSubmit(s);
                    db.database().SubmitChanges();
                    loadAllData(f);
                }
                else
                {
                    MessageBox.Show("Năm xuất bản không được nhập chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void edit(SachFrm f)
        {
            var s = db.database().SACHes.SingleOrDefault(a => a.MaSach == int.Parse(masach));
            s.MaSach = int.Parse(masach);
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
            var s = db.database().SACHes.SingleOrDefault(a => a.MaSach == int.Parse(masach));
            db.database().SACHes.DeleteOnSubmit(s);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
