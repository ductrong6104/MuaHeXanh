namespace MUAHEXANH.FormTaoTaiKhoanCuaKhoa
{
    partial class frmTaoTaiKhoanCuaKhoa
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
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.lblCHONHOTEN = new System.Windows.Forms.Label();
            this.cmbChonQuyen = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhapLaiMK = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.tgsHienAnMK = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsHienAnMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(258, 124);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(230, 24);
            this.cmbHoTen.TabIndex = 1;
            this.cmbHoTen.SelectionChangeCommitted += new System.EventHandler(this.cmbHoTen_SelectionChangeCommitted);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 187);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tài khoản";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 251);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 305);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(141, 20);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Xác nhận mật khẩu";
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(638, 182);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(150, 29);
            this.btnTao.TabIndex = 9;
            this.btnTao.Text = "Tạo";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // lblCHONHOTEN
            // 
            this.lblCHONHOTEN.AutoSize = true;
            this.lblCHONHOTEN.Location = new System.Drawing.Point(31, 127);
            this.lblCHONHOTEN.Name = "lblCHONHOTEN";
            this.lblCHONHOTEN.Size = new System.Drawing.Size(44, 16);
            this.lblCHONHOTEN.TabIndex = 13;
            this.lblCHONHOTEN.Text = "label1";
            // 
            // cmbChonQuyen
            // 
            this.cmbChonQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChonQuyen.FormattingEnabled = true;
            this.cmbChonQuyen.Items.AddRange(new object[] {
            "Giám sát",
            "Đội trưởng",
            "Đội phó",
            "Nhóm trưởng"});
            this.cmbChonQuyen.Location = new System.Drawing.Point(258, 71);
            this.cmbChonQuyen.Name = "cmbChonQuyen";
            this.cmbChonQuyen.Size = new System.Drawing.Size(230, 24);
            this.cmbChonQuyen.TabIndex = 17;
            this.cmbChonQuyen.SelectionChangeCommitted += new System.EventHandler(this.cmbChonQuyen_SelectionChangeCommitted);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 20);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Chọn quyền";
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(258, 302);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Properties.PasswordChar = '*';
            this.txtNhapLaiMK.Size = new System.Drawing.Size(230, 26);
            this.txtNhapLaiMK.TabIndex = 7;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(258, 245);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(230, 26);
            this.txtMatKhau.TabIndex = 6;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(258, 184);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(230, 26);
            this.txtTaiKhoan.TabIndex = 5;
            // 
            // tgsHienAnMK
            // 
            this.tgsHienAnMK.Location = new System.Drawing.Point(505, 246);
            this.tgsHienAnMK.Name = "tgsHienAnMK";
            this.tgsHienAnMK.Properties.OffText = "Off";
            this.tgsHienAnMK.Properties.OnText = "On";
            this.tgsHienAnMK.Size = new System.Drawing.Size(106, 25);
            this.tgsHienAnMK.TabIndex = 19;
            this.tgsHienAnMK.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // frmTaoTaiKhoanCuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.tgsHienAnMK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbChonQuyen);
            this.Controls.Add(this.lblCHONHOTEN);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbHoTen);
            this.Name = "frmTaoTaiKhoanCuaKhoa";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frmTaoTaiKhoanCuaKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgsHienAnMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtNhapLaiMK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnTao;
        private System.Windows.Forms.Label lblCHONHOTEN;
        private System.Windows.Forms.ComboBox cmbChonQuyen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private DevExpress.XtraEditors.ToggleSwitch tgsHienAnMK;
    }
}