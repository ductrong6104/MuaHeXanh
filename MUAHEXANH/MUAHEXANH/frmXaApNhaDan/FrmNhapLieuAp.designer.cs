namespace MUAHEXANH.FormXaAp
{
    partial class FrmNhapLieuAp
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
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenXa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenDiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDiaBan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaXa = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenAp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenAp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(292, 340);
            this.btnDong.Margin = new System.Windows.Forms.Padding(6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(112, 28);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Location = new System.Drawing.Point(78, 340);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 28);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenXa
            // 
            this.txtTenXa.Location = new System.Drawing.Point(138, 194);
            this.txtTenXa.Margin = new System.Windows.Forms.Padding(8);
            this.txtTenXa.Name = "txtTenXa";
            this.txtTenXa.Properties.ReadOnly = true;
            this.txtTenXa.Size = new System.Drawing.Size(266, 26);
            this.txtTenXa.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 197);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 20);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Tên xã";
            // 
            // txtTenDiaBan
            // 
            this.txtTenDiaBan.Location = new System.Drawing.Point(138, 84);
            this.txtTenDiaBan.Margin = new System.Windows.Forms.Padding(6);
            this.txtTenDiaBan.Name = "txtTenDiaBan";
            this.txtTenDiaBan.Properties.ReadOnly = true;
            this.txtTenDiaBan.Size = new System.Drawing.Size(266, 26);
            this.txtTenDiaBan.TabIndex = 14;
            // 
            // txtMaDiaBan
            // 
            this.txtMaDiaBan.Location = new System.Drawing.Point(138, 29);
            this.txtMaDiaBan.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaDiaBan.Name = "txtMaDiaBan";
            this.txtMaDiaBan.Properties.ReadOnly = true;
            this.txtMaDiaBan.Size = new System.Drawing.Size(195, 26);
            this.txtMaDiaBan.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 87);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 20);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Tên địa bàn";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 20);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Mã địa bàn";
            // 
            // txtMaXa
            // 
            this.txtMaXa.Location = new System.Drawing.Point(138, 137);
            this.txtMaXa.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaXa.Name = "txtMaXa";
            this.txtMaXa.Properties.ReadOnly = true;
            this.txtMaXa.Size = new System.Drawing.Size(195, 26);
            this.txtMaXa.TabIndex = 20;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 140);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 20);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Mã xã";
            // 
            // txtTenAp
            // 
            this.txtTenAp.Location = new System.Drawing.Point(138, 252);
            this.txtTenAp.Margin = new System.Windows.Forms.Padding(8);
            this.txtTenAp.Name = "txtTenAp";
            this.txtTenAp.Size = new System.Drawing.Size(266, 26);
            this.txtTenAp.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(26, 255);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 20);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Tên ấp";
            // 
            // FrmNhapLieuAp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 400);
            this.Controls.Add(this.txtTenAp);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMaXa);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenXa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTenDiaBan);
            this.Controls.Add(this.txtMaDiaBan);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmNhapLieuAp";
            this.Text = "FrmNhapLieuAp";
            this.Load += new System.EventHandler(this.FrmNhapLieuAp_Load);
            this.Shown += new System.EventHandler(this.FrmNhapLieuAp_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenAp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtTenXa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTenDiaBan;
        private DevExpress.XtraEditors.TextEdit txtMaDiaBan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaXa;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenAp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}