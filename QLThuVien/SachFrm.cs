using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLThuVien
{
    public partial class SachFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassSach s;

        bool addBtn = false;

        public SachFrm()
        {
            InitializeComponent();
            s = new ClassSach();
            s.loadAllData(this);
            s.setButton(this, true);
            s.enableObject(this, false);
            s.loadRowSelected(this);
            s.loadLoaiData(this);
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm();
            f.Show();
        }

        private void sachGridView_Click(object sender, EventArgs e)
        {
            s.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                s.setButton(this, true);
                s.enableObject(this, false);
                s.loadRowSelected(this);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            s.setNull(this);
            s.setButton(this, false);
            s.enableObject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            s.setButton(this, false);
            s.enableObject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa cuốn \"" + tenSachTxt.Text + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                s.delete(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                s.add(this);
            }
            else
            {
                s.edit(this);
            }

            s.setButton(this, true);
            s.enableObject(this, false);
            s.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            s.setButton(this, true);
            s.enableObject(this, false);
            s.loadRowSelected(this);
        }

    }
}