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
    class ClassPhieuMuonSach
    {
        ClassConnection db;

        public string mapm;

        public ClassPhieuMuonSach()
        {
            db = new ClassConnection();
        }

        public void loadAllData(PhieuMuonSachFrm f)
        {
            var data = db.database().PHIEUMUON_PROC().ToList();
            f.phieuMuonSachGridControl.DataSource = data;

            f.phieuMuonSachGridView.Columns[0].Caption = "Mã phiếu mượn";
            f.phieuMuonSachGridView.Columns[1].Caption = "Ngày mượn";
            f.phieuMuonSachGridView.Columns[2].Caption = "Tên đọc giả";
            f.phieuMuonSachGridView.Columns[3].Caption = "Tên nhân viên";
            f.phieuMuonSachGridView.Columns[4].Visible = false;
            f.phieuMuonSachGridView.Columns[5].Caption = "Tên sách";
            f.phieuMuonSachGridView.Columns[6].Visible = false;
            f.phieuMuonSachGridView.Columns[7].Visible = false;
            f.phieuMuonSachGridView.Columns[8].Caption = "Giá tiền";
            f.phieuMuonSachGridView.Columns[8].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            f.phieuMuonSachGridView.Columns[8].DisplayFormat.FormatString = "C0";
            f.phieuMuonSachGridView.Columns[8].DisplayFormat.Format = CultureInfo.CreateSpecificCulture("vi-DVN");
            f.phieuMuonSachGridView.Columns[9].Caption = "Tình trạng";
        }

        public void setNull(PhieuMuonSachFrm f)
        {
            f.ngayMuonDtp.EditValue = DateTime.Now;
            f.chuaThanhToanRb.Checked = true;
        }

        public void setButton(PhieuMuonSachFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
            f.inBtn.Enabled = val;
        }

        public void enableObject(PhieuMuonSachFrm f, bool val)
        {
            f.ngayMuonDtp.Enabled = val;
            f.tenDocGiaCb.Enabled = val;
            f.tenNhanVienCb.Enabled = val;
            f.maSachCb.Enabled = val;
            f.chuaThanhToanRb.Enabled = val;
            f.daThanhToanRb.Enabled = val;

            if(f.tenNhanVienCb.Enabled == true && f.tenDocGiaCb.Enabled == true)
            {
                f.tenDocGiaCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
                f.tenNhanVienCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
                f.maSachCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }
        }

        public void loadRowSelected(PhieuMuonSachFrm f)
        {
            int currentCell = f.phieuMuonSachGridView.FocusedRowHandle;

            mapm = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "MaPhieuMuon").ToString();
            f.ngayMuonDtp.EditValue = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "NgayMuon").ToString();
            f.tenDocGiaCb.Text = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "HoTenDocGia").ToString();
            f.tenNhanVienCb.Text = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "HoTenNhanVien").ToString();
            f.maSachCb.Text = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "MaSach").ToString();
        }

        public void add(PhieuMuonSachFrm f)
        {
            PHIEUMUONSACH pm = new PHIEUMUONSACH();

            pm.NgayMuon = Convert.ToDateTime(f.ngayMuonDtp.Text);
            pm.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            pm.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());
            pm.MaSach = int.Parse(f.maSachCb.SelectedValue.ToString());

            if (f.chuaThanhToanRb.Checked)
            {
                pm.TinhTrangThanhToan = "Chưa thanh toán";
            }
            else
            {
                pm.TinhTrangThanhToan = "Đã thanh toán";
            }
            
            db.database().PHIEUMUONSACHes.InsertOnSubmit(pm);
            db.database().SubmitChanges();

            loadAllData(f);
        }

        public void edit(PhieuMuonSachFrm f)
        {
            var pm = db.database().PHIEUMUONSACHes.SingleOrDefault(a => a.MaPhieuMuon == int.Parse(mapm));

            pm.NgayMuon = Convert.ToDateTime(f.ngayMuonDtp.Text);
            pm.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            pm.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());
            pm.MaSach = int.Parse(f.maSachCb.SelectedValue.ToString());

            if (f.chuaThanhToanRb.Checked)
            {
                pm.TinhTrangThanhToan = "Chưa thanh toán";
            }
            else
            {
                pm.TinhTrangThanhToan = "Đã thanh toán";
            }

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(PhieuMuonSachFrm f)
        {
            var pm = db.database().PHIEUMUONSACHes.SingleOrDefault(a => a.MaPhieuMuon == int.Parse(mapm));

            db.database().PHIEUMUONSACHes.DeleteOnSubmit(pm);
            db.database().SubmitChanges();

            loadAllData(f);
        }

        public void loadDocGiaData(PhieuMuonSachFrm f)
        {
            var data = db.database().DOCGIAs.ToList();
            f.tenDocGiaCb.DataSource = data;
            f.tenDocGiaCb.DisplayMember = "HoTenDocGia";
            f.tenDocGiaCb.ValueMember = "MaDocGia";
        }

        public void loadNhanVienData(PhieuMuonSachFrm f)
        {
            var data = db.database().NHANVIENs.ToList();
            f.tenNhanVienCb.DataSource = data;
            f.tenNhanVienCb.DisplayMember = "HoTenNhanVien";
            f.tenNhanVienCb.ValueMember = "MaNhanVien";
        }

        public void loadMaSachData(PhieuMuonSachFrm f)
        {
            var data = db.database().SACHes.ToList();
            f.maSachCb.DataSource = data;
            f.maSachCb.ValueMember = "MaSach";
        }
    }
}
