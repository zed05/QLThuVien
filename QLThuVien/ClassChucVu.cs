﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.LinQ;
using System.Windows.Forms;

namespace QLThuVien
{
    class ClassChucVu
    {
        ClassConnection db;

        string macv;

        public ClassChucVu()
        {
            db = new ClassConnection();
        }

        public void loadAllData(ChucVuFrm f)
        {
            var data = db.database().CHUCVU_PROC().ToList();
            f.chucVuGridControl.DataSource = data;

            f.chucVuGridView.Columns[0].Caption = "Mã chức vụ";
            f.chucVuGridView.Columns[1].Caption = "Tên chức vụ";
            f.chucVuGridView.Columns[2].Caption = "Mô tả";
        }

        public void setNull(ChucVuFrm f)
        {
            f.tenChucVuTxt.Text = "";
            f.moTaTxt.Text = "";
        }

        public void setButton(ChucVuFrm f, bool val)
        {
            f.themBtn.Enabled = val;
            f.suaBtn.Enabled = val;
            f.xoaBtn.Enabled = val;
            f.luuBtn.Enabled = !val;
            f.kLuuBtn.Enabled = !val;
        }

        public void enableObject(ChucVuFrm f, bool val)
        {
            f.tenChucVuTxt.Enabled = val;
            f.moTaTxt.Enabled = val;
        }

        public void add(ChucVuFrm f)
        {
            CHUCVU cv = new CHUCVU();
            cv.TenCV = f.tenChucVuTxt.Text;
            cv.MoTa = f.moTaTxt.Text;

            db.database().CHUCVUs.InsertOnSubmit(cv);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void edit(ChucVuFrm f)
        {
            var cv = db.database().CHUCVUs.SingleOrDefault(a => a.MaCV == int.Parse(macv));
            cv.TenCV = f.tenChucVuTxt.Text;
            cv.MoTa = f.moTaTxt.Text;

            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void delete(ChucVuFrm f)
        {
            var cv = db.database().CHUCVUs.SingleOrDefault(a => a.MaCV == int.Parse(macv));
            db.database().CHUCVUs.DeleteOnSubmit(cv);
            db.database().SubmitChanges();
            loadAllData(f);
        }

        public void loadRowSelected(ChucVuFrm f)
        {
            int currentCell = f.chucVuGridView.FocusedRowHandle;

            macv = f.chucVuGridView.GetRowCellValue(currentCell, "MaCV").ToString();
            f.tenChucVuTxt.Text = f.chucVuGridView.GetRowCellValue(currentCell, "TenCV").ToString();
            f.moTaTxt.Text = f.chucVuGridView.GetRowCellValue(currentCell, "MoTa").ToString();
        }
    }
}
