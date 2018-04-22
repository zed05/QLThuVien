namespace QLThuVien
{
    partial class LoginFrm
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.exitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.emailLoginTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.passLoginTxt = new DevExpress.XtraEditors.TextEdit();
            this.submitBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.emailLoginTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passLoginTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(85, 84);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 40);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đăng nhập";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // exitBtn
            // 
            this.exitBtn.Appearance.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Appearance.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Appearance.Options.UseFont = true;
            this.exitBtn.Appearance.Options.UseForeColor = true;
            this.exitBtn.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(20)))), ((int)(((byte)(12)))));
            this.exitBtn.AppearanceHovered.Options.UseFont = true;
            this.exitBtn.AppearanceHovered.Options.UseForeColor = true;
            this.exitBtn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.AppearancePressed.Options.UseFont = true;
            this.exitBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.exitBtn.Location = new System.Drawing.Point(491, 27);
            this.exitBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(40, 48);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // emailLoginTxt
            // 
            this.emailLoginTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailLoginTxt.Location = new System.Drawing.Point(85, 263);
            this.emailLoginTxt.Name = "emailLoginTxt";
            this.emailLoginTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLoginTxt.Properties.Appearance.Options.UseFont = true;
            this.emailLoginTxt.Size = new System.Drawing.Size(387, 30);
            this.emailLoginTxt.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(85, 224);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Email:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(83, 326);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Password:";
            // 
            // passLoginTxt
            // 
            this.passLoginTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passLoginTxt.Location = new System.Drawing.Point(83, 365);
            this.passLoginTxt.Name = "passLoginTxt";
            this.passLoginTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLoginTxt.Properties.Appearance.Options.UseFont = true;
            this.passLoginTxt.Properties.PasswordChar = '*';
            this.passLoginTxt.Size = new System.Drawing.Size(389, 30);
            this.passLoginTxt.TabIndex = 2;
            // 
            // submitBtn
            // 
            this.submitBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(196)))), ((int)(((byte)(133)))));
            this.submitBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Appearance.Options.UseBackColor = true;
            this.submitBtn.Appearance.Options.UseFont = true;
            this.submitBtn.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(166)))));
            this.submitBtn.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.AppearanceHovered.Options.UseBackColor = true;
            this.submitBtn.AppearanceHovered.Options.UseFont = true;
            this.submitBtn.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(143)))), ((int)(((byte)(97)))));
            this.submitBtn.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.AppearancePressed.Options.UseBackColor = true;
            this.submitBtn.AppearancePressed.Options.UseFont = true;
            this.submitBtn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.Location = new System.Drawing.Point(83, 476);
            this.submitBtn.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(196)))), ((int)(((byte)(133)))));
            this.submitBtn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.submitBtn.LookAndFeel.UseDefaultLookAndFeel = false;
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(389, 56);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Đăng nhập";
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // LoginFrm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 720);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.passLoginTxt);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.emailLoginTxt);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "LoginFrm";
            this.Padding = new System.Windows.Forms.Padding(80);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.emailLoginTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passLoginTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        public DevExpress.XtraEditors.SimpleButton exitBtn;
        public DevExpress.XtraEditors.TextEdit emailLoginTxt;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit passLoginTxt;
        public DevExpress.XtraEditors.SimpleButton submitBtn;
    }
}