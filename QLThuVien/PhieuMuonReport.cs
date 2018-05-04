using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class PhieuMuonReport : DevExpress.XtraReports.UI.XtraReport
    {
        ClassConnection db;
        public PhieuMuonReport()
        {
            InitializeComponent();
            db = new ClassConnection();

            tongTienLb.Text = db.database().TONG_TIEN_PHIEUMUON_FUNC().Value.ToString();
        }

    }
}
