namespace QLThuVien
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.exitMainFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.userNameLabel = new DevExpress.XtraEditors.LabelControl();
            this.logOutBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.thongTinDangNhapFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.chucVuFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.nhanVienFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.loaiSachFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.sachFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.phieuMuonSachFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.phieuThuTienFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            this.docGiaFrmBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.exitMainFrmBtn);
            this.panelControl1.Controls.Add(this.userNameLabel);
            this.panelControl1.Controls.Add(this.logOutBtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1469, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(448, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(603, 40);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "CHƯƠNG TRÌNH QUẢN LÝ THƯ VIỆN";
            // 
            // exitMainFrmBtn
            // 
            this.exitMainFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitMainFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_close_window_64;
            this.exitMainFrmBtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.exitMainFrmBtn.Location = new System.Drawing.Point(1403, 20);
            this.exitMainFrmBtn.Name = "exitMainFrmBtn";
            this.exitMainFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.exitMainFrmBtn.Size = new System.Drawing.Size(54, 55);
            this.exitMainFrmBtn.TabIndex = 12;
            this.exitMainFrmBtn.TabStop = false;
            this.exitMainFrmBtn.Click += new System.EventHandler(this.exitMainFrmBtn_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(111)))), ((int)(((byte)(62)))));
            this.userNameLabel.Appearance.Options.UseFont = true;
            this.userNameLabel.Appearance.Options.UseForeColor = true;
            this.userNameLabel.Location = new System.Drawing.Point(24, 12);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(56, 24);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "Admin";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logOutBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.logOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logOutBtn.ImageOptions.Image")));
            this.logOutBtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.logOutBtn.Location = new System.Drawing.Point(22, 42);
            this.logOutBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.logOutBtn.Size = new System.Drawing.Size(39, 31);
            this.logOutBtn.TabIndex = 10;
            this.logOutBtn.TabStop = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.groupControl3);
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1469, 457);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.thongTinDangNhapFrmBtn);
            this.groupControl3.Controls.Add(this.chucVuFrmBtn);
            this.groupControl3.Controls.Add(this.nhanVienFrmBtn);
            this.groupControl3.Location = new System.Drawing.Point(988, 11);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(462, 421);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "QUẢN LÝ THÔNG TIN NHÂN VIÊN";
            // 
            // thongTinDangNhapFrmBtn
            // 
            this.thongTinDangNhapFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.thongTinDangNhapFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinDangNhapFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.thongTinDangNhapFrmBtn.Appearance.Options.UseBackColor = true;
            this.thongTinDangNhapFrmBtn.Appearance.Options.UseFont = true;
            this.thongTinDangNhapFrmBtn.Appearance.Options.UseForeColor = true;
            this.thongTinDangNhapFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.thongTinDangNhapFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thongTinDangNhapFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_access_64;
            this.thongTinDangNhapFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.thongTinDangNhapFrmBtn.Location = new System.Drawing.Point(235, 233);
            this.thongTinDangNhapFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.thongTinDangNhapFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.thongTinDangNhapFrmBtn.Name = "thongTinDangNhapFrmBtn";
            this.thongTinDangNhapFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.thongTinDangNhapFrmBtn.Size = new System.Drawing.Size(222, 132);
            this.thongTinDangNhapFrmBtn.TabIndex = 1;
            this.thongTinDangNhapFrmBtn.TabStop = false;
            this.thongTinDangNhapFrmBtn.Text = "THÔNG TIN\r\nĐĂNG NHẬP";
            // 
            // chucVuFrmBtn
            // 
            this.chucVuFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.chucVuFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chucVuFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.chucVuFrmBtn.Appearance.Options.UseBackColor = true;
            this.chucVuFrmBtn.Appearance.Options.UseFont = true;
            this.chucVuFrmBtn.Appearance.Options.UseForeColor = true;
            this.chucVuFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chucVuFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chucVuFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_conference_64;
            this.chucVuFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.chucVuFrmBtn.Location = new System.Drawing.Point(5, 233);
            this.chucVuFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.chucVuFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chucVuFrmBtn.Name = "chucVuFrmBtn";
            this.chucVuFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.chucVuFrmBtn.Size = new System.Drawing.Size(222, 132);
            this.chucVuFrmBtn.TabIndex = 1;
            this.chucVuFrmBtn.TabStop = false;
            this.chucVuFrmBtn.Text = "CHỨC VỤ";
            // 
            // nhanVienFrmBtn
            // 
            this.nhanVienFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.nhanVienFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhanVienFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.nhanVienFrmBtn.Appearance.Options.UseBackColor = true;
            this.nhanVienFrmBtn.Appearance.Options.UseFont = true;
            this.nhanVienFrmBtn.Appearance.Options.UseForeColor = true;
            this.nhanVienFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.nhanVienFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nhanVienFrmBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_manager_64;
            this.nhanVienFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.nhanVienFrmBtn.Location = new System.Drawing.Point(2, 26);
            this.nhanVienFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.nhanVienFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.nhanVienFrmBtn.Name = "nhanVienFrmBtn";
            this.nhanVienFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.nhanVienFrmBtn.Size = new System.Drawing.Size(458, 163);
            this.nhanVienFrmBtn.TabIndex = 0;
            this.nhanVienFrmBtn.TabStop = false;
            this.nhanVienFrmBtn.Text = "NHÂN VIÊN";
            this.nhanVienFrmBtn.Click += new System.EventHandler(this.nhanVienFrmBtn_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.loaiSachFrmBtn);
            this.groupControl2.Controls.Add(this.sachFrmBtn);
            this.groupControl2.Location = new System.Drawing.Point(502, 11);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(462, 421);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "QUẢN LÝ SÁCH";
            // 
            // loaiSachFrmBtn
            // 
            this.loaiSachFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.loaiSachFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiSachFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.loaiSachFrmBtn.Appearance.Options.UseBackColor = true;
            this.loaiSachFrmBtn.Appearance.Options.UseFont = true;
            this.loaiSachFrmBtn.Appearance.Options.UseForeColor = true;
            this.loaiSachFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.loaiSachFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loaiSachFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_elective_64;
            this.loaiSachFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.loaiSachFrmBtn.Location = new System.Drawing.Point(123, 233);
            this.loaiSachFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.loaiSachFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.loaiSachFrmBtn.Name = "loaiSachFrmBtn";
            this.loaiSachFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.loaiSachFrmBtn.Size = new System.Drawing.Size(222, 132);
            this.loaiSachFrmBtn.TabIndex = 1;
            this.loaiSachFrmBtn.TabStop = false;
            this.loaiSachFrmBtn.Text = "LOẠI SÁCH";
            this.loaiSachFrmBtn.Click += new System.EventHandler(this.loaiSachFrmBtn_Click);
            // 
            // sachFrmBtn
            // 
            this.sachFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.sachFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sachFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.sachFrmBtn.Appearance.Options.UseBackColor = true;
            this.sachFrmBtn.Appearance.Options.UseFont = true;
            this.sachFrmBtn.Appearance.Options.UseForeColor = true;
            this.sachFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.sachFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sachFrmBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sachFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_book_64;
            this.sachFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.sachFrmBtn.Location = new System.Drawing.Point(2, 26);
            this.sachFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.sachFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.sachFrmBtn.Name = "sachFrmBtn";
            this.sachFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.sachFrmBtn.Size = new System.Drawing.Size(458, 163);
            this.sachFrmBtn.TabIndex = 0;
            this.sachFrmBtn.TabStop = false;
            this.sachFrmBtn.Text = "SÁCH";
            this.sachFrmBtn.Click += new System.EventHandler(this.sachFrmBtn_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.phieuMuonSachFrmBtn);
            this.groupControl1.Controls.Add(this.phieuThuTienFrmBtn);
            this.groupControl1.Controls.Add(this.docGiaFrmBtn);
            this.groupControl1.Location = new System.Drawing.Point(22, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(462, 421);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "QUẢN LÝ THÔNG TIN ĐỌC GIẢ";
            // 
            // phieuMuonSachFrmBtn
            // 
            this.phieuMuonSachFrmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phieuMuonSachFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.phieuMuonSachFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieuMuonSachFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.phieuMuonSachFrmBtn.Appearance.Options.UseBackColor = true;
            this.phieuMuonSachFrmBtn.Appearance.Options.UseFont = true;
            this.phieuMuonSachFrmBtn.Appearance.Options.UseForeColor = true;
            this.phieuMuonSachFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.phieuMuonSachFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phieuMuonSachFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_bulleted_list_64;
            this.phieuMuonSachFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.phieuMuonSachFrmBtn.Location = new System.Drawing.Point(235, 233);
            this.phieuMuonSachFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.phieuMuonSachFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.phieuMuonSachFrmBtn.Name = "phieuMuonSachFrmBtn";
            this.phieuMuonSachFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.phieuMuonSachFrmBtn.Size = new System.Drawing.Size(222, 132);
            this.phieuMuonSachFrmBtn.TabIndex = 1;
            this.phieuMuonSachFrmBtn.TabStop = false;
            this.phieuMuonSachFrmBtn.Text = "PHIẾU MƯỢN SÁCH";
            this.phieuMuonSachFrmBtn.Click += new System.EventHandler(this.phieuMuonSachFrmBtn_Click);
            // 
            // phieuThuTienFrmBtn
            // 
            this.phieuThuTienFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.phieuThuTienFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieuThuTienFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.phieuThuTienFrmBtn.Appearance.Options.UseBackColor = true;
            this.phieuThuTienFrmBtn.Appearance.Options.UseFont = true;
            this.phieuThuTienFrmBtn.Appearance.Options.UseForeColor = true;
            this.phieuThuTienFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.phieuThuTienFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phieuThuTienFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_purchase_order_64;
            this.phieuThuTienFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.phieuThuTienFrmBtn.Location = new System.Drawing.Point(5, 233);
            this.phieuThuTienFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.phieuThuTienFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.phieuThuTienFrmBtn.Name = "phieuThuTienFrmBtn";
            this.phieuThuTienFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.phieuThuTienFrmBtn.Size = new System.Drawing.Size(222, 132);
            this.phieuThuTienFrmBtn.TabIndex = 1;
            this.phieuThuTienFrmBtn.TabStop = false;
            this.phieuThuTienFrmBtn.Text = "PHIẾU THU TIỀN";
            this.phieuThuTienFrmBtn.Click += new System.EventHandler(this.phieuThuTienFrmBtn_Click);
            // 
            // docGiaFrmBtn
            // 
            this.docGiaFrmBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.docGiaFrmBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docGiaFrmBtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.docGiaFrmBtn.Appearance.Options.UseBackColor = true;
            this.docGiaFrmBtn.Appearance.Options.UseFont = true;
            this.docGiaFrmBtn.Appearance.Options.UseForeColor = true;
            this.docGiaFrmBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.docGiaFrmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docGiaFrmBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.docGiaFrmBtn.ImageOptions.Image = global::QLThuVien.Properties.Resources.icons8_name_tag_64;
            this.docGiaFrmBtn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.docGiaFrmBtn.Location = new System.Drawing.Point(2, 26);
            this.docGiaFrmBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.docGiaFrmBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.docGiaFrmBtn.Name = "docGiaFrmBtn";
            this.docGiaFrmBtn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.docGiaFrmBtn.Size = new System.Drawing.Size(458, 163);
            this.docGiaFrmBtn.TabIndex = 0;
            this.docGiaFrmBtn.TabStop = false;
            this.docGiaFrmBtn.Text = "ĐỌC GIẢ";
            this.docGiaFrmBtn.Click += new System.EventHandler(this.docGiaFrmBtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 557);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl userNameLabel;
        private DevExpress.XtraEditors.SimpleButton logOutBtn;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton docGiaFrmBtn;
        private DevExpress.XtraEditors.SimpleButton phieuMuonSachFrmBtn;
        private DevExpress.XtraEditors.SimpleButton phieuThuTienFrmBtn;
        private DevExpress.XtraEditors.SimpleButton sachFrmBtn;
        private DevExpress.XtraEditors.SimpleButton loaiSachFrmBtn;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton chucVuFrmBtn;
        private DevExpress.XtraEditors.SimpleButton nhanVienFrmBtn;
        private DevExpress.XtraEditors.SimpleButton thongTinDangNhapFrmBtn;
        private DevExpress.XtraEditors.SimpleButton exitMainFrmBtn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}