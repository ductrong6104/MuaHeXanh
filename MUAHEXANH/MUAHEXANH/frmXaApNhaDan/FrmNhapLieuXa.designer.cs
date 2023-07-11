namespace MUAHEXANH.FormXaAp
{
    partial class FrmNhapLieuXa
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaDiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtTenXa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 36);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã địa bàn";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 102);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 20);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên địa bàn";
            // 
            // txtMaDiaBan
            // 
            this.txtMaDiaBan.Location = new System.Drawing.Point(147, 33);
            this.txtMaDiaBan.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaDiaBan.Name = "txtMaDiaBan";
            this.txtMaDiaBan.Properties.ReadOnly = true;
            this.txtMaDiaBan.Size = new System.Drawing.Size(195, 26);
            this.txtMaDiaBan.TabIndex = 2;
            // 
            // txtTenDiaBan
            // 
            this.txtTenDiaBan.Location = new System.Drawing.Point(147, 99);
            this.txtTenDiaBan.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenDiaBan.Name = "txtTenDiaBan";
            this.txtTenDiaBan.Properties.ReadOnly = true;
            this.txtTenDiaBan.Size = new System.Drawing.Size(266, 26);
            this.txtTenDiaBan.TabIndex = 3;
            // 
            // txtTenXa
            // 
            this.txtTenXa.Location = new System.Drawing.Point(147, 161);
            this.txtTenXa.Margin = new System.Windows.Forms.Padding(8);
            this.txtTenXa.Name = "txtTenXa";
            this.txtTenXa.Size = new System.Drawing.Size(266, 26);
            this.txtTenXa.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 164);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 20);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên xã";
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(287, 245);
            this.btnDong.Margin = new System.Windows.Forms.Padding(6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 28);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Location = new System.Drawing.Point(73, 245);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 28);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmNhapLieuXa
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 306);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenXa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTenDiaBan);
            this.Controls.Add(this.txtMaDiaBan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNhapLieuXa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmNhapLieuXa_Load);
            this.Shown += new System.EventHandler(this.FrmNhapLieuXa_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaDiaBan;
        private DevExpress.XtraEditors.TextEdit txtTenDiaBan;
        private DevExpress.XtraEditors.TextEdit txtTenXa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}