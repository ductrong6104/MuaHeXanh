namespace MUAHEXANH
{
    partial class FrmBackup
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
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txtBackupDevice = new DevExpress.XtraEditors.TextEdit();
            this.lbUrl = new DevExpress.XtraEditors.LabelControl();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnChonBackupDevice = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupDevice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 51);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Loại Backup";
            // 
            // cmbLoai
            // 
            this.cmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(134, 51);
            this.cmbLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(409, 24);
            this.cmbLoai.TabIndex = 1;
            // 
            // txtBackupDevice
            // 
            this.txtBackupDevice.Location = new System.Drawing.Point(134, 158);
            this.txtBackupDevice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBackupDevice.Name = "txtBackupDevice";
            this.txtBackupDevice.Properties.ReadOnly = true;
            this.txtBackupDevice.Size = new System.Drawing.Size(284, 26);
            this.txtBackupDevice.TabIndex = 5;
            // 
            // lbUrl
            // 
            this.lbUrl.Location = new System.Drawing.Point(19, 161);
            this.lbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(106, 20);
            this.lbUrl.TabIndex = 6;
            this.lbUrl.Text = "Backup device";
            // 
            // btnBackup
            // 
            this.btnBackup.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnBackup.Appearance.Options.UseBackColor = true;
            this.btnBackup.Location = new System.Drawing.Point(285, 263);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(105, 31);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(438, 263);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 31);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChonBackupDevice
            // 
            this.btnChonBackupDevice.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnChonBackupDevice.Appearance.Options.UseBackColor = true;
            this.btnChonBackupDevice.Location = new System.Drawing.Point(438, 155);
            this.btnChonBackupDevice.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonBackupDevice.Name = "btnChonBackupDevice";
            this.btnChonBackupDevice.Size = new System.Drawing.Size(105, 31);
            this.btnChonBackupDevice.TabIndex = 9;
            this.btnChonBackupDevice.Text = "Chọn";
            this.btnChonBackupDevice.Click += new System.EventHandler(this.btnChonBackupDevice_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 338);
            this.Controls.Add(this.btnChonBackupDevice);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.txtBackupDevice);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.Shown += new System.EventHandler(this.frmBackup_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupDevice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbLoai;
        private DevExpress.XtraEditors.TextEdit txtBackupDevice;
        private DevExpress.XtraEditors.LabelControl lbUrl;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnChonBackupDevice;
    }
}