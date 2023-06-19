namespace MUAHEXANH
{
    partial class frmDangNhap
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
            this.radSinhVien = new System.Windows.Forms.RadioButton();
            this.radGiangVien = new System.Windows.Forms.RadioButton();
            this.btnQuenMK = new DevExpress.XtraEditors.SimpleButton();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSinhVien
            // 
            this.radSinhVien.AutoSize = true;
            this.radSinhVien.Location = new System.Drawing.Point(352, 29);
            this.radSinhVien.Name = "radSinhVien";
            this.radSinhVien.Size = new System.Drawing.Size(82, 20);
            this.radSinhVien.TabIndex = 24;
            this.radSinhVien.TabStop = true;
            this.radSinhVien.Text = "Sinh Viên";
            this.radSinhVien.UseVisualStyleBackColor = true;
            // 
            // radGiangVien
            // 
            this.radGiangVien.AutoSize = true;
            this.radGiangVien.Checked = true;
            this.radGiangVien.Location = new System.Drawing.Point(195, 29);
            this.radGiangVien.Name = "radGiangVien";
            this.radGiangVien.Size = new System.Drawing.Size(87, 20);
            this.radGiangVien.TabIndex = 23;
            this.radGiangVien.TabStop = true;
            this.radGiangVien.Text = "Giảng viên";
            this.radGiangVien.UseVisualStyleBackColor = true;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuenMK.Location = new System.Drawing.Point(384, 226);
            this.btnQuenMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(194, 36);
            this.btnQuenMK.TabIndex = 25;
            this.btnQuenMK.Text = "Quên mật khẩu";
            // 
            // txtLogin
            // 
            this.txtLogin.EditValue = "N20DCCN079";
            this.txtLogin.Location = new System.Drawing.Point(89, 91);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(489, 26);
            this.txtLogin.TabIndex = 19;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(89, 226);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 36);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.EditValue = "1";
            this.txtPass.Location = new System.Drawing.Point(89, 155);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(489, 26);
            this.txtPass.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 94);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 20);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Tài khoản";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 158);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(69, 20);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.radGiangVien);
            this.panelControl1.Controls.Add(this.radSinhVien);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnQuenMK);
            this.panelControl1.Controls.Add(this.txtPass);
            this.panelControl1.Controls.Add(this.txtLogin);
            this.panelControl1.Controls.Add(this.btnLogin);
            this.panelControl1.Location = new System.Drawing.Point(92, 45);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(614, 337);
            this.panelControl1.TabIndex = 26;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radSinhVien;
        private System.Windows.Forms.RadioButton radGiangVien;
        private DevExpress.XtraEditors.SimpleButton btnQuenMK;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}