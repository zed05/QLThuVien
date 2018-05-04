using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class NhanVienReport : DevExpress.XtraReports.UI.XtraReport
    {
        ClassConnection db;
        public NhanVienReport()
        {
            InitializeComponent();
            db = new ClassConnection();
            tongNhanVienLb.Text = db.database().TONG_NV_FUNC().Value.ToString();
        }

    }
}
