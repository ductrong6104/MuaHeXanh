namespace MUAHEXANH
{
    partial class FrmRestore
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
            this.btnChonBackupDevice = new DevExpress.XtraEditors.SimpleButton();
            this.txtBackupDeviceName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnButton = new DevExpress.XtraEditors.PanelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcBackupFile = new DevExpress.XtraGrid.GridControl();
            this.gvBackupFile = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupDeviceName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnButton)).BeginInit();
            this.pnButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBackupFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupFile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnChonBackupDevice);
            this.panelControl1.Controls.Add(this.txtBackupDeviceName);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1146, 116);
            this.panelControl1.TabIndex = 0;
            // 
            // btnChonBackupDevice
            // 
            this.btnChonBackupDevice.Location = new System.Drawing.Point(636, 39);
            this.btnChonBackupDevice.Margin = new System.Windows.Forms.Padding(6);
            this.btnChonBackupDevice.Name = "btnChonBackupDevice";
            this.btnChonBackupDevice.Size = new System.Drawing.Size(105, 31);
            this.btnChonBackupDevice.TabIndex = 5;
            this.btnChonBackupDevice.Text = "Chọn";
            this.btnChonBackupDevice.Click += new System.EventHandler(this.btnChonBackupDevice_Click);
            // 
            // txtBackupDeviceName
            // 
            this.txtBackupDeviceName.Location = new System.Drawing.Point(162, 42);
            this.txtBackupDeviceName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBackupDeviceName.Name = "txtBackupDeviceName";
            this.txtBackupDeviceName.Size = new System.Drawing.Size(449, 26);
            this.txtBackupDeviceName.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 45);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(106, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Backup device";
            // 
            // pnButton
            // 
            this.pnButton.Controls.Add(this.btnDong);
            this.pnButton.Controls.Add(this.btnRestore);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButton.Location = new System.Drawing.Point(0, 493);
            this.pnButton.Margin = new System.Windows.Forms.Padding(4);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(1146, 69);
            this.pnButton.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(1017, 22);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(105, 31);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnRestore.Appearance.Options.UseBackColor = true;
            this.btnRestore.Location = new System.Drawing.Point(850, 22);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(105, 31);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcBackupFile);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 116);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1146, 377);
            this.panelControl3.TabIndex = 2;
            // 
            // gcBackupFile
            // 
            this.gcBackupFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBackupFile.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(15);
            this.gcBackupFile.Location = new System.Drawing.Point(2, 2);
            this.gcBackupFile.MainView = this.gvBackupFile;
            this.gcBackupFile.Margin = new System.Windows.Forms.Padding(15);
            this.gcBackupFile.Name = "gcBackupFile";
            this.gcBackupFile.Size = new System.Drawing.Size(1142, 373);
            this.gcBackupFile.TabIndex = 3;
            this.gcBackupFile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBackupFile});
            // 
            // gvBackupFile
            // 
            this.gvBackupFile.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvBackupFile.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBackupFile.DetailHeight = 1644;
            this.gvBackupFile.GridControl = this.gcBackupFile;
            this.gvBackupFile.Name = "gvBackupFile";
            this.gvBackupFile.OptionsBehavior.Editable = false;
            this.gvBackupFile.OptionsView.ShowGroupPanel = false;
            // 
            // FrmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 562);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmRestore";
            this.Text = "frmRestore";
            this.Load += new System.EventHandler(this.FrmRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBackupDeviceName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnButton)).EndInit();
            this.pnButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBackupFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBackupFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChonBackupDevice;
        private DevExpress.XtraEditors.TextEdit txtBackupDeviceName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnButton;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gcBackupFile;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBackupFile;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
    }
}