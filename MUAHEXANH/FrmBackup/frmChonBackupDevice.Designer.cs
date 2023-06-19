namespace MUAHEXANH
{
    partial class frmChonBackupDevice
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.gcBackupDevice = new DevExpress.XtraGrid.GridControl();
            this.gvBackupDevice = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackupDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Controls.Add(this.btnChon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 359);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 91);
            this.panelControl1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Location = new System.Drawing.Point(417, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 25);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(687, 40);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 25);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChon
            // 
            this.btnChon.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnChon.Appearance.Options.UseBackColor = true;
            this.btnChon.Location = new System.Drawing.Point(556, 40);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(101, 25);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // gcBackupDevice
            // 
            this.gcBackupDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBackupDevice.Location = new System.Drawing.Point(0, 0);
            this.gcBackupDevice.MainView = this.gvBackupDevice;
            this.gcBackupDevice.Name = "gcBackupDevice";
            this.gcBackupDevice.Size = new System.Drawing.Size(800, 359);
            this.gcBackupDevice.TabIndex = 1;
            this.gcBackupDevice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBackupDevice});
            // 
            // gvBackupDevice
            // 
            this.gvBackupDevice.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvBackupDevice.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBackupDevice.GridControl = this.gcBackupDevice;
            this.gvBackupDevice.Name = "gvBackupDevice";
            this.gvBackupDevice.OptionsBehavior.Editable = false;
            // 
            // frmChonBackupDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcBackupDevice);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChonBackupDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn thiết bị backup";
            this.Load += new System.EventHandler(this.frmChonBackupDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBackupDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraGrid.GridControl gcBackupDevice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBackupDevice;
        private DevExpress.XtraEditors.SimpleButton btnThem;
    }
}