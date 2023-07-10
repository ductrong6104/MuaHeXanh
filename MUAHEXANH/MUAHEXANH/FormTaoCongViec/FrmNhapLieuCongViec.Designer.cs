namespace MUAHEXANH.FrmChon
{
    partial class FrmNhapLieuCongViec
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
            tenCVLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            tenCVLabel.Location = new System.Drawing.Point(27, 149);
            tenCVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tenCVLabel.Name = "tenCVLabel";
            tenCVLabel.Size = new System.Drawing.Size(111, 20);
            tenCVLabel.TabIndex = 3;
            tenCVLabel.Text = "Tên công việc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            label1.Location = new System.Drawing.Point(27, 199);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 20);
            label1.TabIndex = 6;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            label2.Location = new System.Drawing.Point(344, 199);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            label3.Location = new System.Drawing.Point(27, 41);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 20);
            label3.TabIndex = 9;
            label3.Text = "Mã ấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            label4.Location = new System.Drawing.Point(27, 97);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 20);
            label4.TabIndex = 11;
            label4.Text = "Tên ấp";
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(152, 146);
            this.txtTenCongViec.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(436, 26);
            this.txtTenCongViec.TabIndex = 4;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.EditValue = null;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(152, 196);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayBatDau.Size = new System.Drawing.Size(133, 26);
            this.dtpNgayBatDau.TabIndex = 5;
            this.dtpNgayBatDau.EditValueChanged += new System.EventHandler(this.dtpNgayBatDau_EditValueChanged);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.EditValue = null;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(455, 196);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(133, 26);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // txtMaAp
            // 
            this.txtMaAp.Location = new System.Drawing.Point(152, 38);
            this.txtMaAp.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaAp.Name = "txtMaAp";
            this.txtMaAp.Properties.ReadOnly = true;
            this.txtMaAp.Size = new System.Drawing.Size(436, 26);
            this.txtMaAp.TabIndex = 10;
            // 
            // txtTenAp
            // 
            this.txtTenAp.Location = new System.Drawing.Point(152, 94);
            this.txtTenAp.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenAp.Name = "txtTenAp";
            this.txtTenAp.Properties.ReadOnly = true;
            this.txtTenAp.Size = new System.Drawing.Size(436, 26);
            this.txtTenAp.TabIndex = 12;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Location = new System.Drawing.Point(348, 292);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 31);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(483, 292);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 31);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmNhapLieuCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 345);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhapLieuCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Công việc";
            this.Load += new System.EventHandler(this.frmNhapLieuThemCongViec_Load);
            this.Shown += new System.EventHandler(this.FrmNhapLieuCongViec_Shown);
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