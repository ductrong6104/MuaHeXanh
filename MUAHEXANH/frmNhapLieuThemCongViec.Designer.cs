namespace MUAHEXANH.FrmChon
{
    partial class frmNhapLieuThemCongViec
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
            System.Windows.Forms.Label tenCVLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.txtTenCongViec = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.dtpNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.txtMaAp = new DevExpress.XtraEditors.TextEdit();
            this.txtTenAp = new DevExpress.XtraEditors.TextEdit();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            tenCVLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaAp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenAp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tenCVLabel
            // 
            tenCVLabel.AutoSize = true;
            tenCVLabel.Location = new System.Drawing.Point(32, 151);
            tenCVLabel.Name = "tenCVLabel";
            tenCVLabel.Size = new System.Drawing.Size(76, 13);
            tenCVLabel.TabIndex = 3;
            tenCVLabel.Text = "Tên công việc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 216);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 6;
            label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(259, 218);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 13);
            label2.TabIndex = 8;
            label2.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(67, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 13);
            label3.TabIndex = 9;
            label3.Text = "Mã ấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(63, 90);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 13);
            label4.TabIndex = 11;
            label4.Text = "Tên ấp";
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(114, 148);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(327, 22);
            this.txtTenCongViec.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.EditValue = null;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(114, 211);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBatDau.Size = new System.Drawing.Size(100, 22);
            this.dtpNgayBatDau.TabIndex = 5;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.EditValue = null;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(341, 213);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(100, 22);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // txtMaAp
            // 
            this.txtMaAp.Location = new System.Drawing.Point(114, 31);
            this.txtMaAp.Name = "txtMaAp";
            this.txtMaAp.Properties.ReadOnly = true;
            this.txtMaAp.Size = new System.Drawing.Size(327, 22);
            this.txtMaAp.TabIndex = 10;
            // 
            // txtTenAp
            // 
            this.txtTenAp.Location = new System.Drawing.Point(114, 87);
            this.txtTenAp.Name = "txtTenAp";
            this.txtTenAp.Properties.ReadOnly = true;
            this.txtTenAp.Size = new System.Drawing.Size(327, 22);
            this.txtTenAp.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Location = new System.Drawing.Point(196, 300);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(341, 300);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(89, 23);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmNhapLieuThemCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 374);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtTenAp);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtMaAp);
            this.Controls.Add(label2);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(label1);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(tenCVLabel);
            this.Controls.Add(this.txtTenCongViec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNhapLieuThemCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Công việc";
            this.Load += new System.EventHandler(this.frmNhapLieuThemCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaAp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenAp.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtTenCongViec;
        private DevExpress.XtraEditors.DateEdit dtpNgayBatDau;
        private DevExpress.XtraEditors.DateEdit dtpNgayKetThuc;
        private DevExpress.XtraEditors.TextEdit txtMaAp;
        private DevExpress.XtraEditors.TextEdit txtTenAp;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}