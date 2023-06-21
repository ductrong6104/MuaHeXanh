namespace MUAHEXANH.FrmChon
{
    partial class FrmChonAp
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbXa = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDiaBan = new System.Windows.Forms.ComboBox();
            this.dSChonAp = new MUAHEXANH.DSChonAp();
            this.bdsDiaBan = new System.Windows.Forms.BindingSource(this.components);
            this.diaBanTableAdapter = new MUAHEXANH.DSChonApTableAdapters.DiaBanTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSChonApTableAdapters.TableAdapterManager();
            this.apTableAdapter = new MUAHEXANH.DSChonApTableAdapters.ApTableAdapter();
            this.xaTableAdapter = new MUAHEXANH.DSChonApTableAdapters.XaTableAdapter();
            this.bdsXa = new System.Windows.Forms.BindingSource(this.components);
            this.bdsAp = new System.Windows.Forms.BindingSource(this.components);
            this.apGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvAp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenAp = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSChonAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnChon);
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 643);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 74);
            this.panelControl1.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChon.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnChon.Appearance.Options.UseBackColor = true;
            this.btnChon.Location = new System.Drawing.Point(500, 20);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(106, 34);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnDong.Appearance.Options.UseBackColor = true;
            this.btnDong.Location = new System.Drawing.Point(664, 20);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(106, 34);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.cmbXa);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.cmbDiaBan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(800, 85);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(463, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Xã";
            // 
            // cmbXa
            // 
            this.cmbXa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbXa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXa.FormattingEnabled = true;
            this.cmbXa.Location = new System.Drawing.Point(500, 31);
            this.cmbXa.Name = "cmbXa";
            this.cmbXa.Size = new System.Drawing.Size(253, 24);
            this.cmbXa.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(54, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Địa bàn";
            // 
            // cmbDiaBan
            // 
            this.cmbDiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDiaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaBan.FormattingEnabled = true;
            this.cmbDiaBan.Location = new System.Drawing.Point(116, 31);
            this.cmbDiaBan.Name = "cmbDiaBan";
            this.cmbDiaBan.Size = new System.Drawing.Size(262, 24);
            this.cmbDiaBan.TabIndex = 0;
            // 
            // dSChonAp
            // 
            this.dSChonAp.DataSetName = "DSChonAp";
            this.dSChonAp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDiaBan
            // 
            this.bdsDiaBan.DataMember = "DiaBan";
            this.bdsDiaBan.DataSource = this.dSChonAp;
            // 
            // diaBanTableAdapter
            // 
            this.diaBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = this.apTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiaBanTableAdapter = this.diaBanTableAdapter;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSChonApTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = this.xaTableAdapter;
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // xaTableAdapter
            // 
            this.xaTableAdapter.ClearBeforeFill = true;
            // 
            // bdsXa
            // 
            this.bdsXa.DataMember = "FK_Xa_DiaBan";
            this.bdsXa.DataSource = this.bdsDiaBan;
            // 
            // bdsAp
            // 
            this.bdsAp.DataMember = "FK_Ap_Xa";
            this.bdsAp.DataSource = this.bdsXa;
            // 
            // apGridControl
            // 
            this.apGridControl.DataSource = this.bdsAp;
            this.apGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apGridControl.Location = new System.Drawing.Point(0, 85);
            this.apGridControl.MainView = this.gvAp;
            this.apGridControl.Name = "apGridControl";
            this.apGridControl.Size = new System.Drawing.Size(800, 558);
            this.apGridControl.TabIndex = 3;
            this.apGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAp});
            this.apGridControl.Click += new System.EventHandler(this.apGridControl_Click);
            // 
            // gvAp
            // 
            this.gvAp.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvAp.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAp.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gvAp.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAp.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAp.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvAp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaAp,
            this.colTenAp});
            this.gvAp.GridControl = this.apGridControl;
            this.gvAp.Name = "gvAp";
            this.gvAp.OptionsBehavior.Editable = false;
            this.gvAp.OptionsView.ShowGroupPanel = false;
            // 
            // colMaAp
            // 
            this.colMaAp.Caption = "Mã ấp";
            this.colMaAp.FieldName = "MaAp";
            this.colMaAp.Name = "colMaAp";
            this.colMaAp.Visible = true;
            this.colMaAp.VisibleIndex = 0;
            this.colMaAp.Width = 126;
            // 
            // colTenAp
            // 
            this.colTenAp.Caption = "Tên ấp";
            this.colTenAp.FieldName = "TenAp";
            this.colTenAp.Name = "colTenAp";
            this.colTenAp.Visible = true;
            this.colTenAp.VisibleIndex = 1;
            this.colTenAp.Width = 649;
            // 
            // FrmChonAp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 717);
            this.Controls.Add(this.apGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmChonAp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmChonAp";
            this.Load += new System.EventHandler(this.FrmChonAp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSChonAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DSChonAp dSChonAp;
        private System.Windows.Forms.BindingSource bdsDiaBan;
        private DSChonApTableAdapters.DiaBanTableAdapter diaBanTableAdapter;
        private DSChonApTableAdapters.TableAdapterManager tableAdapterManager;
        private DSChonApTableAdapters.XaTableAdapter xaTableAdapter;
        private System.Windows.Forms.BindingSource bdsXa;
        private DSChonApTableAdapters.ApTableAdapter apTableAdapter;
        private System.Windows.Forms.BindingSource bdsAp;
        private DevExpress.XtraGrid.GridControl apGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAp;
        private DevExpress.XtraGrid.Columns.GridColumn colMaAp;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbXa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbDiaBan;
    }
}