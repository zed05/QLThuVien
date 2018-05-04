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
using DevExpress.XtraReports.UI;

namespace QLThuVien
{
    public partial class PhieuMuonSachFrm : DevExpress.XtraEditors.XtraForm
    {
        ClassPhieuMuonSach pm;

        bool addBtn = false;

        public string loginName;

        public PhieuMuonSachFrm(string id)
        {
            InitializeComponent();
            pm = new ClassPhieuMuonSach();
            pm.loadAllData(this);
            pm.setButton(this, true);
            pm.enableObject(this, false);
            pm.loadRowSelected(this);
            pm.loadDocGiaData(this);
            pm.loadNhanVienData(this);
            pm.loadMaSachData(this);

            loginName = id;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainFrm f = new MainFrm(loginName);
            f.Show();
        }

        private void phieuMuonSachGridView_Click(object sender, EventArgs e)
        {
            pm.loadRowSelected(this);
            if (addBtn)
            {
                addBtn = false;
                pm.setButton(this, true);
                pm.enableObject(this, false);
                pm.loadRowSelected(this);
                
            }
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            addBtn = true;
            pm.setNull(this);
            pm.setButton(this, false);
            pm.enableObject(this, true);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            addBtn = false;
            pm.setButton(this, false);
            pm.enableObject(this, true);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn xóa phiếu số \"" + pm.mapm.ToString() + "\" không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                pm.delete(this);
                pm.loadRowSelected(this);
            }
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (addBtn)
            {
                pm.add(this);
            }
            else
            {
                pm.edit(this);
            }

            pm.setButton(this, true);
            pm.enableObject(this, false);
            pm.loadRowSelected(this);
        }

        private void kLuuBtn_Click(object sender, EventArgs e)
        {
            pm.setButton(this, true);
            pm.enableObject(this, false);
            pm.loadRowSelected(this);
        }

        private void docGiaFrmBtn_Click(object sender, EventArgs e)
        {
            DocGiaFrm f = new DocGiaFrm(loginName);
            f.Show();
            this.Close();
        }

        private void exitMainFrmBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phieuMuonSachGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                pm.loadRowSelected(this);
                if (addBtn)
                {
                    addBtn = false;
                    pm.enableObject(this, false);
                    pm.setButton(this, true);
                    pm.loadRowSelected(this);
                }
            }
        }

        private void inBtn_Click(object sender, EventArgs e)
        {
            PhieuMuonReport rp = new PhieuMuonReport();
            rp.ShowPreview();
        }
    }
}