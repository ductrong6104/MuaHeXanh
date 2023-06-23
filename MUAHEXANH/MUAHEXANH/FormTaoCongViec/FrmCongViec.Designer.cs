namespace MUAHEXANH
{
    partial class FrmCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCongViec));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbXa = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbDiaBan = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbChonAp = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dSTaoCongViec = new MUAHEXANH.DSTaoCongViec();
            this.bdsDiaBan = new System.Windows.Forms.BindingSource(this.components);
            this.diaBanTableAdapter = new MUAHEXANH.DSTaoCongViecTableAdapters.DiaBanTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSTaoCongViecTableAdapters.TableAdapterManager();
            this.apTableAdapter = new MUAHEXANH.DSTaoCongViecTableAdapters.ApTableAdapter();
            this.congViecTableAdapter = new MUAHEXANH.DSTaoCongViecTableAdapters.CongViecTableAdapter();
            this.phanCongTableAdapter = new MUAHEXANH.DSTaoCongViecTableAdapters.PhanCongTableAdapter();
            this.xaTableAdapter = new MUAHEXANH.DSTaoCongViecTableAdapters.XaTableAdapter();
            this.bdsXa = new System.Windows.Forms.BindingSource(this.components);
            this.bdsAp = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCongViec = new System.Windows.Forms.BindingSource(this.components);
            this.congViecGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvAp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsPhanCong = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSTaoCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnXoa,
            this.btnReload});
            this.barManager1.MaxItemId = 10;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.Image")));
            this.btnHieuChinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.ImageOptions.LargeImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 4;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControl3.Size = new System.Drawing.Size(888, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(888, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 426);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(888, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 426);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.cmbXa);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.cmbDiaBan);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.cmbChonAp);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(888, 93);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbXa
            // 
            this.cmbXa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXa.FormattingEnabled = true;
            this.cmbXa.Location = new System.Drawing.Point(370, 33);
            this.cmbXa.Name = "cmbXa";
            this.cmbXa.Size = new System.Drawing.Size(196, 24);
            this.cmbXa.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(336, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Xã";
            // 
            // cmbDiaBan
            // 
            this.cmbDiaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaBan.FormattingEnabled = true;
            this.cmbDiaBan.Location = new System.Drawing.Point(78, 33);
            this.cmbDiaBan.Name = "cmbDiaBan";
            this.cmbDiaBan.Size = new System.Drawing.Size(213, 24);
            this.cmbDiaBan.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Địa bàn";
            // 
            // cmbChonAp
            // 
            this.cmbChonAp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChonAp.FormattingEnabled = true;
            this.cmbChonAp.Location = new System.Drawing.Point(658, 33);
            this.cmbChonAp.Name = "cmbChonAp";
            this.cmbChonAp.Size = new System.Drawing.Size(210, 24);
            this.cmbChonAp.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(617, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ấp";
            // 
            // dSTaoCongViec
            // 
            this.dSTaoCongViec.DataSetName = "DSTaoCongViec";
            this.dSTaoCongViec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDiaBan
            // 
            this.bdsDiaBan.DataMember = "DiaBan";
            this.bdsDiaBan.DataSource = this.dSTaoCongViec;
            // 
            // diaBanTableAdapter
            // 
            this.diaBanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApTableAdapter = this.apTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CongViecTableAdapter = this.congViecTableAdapter;
            this.tableAdapterManager.DiaBanTableAdapter = this.diaBanTableAdapter;
            this.tableAdapterManager.PhanCongTableAdapter = this.phanCongTableAdapter;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSTaoCongViecTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = this.xaTableAdapter;
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // congViecTableAdapter
            // 
            this.congViecTableAdapter.ClearBeforeFill = true;
            // 
            // phanCongTableAdapter
            // 
            this.phanCongTableAdapter.ClearBeforeFill = true;
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
            // bdsCongViec
            // 
            this.bdsCongViec.DataMember = "FK_CongViec_Ap";
            this.bdsCongViec.DataSource = this.bdsAp;
            // 
            // congViecGridControl
            // 
            this.congViecGridControl.DataSource = this.bdsCongViec;
            this.congViecGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.congViecGridControl.Location = new System.Drawing.Point(0, 117);
            this.congViecGridControl.MainView = this.gvAp;
            this.congViecGridControl.MenuManager = this.barManager1;
            this.congViecGridControl.Name = "congViecGridControl";
            this.congViecGridControl.Size = new System.Drawing.Size(888, 333);
            this.congViecGridControl.TabIndex = 5;
            this.congViecGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAp});
            this.congViecGridControl.Click += new System.EventHandler(this.congViecGridControl_Click);
            // 
            // gvAp
            // 
            this.gvAp.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvAp.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCV,
            this.colTenCV,
            this.colNgayBatDau,
            this.colNgayKetThuc});
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = null;
            this.gvAp.FormatRules.Add(gridFormatRule2);
            this.gvAp.GridControl = this.congViecGridControl;
            this.gvAp.Name = "gvAp";
            this.gvAp.OptionsBehavior.Editable = false;
            // 
            // colMaCV
            // 
            this.colMaCV.Caption = "Mã công việc";
            this.colMaCV.FieldName = "MaCV";
            this.colMaCV.Name = "colMaCV";
            this.colMaCV.Visible = true;
            this.colMaCV.VisibleIndex = 0;
            this.colMaCV.Width = 125;
            // 
            // colTenCV
            // 
            this.colTenCV.Caption = "Tên công việc";
            this.colTenCV.FieldName = "TenCV";
            this.colTenCV.Name = "colTenCV";
            this.colTenCV.Visible = true;
            this.colTenCV.VisibleIndex = 1;
            this.colTenCV.Width = 367;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.Caption = "Ngày bắt đầu";
            this.colNgayBatDau.FieldName = "NgayBatDau";
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.Visible = true;
            this.colNgayBatDau.VisibleIndex = 2;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.FieldName = "NgayKetThuc";
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Visible = true;
            this.colNgayKetThuc.VisibleIndex = 3;
            // 
            // bdsPhanCong
            // 
            this.bdsPhanCong.DataMember = "FK_PhanCong_CongViec";
            this.bdsPhanCong.DataSource = this.bdsCongViec;
            // 
            // frmTaoCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.congViecGridControl);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.Name = "frmTaoCongViec";
            this.Text = "Công việc";
            this.Load += new System.EventHandler(this.frmTaoCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSTaoCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDiaBan;
        private DSTaoCongViec dSTaoCongViec;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbXa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbDiaBan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbChonAp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DSTaoCongViecTableAdapters.DiaBanTableAdapter diaBanTableAdapter;
        private DSTaoCongViecTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTaoCongViecTableAdapters.XaTableAdapter xaTableAdapter;
        private System.Windows.Forms.BindingSource bdsXa;
        private DSTaoCongViecTableAdapters.ApTableAdapter apTableAdapter;
        private System.Windows.Forms.BindingSource bdsAp;
        private DSTaoCongViecTableAdapters.CongViecTableAdapter congViecTableAdapter;
        private System.Windows.Forms.BindingSource bdsCongViec;
        private DevExpress.XtraGrid.GridControl congViecGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAp;
        private DSTaoCongViecTableAdapters.PhanCongTableAdapter phanCongTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhanCong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
    }
}