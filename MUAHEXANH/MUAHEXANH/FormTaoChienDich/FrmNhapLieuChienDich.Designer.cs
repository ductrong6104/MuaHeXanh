namespace MUAHEXANH
{
    partial class FrmNhapLieuChienDich
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
            this.txtTenChienDich = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgayPhatDong = new DevExpress.XtraEditors.DateEdit();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.dtpNgayKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChienDich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayPhatDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayPhatDong.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenChienDich
            // 
            this.txtTenChienDich.Location = new System.Drawing.Point(161, 26);
            this.txtTenChienDich.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenChienDich.Name = "txtTenChienDich";
            this.txtTenChienDich.Size = new System.Drawing.Size(320, 26);
            this.txtTenChienDich.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 29);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên chiến dịch";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Location = new System.Drawing.Point(224, 219);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 31);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(114, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày phát động";
            // 
            // dtpNgayPhatDong
            // 
            this.dtpNgayPhatDong.EditValue = null;
            this.dtpNgayPhatDong.Location = new System.Drawing.Point(161, 82);
            this.dtpNgayPhatDong.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayPhatDong.Name = "dtpNgayPhatDong";
            this.dtpNgayPhatDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayPhatDong.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayPhatDong.Size = new System.Drawing.Size(320, 26);
            this.dtpNgayPhatDong.TabIndex = 4;
            this.dtpNgayPhatDong.EditValueChanged += new System.EventHandler(this.dtpNgayPhatDong_EditValueChanged);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(376, 219);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 31);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.EditValue = null;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(161, 142);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(320, 26);
            this.dtpNgayKetThuc.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 145);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(101, 20);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ngày kết thúc";
            // 
            // FrmNhapLieuChienDich
            // 
            this.AcceptButton = this.btnLuu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(493, 277);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dtpNgayPhatDong);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTenChienDich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNhapLieuChienDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chiến dịch";
            this.Load += new System.EventHandler(this.FrmNhapLieuChienDich_Load);
            this.Shown += new System.EventHandler(this.FrmNhapLieuChienDich_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenChienDich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayPhatDong.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayPhatDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKetThuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtTenChienDich;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpNgayPhatDong;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.DateEdit dtpNgayKetThuc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}