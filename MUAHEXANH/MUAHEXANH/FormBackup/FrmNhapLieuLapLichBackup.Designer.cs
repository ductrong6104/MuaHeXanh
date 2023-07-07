namespace MUAHEXANH.FormBackup
{
    partial class FrmNhapLieuLapLichBackup
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
            this.cmbLoaiBackup = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDonViChuKi = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.speGiaTriChuKi = new DevExpress.XtraEditors.SpinEdit();
            this.teThoiGianBatDau = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chckEnable = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnChonBackupDevice = new DevExpress.XtraEditors.SimpleButton();
            this.txtBackupDevice = new DevExpress.XtraEditors.TextEdit();
            this.btnChonLogFile = new DevExpress.XtraEditors.SimpleButton();
            this.txtLogFile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.speGiaTriChuKi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThoiGianBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckEnable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupDevice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogFile.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Loại backup";
            // 
            // cmbLoaiBackup
            // 
            this.cmbLoaiBackup.FormattingEnabled = true;
            this.cmbLoaiBackup.Location = new System.Drawing.Point(151, 25);
            this.cmbLoaiBackup.Name = "cmbLoaiBackup";
            this.cmbLoaiBackup.Size = new System.Drawing.Size(397, 24);
            this.cmbLoaiBackup.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 206);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Đơn vị chu kì";
            // 
            // cmbDonViChuKi
            // 
            this.cmbDonViChuKi.FormattingEnabled = true;
            this.cmbDonViChuKi.Location = new System.Drawing.Point(151, 206);
            this.cmbDonViChuKi.Name = "cmbDonViChuKi";
            this.cmbDonViChuKi.Size = new System.Drawing.Size(164, 24);
            this.cmbDonViChuKi.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 253);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Giá trị chu kì";
            // 
            // speGiaTriChuKi
            // 
            this.speGiaTriChuKi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speGiaTriChuKi.Location = new System.Drawing.Point(151, 250);
            this.speGiaTriChuKi.Name = "speGiaTriChuKi";
            this.speGiaTriChuKi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speGiaTriChuKi.Size = new System.Drawing.Size(164, 26);
            this.speGiaTriChuKi.TabIndex = 6;
            // 
            // teThoiGianBatDau
            // 
            this.teThoiGianBatDau.EditValue = new System.DateTime(2023, 7, 6, 0, 0, 0, 0);
            this.teThoiGianBatDau.Location = new System.Drawing.Point(151, 300);
            this.teThoiGianBatDau.Name = "teThoiGianBatDau";
            this.teThoiGianBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.teThoiGianBatDau.Size = new System.Drawing.Size(164, 26);
            this.teThoiGianBatDau.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 303);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 20);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Thời gian";
            // 
            // chckEnable
            // 
            this.chckEnable.Location = new System.Drawing.Point(151, 360);
            this.chckEnable.Name = "chckEnable";
            this.chckEnable.Properties.Caption = "Enable";
            this.chckEnable.Size = new System.Drawing.Size(94, 24);
            this.chckEnable.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 20);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Backup device";
            // 
            // btnChonBackupDevice
            // 
            this.btnChonBackupDevice.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnChonBackupDevice.Appearance.Options.UseBackColor = true;
            this.btnChonBackupDevice.Location = new System.Drawing.Point(443, 81);
            this.btnChonBackupDevice.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonBackupDevice.Name = "btnChonBackupDevice";
            this.btnChonBackupDevice.Size = new System.Drawing.Size(105, 31);
            this.btnChonBackupDevice.TabIndex = 12;
            this.btnChonBackupDevice.Text = "Chọn";
            // 
            // txtBackupDevice
            // 
            this.txtBackupDevice.Location = new System.Drawing.Point(151, 84);
            this.txtBackupDevice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupDevice.Name = "txtBackupDevice";
            this.txtBackupDevice.Properties.ReadOnly = true;
            this.txtBackupDevice.Size = new System.Drawing.Size(269, 26);
            this.txtBackupDevice.TabIndex = 11;
            // 
            // btnChonLogFile
            // 
            this.btnChonLogFile.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnChonLogFile.Appearance.Options.UseBackColor = true;
            this.btnChonLogFile.Location = new System.Drawing.Point(443, 146);
            this.btnChonLogFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonLogFile.Name = "btnChonLogFile";
            this.btnChonLogFile.Size = new System.Drawing.Size(105, 31);
            this.btnChonLogFile.TabIndex = 15;
            this.btnChonLogFile.Text = "Chọn";
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(151, 149);
            this.txtLogFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Properties.ReadOnly = true;
            this.txtLogFile.Size = new System.Drawing.Size(269, 26);
            this.txtLogFile.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(25, 152);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 20);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Log file";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(443, 433);
            this.btnDong.Margin = new System.Windows.Forms.Padding(5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 31);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Location = new System.Drawing.Point(315, 433);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 31);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            // 
            // FrmNhapLieuLapLichBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 487);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChonLogFile);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnChonBackupDevice);
            this.Controls.Add(this.txtBackupDevice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.chckEnable);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.teThoiGianBatDau);
            this.Controls.Add(this.speGiaTriChuKi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbDonViChuKi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbLoaiBackup);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmNhapLieuLapLichBackup";
            this.Text = "FrmLapLichBackup";
            ((System.ComponentModel.ISupportInitialize)(this.speGiaTriChuKi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teThoiGianBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckEnable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupDevice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogFile.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbLoaiBackup;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbDonViChuKi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit speGiaTriChuKi;
        private DevExpress.XtraEditors.TimeEdit teThoiGianBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.CheckEdit chckEnable;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnChonBackupDevice;
        private DevExpress.XtraEditors.TextEdit txtBackupDevice;
        private DevExpress.XtraEditors.SimpleButton btnChonLogFile;
        private DevExpress.XtraEditors.TextEdit txtLogFile;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}