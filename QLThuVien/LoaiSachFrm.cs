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
    public partial class LoaiSachFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassLoaiSach ls;

        bool addBtn = false;

        public string loginName;

        public LoaiSachFrm(string id)
        {
            InitializeComponent();
            ls = new ClassLoaiSach();
            ls.loadAllData(this);
            ls.setButton(this, true);
            ls.enableOnject(this, false);
            ls.loadRowSelected(this);

            loginName = id;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm(loginName);
            f.Show();
        }

        private void loaiSachGridView_Click(object sender, EventArgs e)
        {
            ls.loadRowSelected(this);
            if(addBtn == true)
            {
                addBtn = false;
                ls.setButton(this, true);
                ls.enableOnject(this, false);
                ls.loadRowSelected(this);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            ls.setNull(this);
            ls.setButton(this, false);
            ls.enableOnject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            ls.setButton(this, false);
            ls.enableOnject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa loại sách \"" + tenLoaiTxt.Text + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                ls.delete(this);
                ls.loadRowSelected(this);
            }   
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                ls.add(this);
            }
            else
            {
                ls.edit(this);
            }
            ls.setButton(this, true);
            ls.enableOnject(this, false);
            ls.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            ls.setButton(this, true);
            ls.enableOnject(this, false);
            ls.loadRowSelected(this);
        }

        private void SachFrmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            SachFrm f = new SachFrm(loginName);
            f.Show();
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}