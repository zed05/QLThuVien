using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

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
            f.phieuMuonSachGridView.Columns[2].Visible = false;
            f.phieuMuonSachGridView.Columns[3].Visible = false;
            f.phieuMuonSachGridView.Columns[4].Caption = "Tên đọc giả";
            f.phieuMuonSachGridView.Columns[5].Caption = "Tên nhân viên";
            f.phieuMuonSachGridView.Columns[6].Caption = "Tên Sách";
            f.phieuMuonSachGridView.Columns[7].Visible = false;
        }

        public void setNull(PhieuMuonSachFrm f)
        {
            f.ngayMuonDtp.EditValue = DateTime.Now;
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
            CHITIETPHIEUMUON cpm = new CHITIETPHIEUMUON();

            pm.NgayMuon = Convert.ToDateTime(f.ngayMuonDtp.Text);
            pm.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            pm.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());
            db.database().PHIEUMUONSACHes.InsertOnSubmit(pm);
            db.database().SubmitChanges();

            cpm.MaSach = int.Parse(f.maSachCb.SelectedValue.ToString());
            cpm.MaPhieuMuon = db.database().LAST_PHIEUMUON_FUNC().Value;
            db.database().CHITIETPHIEUMUONs.InsertOnSubmit(cpm);
            db.database().SubmitChanges();

            loadAllData(f);
        }

        public void edit(PhieuMuonSachFrm f)
        {
            //var pm = db.database().PHIEUMUONSACHes.SingleOrDefault(a => a.MaPhieuMuon == int.Parse(mapm));
            //var cpm = db.database().CHITIETPHIEUMUONs.SingleOrDefault(b => b.MaPhieuMuon == int.Parse(mapm));

            //pm.NgayMuon = Convert.ToDateTime(f.ngayMuonDtp.Text);
            //pm.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            //pm.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());
            //db.database().SubmitChanges();

            //cpm.MaSach = int.Parse(f.maSachCb.SelectedValue.ToString());
            //db.database().SubmitChanges();

            //loadAllData(f);
        }

        public void delete(PhieuMuonSachFrm f)
        {
            var pm = db.database().PHIEUMUONSACHes.SingleOrDefault(a => a.MaPhieuMuon == int.Parse(mapm));
            var cpm = db.database().CHITIETPHIEUMUONs.SingleOrDefault(b => b.MaPhieuMuon == int.Parse(mapm));

            // Xóa dữ liệu trong bảng CHITIETPHIEUMUON trước để tránh lỗi khóa ngoại
            db.database().CHITIETPHIEUMUONs.DeleteOnSubmit(cpm);
            db.database().SubmitChanges();

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
