using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;
using System.Globalization;

namespace QLThuVien
{
    class ClassPhieuThuTien
    {
        ClassConnection db;
        public string mapt;

        public ClassPhieuThuTien()
        {
            db = new ClassConnection();
        }

        public void loadAllData(PhieuThuTienFrm f)
        {
            var data = db.database().PHIEUTHU_PROC().ToList();
            f.phieuThuTienGridControl.DataSource = data;

            f.phieuThuTienGridView.Columns[0].Caption = "Mã phiếu thu";
            f.phieuThuTienGridView.Columns[1].Caption = "Số tiền nợ";
            f.phieuThuTienGridView.Columns[1].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            f.phieuThuTienGridView.Columns[1].DisplayFormat.FormatString = "C0";
            f.phieuThuTienGridView.Columns[1].DisplayFormat.Format = CultureInfo.CreateSpecificCulture("vi-DVN");
            f.phieuThuTienGridView.Columns[2].Caption = "Số tiền thu";
            f.phieuThuTienGridView.Columns[2].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            f.phieuThuTienGridView.Columns[2].DisplayFormat.FormatString = "C0";
            f.phieuThuTienGridView.Columns[2].DisplayFormat.Format = CultureInfo.CreateSpecificCulture("vi-DVN");
            f.phieuThuTienGridView.Columns[3].Visible = false;
            f.phieuThuTienGridView.Columns[4].Visible = false;
            f.phieuThuTienGridView.Columns[5].Caption = "Tên đọc giả";
            f.phieuThuTienGridView.Columns[6].Caption = "Tên nhân viên";
        }

        public void loadDocGiaData(PhieuThuTienFrm f)
        {
            var data = db.database().DOCGIAs.ToList();
            f.tenDocGiaCb.DataSource = data;
            f.tenDocGiaCb.DisplayMember = "HoTenDocGia";
            f.tenDocGiaCb.ValueMember = "MaDocGia";
        }

        public void loadNhanVienData(PhieuThuTienFrm f)
        {
            var data = db.database().NHANVIENs.ToList();
            f.tenNhanVienCb.DataSource = data;
            f.tenNhanVienCb.DisplayMember = "HoTenNhanVien";
            f.tenNhanVienCb.ValueMember = "MaNhanVien";
        }

        public void setNull(PhieuThuTienFrm f)
        {
            f.soTienNoTxt.Text = "";
            f.soTienThuTxt.Text = "";
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

            mapt = f.phieuThuTienGridView.GetRowCellValue(currentCell, "MaPhieuThuTien").ToString();
            f.soTienNoTxt.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "SoTienNo").ToString();
            f.soTienThuTxt.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "SoTienThu").ToString();
            f.tenDocGiaCb.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "HoTenDocGia").ToString();
            f.tenNhanVienCb.Text = f.phieuThuTienGridView.GetRowCellValue(currentCell, "HoTenNhanVien").ToString();
        }

        public void add(PhieuThuTienFrm f)
        {
            PHIEUTHUTIEN pt = new PHIEUTHUTIEN();

            if(f.soTienNoTxt.Text == "" || f.soTienThuTxt.Text == "")
            {
                MessageBox.Show("Số tiền nợ và số tiền thu không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int k = 0;

                foreach(var c in f.soTienNoTxt.Text)
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
                foreach(var c in f.soTienThuTxt.Text)
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
                    pt.SoTienNo = float.Parse(f.soTienNoTxt.Text);
                    pt.SoTienThu = float.Parse(f.soTienThuTxt.Text);
                    pt.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
                    pt.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

                    db.database().PHIEUTHUTIENs.InsertOnSubmit(pt);
                    db.database().SubmitChanges();
                    loadAllData(f);
                }
                else
                {
                    MessageBox.Show("Số tiền nợ và số tiền thu không được nhập chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void edit(PhieuThuTienFrm f)
        {
            
            if (f.soTienNoTxt.Text == "" || f.soTienThuTxt.Text == "")
            {
                MessageBox.Show("Số tiền nợ và số tiền thu không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int k = 0;
                int k2 = 0;

                foreach (var c in f.soTienNoTxt.Text)
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
                foreach (var c in f.soTienThuTxt.Text)
                {
                    if (Char.IsDigit(c))
                    {
                        k2 = 1;
                    }
                    else
                    {
                        k2 = 0;
                    }
                }

                if (k == 1 && k2 == 1)
                {
                    var pt = db.database().PHIEUTHUTIENs.SingleOrDefault(a => a.MaPhieuThuTien == int.Parse(mapt));
                    pt.SoTienNo = float.Parse(f.soTienNoTxt.Text);
                    pt.SoTienThu = float.Parse(f.soTienThuTxt.Text);
                    pt.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
                    pt.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

                    db.database().SubmitChanges();
                    loadAllData(f);
                }
                else
                {
                    MessageBox.Show("Số tiền nợ và số tiền thu không được nhập chữ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void delete(PhieuThuTienFrm f)
        {
            var pt = db.database().PHIEUTHUTIENs.SingleOrDefault(a => a.MaPhieuThuTien == int.Parse(mapt));
            db.database().PHIEUTHUTIENs.DeleteOnSubmit(pt);
            db.database().SubmitChanges();
            loadAllData(f);
        }
    }
}
