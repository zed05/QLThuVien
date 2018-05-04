using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class SachReport : DevExpress.XtraReports.UI.XtraReport
    {
        ClassConnection db;
        public SachReport()
        {
            InitializeComponent();
            db = new ClassConnection();

            tongSoSachLb.Text = db.database().TONG_SACH_FUNC().Value.ToString();
        }

    }
}
