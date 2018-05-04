using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class LoaiReport : DevExpress.XtraReports.UI.XtraReport
    {
        ClassConnection db;
        public LoaiReport()
        {
            InitializeComponent();
            db = new ClassConnection();

            tongLoaiLb.Text = db.database().TONG_LOAI_FUNC().Value.ToString();
        }

    }
}
