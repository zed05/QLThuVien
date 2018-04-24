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

        public ClassPhieuMuonSach()
        {
            db = new ClassConnection();
        }

        public void loadAllData(PhieuMuonSachFrm f)
        {
            var data = db.database().PHIEUMUON_PROC().ToList();
            f.phieuMuonSachGridControl.DataSource = data;
        }

        public void setNull(PhieuMuonSachFrm f)
        {
            f.maPhieuMuonSachTxt.Text = "";
            f.ngayMuonDtp.EditValue = DateTime.Now;
            f.tenDocGiaCb.Text = "";
            f.tenNhanVienCb.Text = "";
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
            f.maPhieuMuonSachTxt.Enabled = false;
            f.ngayMuonDtp.Enabled = val;
            f.tenDocGiaCb.Enabled = val;
            f.tenNhanVienCb.Enabled = val;

            if(f.tenNhanVienCb.Enabled == true && f.tenDocGiaCb.Enabled == true)
            {
                f.tenDocGiaCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
                f.tenNhanVienCb.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
            }
        }

        public void loadRowSelected(PhieuMuonSachFrm f)
        {
            int currentCell = f.phieuMuonSachGridView.FocusedRowHandle;

            f.maPhieuMuonSachTxt.Text = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "MaPhieuMuon").ToString();
            f.ngayMuonDtp.EditValue = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "NgayMuon").ToString();
            f.tenDocGiaCb.Text = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "HoTenDocGia").ToString();
            f.tenNhanVienCb.Text = f.phieuMuonSachGridView.GetRowCellValue(currentCell, "HoTenNhanVien").ToString();
        }

        public void add(PhieuMuonSachFrm f)
        {
            PHIEUMUONSACH pm = new PHIEUMUONSACH();
            pm.MaPhieuMuon = int.Parse(f.maPhieuMuonSachTxt.Text);
            pm.NgayMuon = Convert.ToDateTime(f.ngayMuonDtp.Text);
            pm.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            pm.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

            db.database().PHIEUMUONSACHes.InsertOnSubmit(pm);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(PhieuMuonSachFrm f)
        {
            var pm = db.database().PHIEUMUONSACHes.SingleOrDefault(a => a.MaPhieuMuon == int.Parse(f.maPhieuMuonSachTxt.Text));

            pm.MaPhieuMuon = int.Parse(f.maPhieuMuonSachTxt.Text);
            pm.NgayMuon = Convert.ToDateTime(f.ngayMuonDtp.Text);
            pm.MaDocGia = int.Parse(f.tenDocGiaCb.SelectedValue.ToString());
            pm.MaNhanVien = int.Parse(f.tenNhanVienCb.SelectedValue.ToString());

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(PhieuMuonSachFrm f)
        {
            var pm = db.database().PHIEUMUONSACHes.SingleOrDefault(a => a.MaPhieuMuon == int.Parse(f.maPhieuMuonSachTxt.Text));
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
    }
}
