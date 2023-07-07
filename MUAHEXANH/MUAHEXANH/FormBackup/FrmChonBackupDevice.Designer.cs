namespace MUAHEXANH
{
    partial class FrmChonBackupDevice
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
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Controls.Add(this.btnChon);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 442);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(988, 74);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(859, 26);
            this.btnDong.Margin = new System.Windows.Forms.Padding(5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 31);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnChon
            // 
            this.btnChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChon.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnChon.Appearance.Options.UseBackColor = true;
            this.btnChon.Location = new System.Drawing.Point(731, 26);
            this.btnChon.Margin = new System.Windows.Forms.Padding(5);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(105, 31);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // gcBackupDevice
            // 
            this.gcBackupDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBackupDevice.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcBackupDevice.Location = new System.Drawing.Point(0, 0);
            this.gcBackupDevice.MainView = this.gvBackupDevice;
            this.gcBackupDevice.Margin = new System.Windows.Forms.Padding(5);
            this.gcBackupDevice.Name = "gcBackupDevice";
            this.gcBackupDevice.Size = new System.Drawing.Size(988, 442);
            this.gcBackupDevice.TabIndex = 1;
            this.gcBackupDevice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBackupDevice});
            // 
            // gvBackupDevice
            // 
            this.gvBackupDevice.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvBackupDevice.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBackupDevice.DetailHeight = 539;
            this.gvBackupDevice.GridControl = this.gcBackupDevice;
            this.gvBackupDevice.Name = "gvBackupDevice";
            this.gvBackupDevice.OptionsBehavior.Editable = false;
            // 
            // FrmChonBackupDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 516);
            this.Controls.Add(this.gcBackupDevice);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmChonBackupDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chọn thiết bị backup";
            this.Load += new System.EventHandler(this.frmChonBackupDevice_Load);
            this.Shown += new System.EventHandler(this.FrmChonBackupDevice_Shown);
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
    }
}