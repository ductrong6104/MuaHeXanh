namespace MUAHEXANH
{
    partial class frmChiaNhom
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
            System.Windows.Forms.Label maNhomLabel1;
            System.Windows.Forms.Label maSVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiaNhom));
            this.dSchiaNhom = new MUAHEXANH.DSchiaNhom();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDSGV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.cmbDoi = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDoi = new DevExpress.XtraEditors.SimpleButton();
            this.sp_lay_doi_tu_chiendichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_lay_doi_tu_chiendichTableAdapter = new MUAHEXANH.DSchiaNhomTableAdapters.sp_lay_doi_tu_chiendichTableAdapter();
            this.gcNhom = new DevExpress.XtraGrid.GridControl();
            this.sp_lay_nhom_tu_doiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOMTRUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_lay_nhom_tu_doiTableAdapter = new MUAHEXANH.DSchiaNhomTableAdapters.sp_lay_nhom_tu_doiTableAdapter();
            this.pnlTVN = new DevExpress.XtraEditors.PanelControl();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.bdsThanhVienNhom = new System.Windows.Forms.BindingSource(this.components);
            this.ttsv_trong_nhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaNhom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSinhVien = new System.Windows.Forms.ComboBox();
            this.ttsv_trong_doiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTVN = new System.Windows.Forms.DataGridView();
            this.ttsv_trong_nhomTableAdapter = new MUAHEXANH.DSchiaNhomTableAdapters.ttsv_trong_nhomTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSchiaNhomTableAdapters.TableAdapterManager();
            this.thanhVienNhomTableAdapter = new MUAHEXANH.DSchiaNhomTableAdapters.ThanhVienNhomTableAdapter();
            this.ttsv_trong_doiTableAdapter = new MUAHEXANH.DSchiaNhomTableAdapters.ttsv_trong_doiTableAdapter();
            this.mASVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANHOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maNhomLabel1 = new System.Windows.Forms.Label();
            maSVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSchiaNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_doi_tu_chiendichBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_nhom_tu_doiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTVN)).BeginInit();
            this.pnlTVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThanhVienNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttsv_trong_nhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttsv_trong_doiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTVN)).BeginInit();
            this.SuspendLayout();
            // 
            // maNhomLabel1
            // 
            maNhomLabel1.AutoSize = true;
            maNhomLabel1.Location = new System.Drawing.Point(27, 62);
            maNhomLabel1.Name = "maNhomLabel1";
            maNhomLabel1.Size = new System.Drawing.Size(66, 16);
            maNhomLabel1.TabIndex = 6;
            maNhomLabel1.Text = "Ma Nhom:";
            // 
            // maSVLabel
            // 
            maSVLabel.AutoSize = true;
            maSVLabel.Location = new System.Drawing.Point(44, 116);
            maSVLabel.Name = "maSVLabel";
            maSVLabel.Size = new System.Drawing.Size(49, 16);
            maSVLabel.TabIndex = 7;
            maSVLabel.Text = "Ma SV:";
            // 
            // dSchiaNhom
            // 
            this.dSchiaNhom.DataSetName = "DSchiaNhom";
            this.dSchiaNhom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnDSGV,
            this.barButtonItem8,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
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
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
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
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.Image")));
            this.btnPhucHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.ImageOptions.LargeImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
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
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DƯỚI ĐÂY LÀ CÁC NÚT LỆNH THAO TÁC VỚI BẢNG LỚP, ĐỂ THAO TÁC VỚI BẢNG SINH VIÊN CL" +
    "ICK CHUỘT PHẢI LÊN BẢNG SINH VIÊN";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(850, 76);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 633);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(850, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 76);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 557);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(850, 76);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 557);
            // 
            // btnDSGV
            // 
            this.btnDSGV.Caption = "In danh sách Giảng viên";
            this.btnDSGV.Id = 7;
            this.btnDSGV.Name = "btnDSGV";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "In danh sách sinh viên";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // cmbDoi
            // 
            this.cmbDoi.FormattingEnabled = true;
            this.cmbDoi.Location = new System.Drawing.Point(117, 16);
            this.cmbDoi.Name = "cmbDoi";
            this.cmbDoi.Size = new System.Drawing.Size(121, 24);
            this.cmbDoi.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Chọn đội";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDoi);
            this.panelControl1.Controls.Add(this.cmbDoi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 76);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(850, 61);
            this.panelControl1.TabIndex = 7;
            // 
            // btnDoi
            // 
            this.btnDoi.Location = new System.Drawing.Point(336, 16);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(94, 29);
            this.btnDoi.TabIndex = 7;
            this.btnDoi.Text = "Ok";
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // sp_lay_doi_tu_chiendichBindingSource
            // 
            this.sp_lay_doi_tu_chiendichBindingSource.DataMember = "sp_lay_doi_tu_chiendich";
            this.sp_lay_doi_tu_chiendichBindingSource.DataSource = this.dSchiaNhom;
            // 
            // sp_lay_doi_tu_chiendichTableAdapter
            // 
            this.sp_lay_doi_tu_chiendichTableAdapter.ClearBeforeFill = true;
            // 
            // gcNhom
            // 
            this.gcNhom.DataSource = this.sp_lay_nhom_tu_doiBindingSource;
            this.gcNhom.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhom.Location = new System.Drawing.Point(0, 137);
            this.gcNhom.MainView = this.gridView1;
            this.gcNhom.MenuManager = this.barManager1;
            this.gcNhom.Name = "gcNhom";
            this.gcNhom.Size = new System.Drawing.Size(850, 200);
            this.gcNhom.TabIndex = 23;
            this.gcNhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sp_lay_nhom_tu_doiBindingSource
            // 
            this.sp_lay_nhom_tu_doiBindingSource.DataMember = "sp_lay_nhom_tu_doi";
            this.sp_lay_nhom_tu_doiBindingSource.DataSource = this.dSchiaNhom;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANHOM,
            this.colTENNHOM,
            this.colNHOMTRUONG,
            this.colTENDOI,
            this.colTENAP});
            this.gridView1.GridControl = this.gcNhom;
            this.gridView1.Name = "gridView1";
            // 
            // colMANHOM
            // 
            this.colMANHOM.FieldName = "MANHOM";
            this.colMANHOM.MinWidth = 25;
            this.colMANHOM.Name = "colMANHOM";
            this.colMANHOM.Visible = true;
            this.colMANHOM.VisibleIndex = 0;
            this.colMANHOM.Width = 94;
            // 
            // colTENNHOM
            // 
            this.colTENNHOM.FieldName = "TENNHOM";
            this.colTENNHOM.MinWidth = 25;
            this.colTENNHOM.Name = "colTENNHOM";
            this.colTENNHOM.Visible = true;
            this.colTENNHOM.VisibleIndex = 1;
            this.colTENNHOM.Width = 94;
            // 
            // colNHOMTRUONG
            // 
            this.colNHOMTRUONG.FieldName = "NHOMTRUONG";
            this.colNHOMTRUONG.MinWidth = 25;
            this.colNHOMTRUONG.Name = "colNHOMTRUONG";
            this.colNHOMTRUONG.Visible = true;
            this.colNHOMTRUONG.VisibleIndex = 2;
            this.colNHOMTRUONG.Width = 94;
            // 
            // colTENDOI
            // 
            this.colTENDOI.FieldName = "TENDOI";
            this.colTENDOI.MinWidth = 25;
            this.colTENDOI.Name = "colTENDOI";
            this.colTENDOI.Visible = true;
            this.colTENDOI.VisibleIndex = 3;
            this.colTENDOI.Width = 94;
            // 
            // colTENAP
            // 
            this.colTENAP.FieldName = "TENAP";
            this.colTENAP.MinWidth = 25;
            this.colTENAP.Name = "colTENAP";
            this.colTENAP.Visible = true;
            this.colTENAP.VisibleIndex = 4;
            this.colTENAP.Width = 94;
            // 
            // sp_lay_nhom_tu_doiTableAdapter
            // 
            this.sp_lay_nhom_tu_doiTableAdapter.ClearBeforeFill = true;
            // 
            // pnlTVN
            // 
            this.pnlTVN.Controls.Add(maSVLabel);
            this.pnlTVN.Controls.Add(this.txtMaSV);
            this.pnlTVN.Controls.Add(maNhomLabel1);
            this.pnlTVN.Controls.Add(this.txtMaNhom);
            this.pnlTVN.Controls.Add(this.labelControl2);
            this.pnlTVN.Controls.Add(this.cmbSinhVien);
            this.pnlTVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTVN.Location = new System.Drawing.Point(0, 337);
            this.pnlTVN.Name = "pnlTVN";
            this.pnlTVN.Size = new System.Drawing.Size(406, 296);
            this.pnlTVN.TabIndex = 25;
            // 
            // txtMaSV
            // 
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThanhVienNhom, "MaSV", true));
            this.txtMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ttsv_trong_nhomBindingSource, "MASV", true));
            this.txtMaSV.Location = new System.Drawing.Point(99, 113);
            this.txtMaSV.MenuManager = this.barManager1;
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(125, 22);
            this.txtMaSV.TabIndex = 8;
            // 
            // bdsThanhVienNhom
            // 
            this.bdsThanhVienNhom.DataMember = "ThanhVienNhom";
            this.bdsThanhVienNhom.DataSource = this.dSchiaNhom;
            // 
            // ttsv_trong_nhomBindingSource
            // 
            this.ttsv_trong_nhomBindingSource.DataMember = "sp_lay_nhom_tu_doi_DataTable1";
            this.ttsv_trong_nhomBindingSource.DataSource = this.sp_lay_nhom_tu_doiBindingSource;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThanhVienNhom, "MaNhom", true));
            this.txtMaNhom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_lay_nhom_tu_doiBindingSource, "MANHOM", true));
            this.txtMaNhom.Location = new System.Drawing.Point(99, 59);
            this.txtMaNhom.MenuManager = this.barManager1;
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(125, 22);
            this.txtMaNhom.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 179);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Chọn sinh viên: ";
            // 
            // cmbSinhVien
            // 
            this.cmbSinhVien.DataSource = this.ttsv_trong_doiBindingSource;
            this.cmbSinhVien.DisplayMember = "HOTEN";
            this.cmbSinhVien.FormattingEnabled = true;
            this.cmbSinhVien.Location = new System.Drawing.Point(171, 179);
            this.cmbSinhVien.Name = "cmbSinhVien";
            this.cmbSinhVien.Size = new System.Drawing.Size(125, 24);
            this.cmbSinhVien.TabIndex = 4;
            this.cmbSinhVien.ValueMember = "MASV";
            this.cmbSinhVien.SelectionChangeCommitted += new System.EventHandler(this.cmbSinhVien_SelectionChangeCommitted);
            // 
            // ttsv_trong_doiBindingSource
            // 
            this.ttsv_trong_doiBindingSource.DataMember = "sp_lay_doi_tu_chiendich_ttsv_trong_doi";
            this.ttsv_trong_doiBindingSource.DataSource = this.sp_lay_doi_tu_chiendichBindingSource;
            // 
            // dgvTVN
            // 
            this.dgvTVN.AutoGenerateColumns = false;
            this.dgvTVN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTVN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTVN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mASVDataGridViewTextBoxColumn,
            this.hODataGridViewTextBoxColumn,
            this.tENDataGridViewTextBoxColumn,
            this.mANHOMDataGridViewTextBoxColumn});
            this.dgvTVN.DataSource = this.ttsv_trong_nhomBindingSource;
            this.dgvTVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTVN.Location = new System.Drawing.Point(406, 337);
            this.dgvTVN.Name = "dgvTVN";
            this.dgvTVN.RowHeadersWidth = 51;
            this.dgvTVN.RowTemplate.Height = 24;
            this.dgvTVN.Size = new System.Drawing.Size(444, 296);
            this.dgvTVN.TabIndex = 26;
            // 
            // ttsv_trong_nhomTableAdapter
            // 
            this.ttsv_trong_nhomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoiTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.NhomTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.ThanhVienDoiTableAdapter = null;
            this.tableAdapterManager.ThanhVienNhomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSchiaNhomTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thanhVienNhomTableAdapter
            // 
            this.thanhVienNhomTableAdapter.ClearBeforeFill = true;
            // 
            // ttsv_trong_doiTableAdapter
            // 
            this.ttsv_trong_doiTableAdapter.ClearBeforeFill = true;
            // 
            // mASVDataGridViewTextBoxColumn
            // 
            this.mASVDataGridViewTextBoxColumn.DataPropertyName = "MASV";
            this.mASVDataGridViewTextBoxColumn.HeaderText = "MASV";
            this.mASVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mASVDataGridViewTextBoxColumn.Name = "mASVDataGridViewTextBoxColumn";
            // 
            // hODataGridViewTextBoxColumn
            // 
            this.hODataGridViewTextBoxColumn.DataPropertyName = "HO";
            this.hODataGridViewTextBoxColumn.HeaderText = "HO";
            this.hODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hODataGridViewTextBoxColumn.Name = "hODataGridViewTextBoxColumn";
            // 
            // tENDataGridViewTextBoxColumn
            // 
            this.tENDataGridViewTextBoxColumn.DataPropertyName = "TEN";
            this.tENDataGridViewTextBoxColumn.HeaderText = "TEN";
            this.tENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENDataGridViewTextBoxColumn.Name = "tENDataGridViewTextBoxColumn";
            // 
            // mANHOMDataGridViewTextBoxColumn
            // 
            this.mANHOMDataGridViewTextBoxColumn.DataPropertyName = "MANHOM";
            this.mANHOMDataGridViewTextBoxColumn.HeaderText = "MANHOM";
            this.mANHOMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANHOMDataGridViewTextBoxColumn.Name = "mANHOMDataGridViewTextBoxColumn";
            // 
            // frmChiaNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 653);
            this.Controls.Add(this.dgvTVN);
            this.Controls.Add(this.pnlTVN);
            this.Controls.Add(this.gcNhom);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.Name = "frmChiaNhom";
            this.Text = "frmChiaNhom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChiaNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSchiaNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_doi_tu_chiendichBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_nhom_tu_doiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTVN)).EndInit();
            this.pnlTVN.ResumeLayout(false);
            this.pnlTVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThanhVienNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttsv_trong_nhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttsv_trong_doiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDSGV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DSchiaNhom dSchiaNhom;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbDoi;
        private DevExpress.XtraEditors.SimpleButton btnDoi;
        private System.Windows.Forms.BindingSource sp_lay_doi_tu_chiendichBindingSource;
        private DSchiaNhomTableAdapters.sp_lay_doi_tu_chiendichTableAdapter sp_lay_doi_tu_chiendichTableAdapter;
        private DevExpress.XtraGrid.GridControl gcNhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource sp_lay_nhom_tu_doiBindingSource;
        private DSchiaNhomTableAdapters.sp_lay_nhom_tu_doiTableAdapter sp_lay_nhom_tu_doiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMANHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOMTRUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDOI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENAP;
        private DevExpress.XtraEditors.PanelControl pnlTVN;
        private System.Windows.Forms.DataGridView dgvTVN;
        private System.Windows.Forms.BindingSource ttsv_trong_nhomBindingSource;
        private DSchiaNhomTableAdapters.ttsv_trong_nhomTableAdapter ttsv_trong_nhomTableAdapter;
        private DSchiaNhomTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsThanhVienNhom;
        private DSchiaNhomTableAdapters.ThanhVienNhomTableAdapter thanhVienNhomTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbSinhVien;
        private System.Windows.Forms.BindingSource ttsv_trong_doiBindingSource;
        private DSchiaNhomTableAdapters.ttsv_trong_doiTableAdapter ttsv_trong_doiTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.TextEdit txtMaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANHOMDataGridViewTextBoxColumn;
    }
}