using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class DocGiaReport : DevExpress.XtraReports.UI.XtraReport
    {
        ClassConnection db;
        public DocGiaReport()
        {
            InitializeComponent();
            db = new ClassConnection();

            tongDocGiaLb.Text = db.database().TONG_DOCGIA_FUNC().Value.ToString();
        }

    }
}
