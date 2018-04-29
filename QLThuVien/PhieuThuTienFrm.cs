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
    public partial class PhieuThuTienFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassPhieuThuTien pt;

        bool addBtn = false;

        public string loginName;

        public PhieuThuTienFrm(string id)
        {
            InitializeComponent();
            pt = new ClassPhieuThuTien();
            pt.loadAllData(this);

            pt.loadDocGiaData(this);
            pt.loadNhanVienData(this);

            pt.setButton(this, true);
            pt.enableObject(this, false);

            pt.loadRowSelected(this);

            loginName = id;

            
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm(loginName);
            f.Show();
        }

        private void phieuThuTienGridView_Click(object sender, EventArgs e)
        {
            pt.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                pt.setButton(this, true);
                pt.enableObject(this, false);
                pt.loadRowSelected(this);
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            pt.setNull(this);
            pt.setButton(this, false);
            pt.enableObject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            pt.setButton(this, false);
            pt.enableObject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa phiếu thu số \"" + pt.mapt.ToString() + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                pt.delete(this);
                pt.loadRowSelected(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                pt.add(this);
            }
            else
            {
                pt.edit(this);
            }

            pt.setButton(this, true);
            pt.enableObject(this, false);
            pt.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            pt.setButton(this, true);
            pt.enableObject(this, false);
            pt.loadRowSelected(this);
        }

        private void tenDocGiaCb_MouseClick(object sender, MouseEventArgs e)
        {
            //pt.loadDocGiaData(this);
        }

        private void tenNhanVienCb_MouseClick(object sender, MouseEventArgs e)
        {
            //pt.loadNhanVienData(this);
        }

        private void docGiaFrmBtn_Click(object sender, EventArgs e)
        {
            DocGiaFrm f = new DocGiaFrm(loginName);
            f.Show();
            this.Close();
        }

        private void phieuMuonSachFrmBtn_Click(object sender, EventArgs e)
        {
            PhieuMuonSachFrm f = new PhieuMuonSachFrm(loginName);
            f.Show();
            this.Close();
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phieuThuTienGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                pt.loadRowSelected(this);
                if (addBtn)
                {
                    addBtn = false;
                    pt.enableObject(this, false);
                    pt.setButton(this, true);
                    pt.loadRowSelected(this);
                }
            }
        }
    }
}