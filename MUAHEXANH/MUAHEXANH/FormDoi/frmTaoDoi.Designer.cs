namespace MUAHEXANH
{
    partial class frmTaoDoi
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
            System.Windows.Forms.Label tendoiLabel;
            System.Windows.Forms.Label giamSat1Label;
            System.Windows.Forms.Label giamSat2Label;
            System.Windows.Forms.Label tenchiendichLabel;
            System.Windows.Forms.Label tenkhoaLabel;
            System.Windows.Forms.Label tenxaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoDoi));
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSGV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.pnlDSDOI = new DevExpress.XtraEditors.PanelControl();
            this.gcDSDOI = new DevExpress.XtraGrid.GridControl();
            this.bdsDOI = new System.Windows.Forms.BindingSource(this.components);
            this.dStaoDoi = new MUAHEXANH.DStaoDoi();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltendoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamSat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamSat2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoiTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoiPho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenkhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenxa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsosv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sp_lay_xa_tu_chiendichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_lay_giamsat2_them_vao_doiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_lay_giamsat1_them_vao_doiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.dgvNHOM = new System.Windows.Forms.DataGridView();
            this.maNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splaydsdoitheochiendichNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableAdapterManager = new MUAHEXANH.DStaoDoiTableAdapters.TableAdapterManager();
            this.nhomTableAdapter = new MUAHEXANH.DStaoDoiTableAdapters.NhomTableAdapter();
            this.khoaTableAdapter = new MUAHEXANH.DStaoDoiTableAdapters.KhoaTableAdapter();
            this.sp_lay_giamsat1_them_vao_doiTableAdapter = new MUAHEXANH.DStaoDoiTableAdapters.sp_lay_giamsat1_them_vao_doiTableAdapter();
            this.sp_lay_giamsat2_them_vao_doiTableAdapter = new MUAHEXANH.DStaoDoiTableAdapters.sp_lay_giamsat2_them_vao_doiTableAdapter();
            this.sp_lay_xa_tu_chiendichTableAdapter = new MUAHEXANH.DStaoDoiTableAdapters.sp_lay_xa_tu_chiendichTableAdapter();
            this.txtTenDoi = new DevExpress.XtraEditors.TextEdit();
            this.txtChienDich = new DevExpress.XtraEditors.TextEdit();
            this.cmbGiamSat1 = new System.Windows.Forms.ComboBox();
            this.cmbGiamSat2 = new System.Windows.Forms.ComboBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.cmbXa = new System.Windows.Forms.ComboBox();
            this.pnlDOI = new DevExpress.XtraEditors.PanelControl();
            this.sp_lay_dsdoi_theo_chiendichTableAdapter = new MUAHEXANH.DStaoDoiTableAdapters.sp_lay_dsdoi_theo_chiendichTableAdapter();
            this.txtMaGS1 = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGS2 = new DevExpress.XtraEditors.TextEdit();
            tendoiLabel = new System.Windows.Forms.Label();
            giamSat1Label = new System.Windows.Forms.Label();
            giamSat2Label = new System.Windows.Forms.Label();
            tenchiendichLabel = new System.Windows.Forms.Label();
            tenkhoaLabel = new System.Windows.Forms.Label();
            tenxaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSDOI)).BeginInit();
            this.pnlDSDOI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDOI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDOI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_xa_tu_chiendichBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_giamsat2_them_vao_doiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_giamsat1_them_vao_doiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splaydsdoitheochiendichNhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChienDich.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDOI)).BeginInit();
            this.pnlDOI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGS1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGS2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tendoiLabel
            // 
            tendoiLabel.AutoSize = true;
            tendoiLabel.Location = new System.Drawing.Point(17, 30);
            tendoiLabel.Name = "tendoiLabel";
            tendoiLabel.Size = new System.Drawing.Size(106, 20);
            tendoiLabel.TabIndex = 0;
            tendoiLabel.Text = "Chọn tên đội:";
            // 
            // giamSat1Label
            // 
            giamSat1Label.AutoSize = true;
            giamSat1Label.Location = new System.Drawing.Point(15, 77);
            giamSat1Label.Name = "giamSat1Label";
            giamSat1Label.Size = new System.Drawing.Size(130, 20);
            giamSat1Label.TabIndex = 2;
            giamSat1Label.Text = "Chọn giám sát 1:";
            // 
            // giamSat2Label
            // 
            giamSat2Label.AutoSize = true;
            giamSat2Label.Location = new System.Drawing.Point(17, 170);
            giamSat2Label.Name = "giamSat2Label";
            giamSat2Label.Size = new System.Drawing.Size(130, 20);
            giamSat2Label.TabIndex = 4;
            giamSat2Label.Text = "Chọn giám sát 2:";
            // 
            // tenchiendichLabel
            // 
            tenchiendichLabel.AutoSize = true;
            tenchiendichLabel.Location = new System.Drawing.Point(390, 30);
            tenchiendichLabel.Name = "tenchiendichLabel";
            tenchiendichLabel.Size = new System.Drawing.Size(120, 20);
            tenchiendichLabel.TabIndex = 10;
            tenchiendichLabel.Text = "Tên chiến dịch:";
            // 
            // tenkhoaLabel
            // 
            tenkhoaLabel.AutoSize = true;
            tenkhoaLabel.Location = new System.Drawing.Point(411, 77);
            tenkhoaLabel.Name = "tenkhoaLabel";
            tenkhoaLabel.Size = new System.Drawing.Size(82, 20);
            tenkhoaLabel.TabIndex = 12;
            tenkhoaLabel.Text = "Tên khoa:";
            // 
            // tenxaLabel
            // 
            tenxaLabel.AutoSize = true;
            tenxaLabel.Location = new System.Drawing.Point(430, 120);
            tenxaLabel.Name = "tenxaLabel";
            tenxaLabel.Size = new System.Drawing.Size(63, 20);
            tenxaLabel.TabIndex = 14;
            tenxaLabel.Text = "Tên xã:";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(1207, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 623);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1207, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 593);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1207, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 593);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DƯỚI ĐÂY LÀ CÁC NÚT LỆNH THAO TÁC VỚI BẢNG LỚP, ĐỂ THAO TÁC VỚI BẢNG SINH VIÊN CL" +
    "ICK CHUỘT PHẢI LÊN BẢNG SINH VIÊN";
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
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
            // pnlDSDOI
            // 
            this.pnlDSDOI.Controls.Add(this.gcDSDOI);
            this.pnlDSDOI.Controls.Add(this.panelControl2);
            this.pnlDSDOI.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDSDOI.Location = new System.Drawing.Point(0, 30);
            this.pnlDSDOI.Name = "pnlDSDOI";
            this.pnlDSDOI.Size = new System.Drawing.Size(1207, 288);
            this.pnlDSDOI.TabIndex = 4;
            // 
            // gcDSDOI
            // 
            this.gcDSDOI.DataSource = this.bdsDOI;
            this.gcDSDOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSDOI.Location = new System.Drawing.Point(2, 60);
            this.gcDSDOI.MainView = this.gridView1;
            this.gcDSDOI.MenuManager = this.barManager1;
            this.gcDSDOI.Name = "gcDSDOI";
            this.gcDSDOI.Size = new System.Drawing.Size(1203, 226);
            this.gcDSDOI.TabIndex = 1;
            this.gcDSDOI.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDOI
            // 
            this.bdsDOI.DataMember = "sp_lay_dsdoi_theo_chiendich";
            this.bdsDOI.DataSource = this.dStaoDoi;
            // 
            // dStaoDoi
            // 
            this.dStaoDoi.DataSetName = "DStaoDoi";
            this.dStaoDoi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDoi,
            this.coltendoi,
            this.colGiamSat1,
            this.colGiamSat2,
            this.colDoiTruong,
            this.colDoiPho,
            this.coltenkhoa,
            this.coltenxa,
            this.colsosv});
            this.gridView1.GridControl = this.gcDSDOI;
            this.gridView1.Name = "gridView1";
            this.gridView1.ViewCaption = "Tạo Đội";
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colMaDoi
            // 
            this.colMaDoi.Caption = "Mã đội";
            this.colMaDoi.FieldName = "MaDoi";
            this.colMaDoi.MinWidth = 25;
            this.colMaDoi.Name = "colMaDoi";
            this.colMaDoi.OptionsColumn.ReadOnly = true;
            this.colMaDoi.Visible = true;
            this.colMaDoi.VisibleIndex = 0;
            this.colMaDoi.Width = 94;
            // 
            // coltendoi
            // 
            this.coltendoi.Caption = "Tên đội";
            this.coltendoi.FieldName = "tendoi";
            this.coltendoi.MinWidth = 25;
            this.coltendoi.Name = "coltendoi";
            this.coltendoi.OptionsColumn.ReadOnly = true;
            this.coltendoi.Visible = true;
            this.coltendoi.VisibleIndex = 1;
            this.coltendoi.Width = 94;
            // 
            // colGiamSat1
            // 
            this.colGiamSat1.Caption = "Giám sát 1";
            this.colGiamSat1.FieldName = "GiamSat1";
            this.colGiamSat1.MinWidth = 25;
            this.colGiamSat1.Name = "colGiamSat1";
            this.colGiamSat1.OptionsColumn.ReadOnly = true;
            this.colGiamSat1.Visible = true;
            this.colGiamSat1.VisibleIndex = 2;
            this.colGiamSat1.Width = 94;
            // 
            // colGiamSat2
            // 
            this.colGiamSat2.Caption = "Giám sát 2";
            this.colGiamSat2.FieldName = "GiamSat2";
            this.colGiamSat2.MinWidth = 25;
            this.colGiamSat2.Name = "colGiamSat2";
            this.colGiamSat2.OptionsColumn.ReadOnly = true;
            this.colGiamSat2.Visible = true;
            this.colGiamSat2.VisibleIndex = 3;
            this.colGiamSat2.Width = 94;
            // 
            // colDoiTruong
            // 
            this.colDoiTruong.Caption = "Đội trưởng";
            this.colDoiTruong.FieldName = "DoiTruong";
            this.colDoiTruong.MinWidth = 25;
            this.colDoiTruong.Name = "colDoiTruong";
            this.colDoiTruong.OptionsColumn.ReadOnly = true;
            this.colDoiTruong.Visible = true;
            this.colDoiTruong.VisibleIndex = 4;
            this.colDoiTruong.Width = 94;
            // 
            // colDoiPho
            // 
            this.colDoiPho.Caption = "Đội phó";
            this.colDoiPho.FieldName = "DoiPho";
            this.colDoiPho.MinWidth = 25;
            this.colDoiPho.Name = "colDoiPho";
            this.colDoiPho.OptionsColumn.ReadOnly = true;
            this.colDoiPho.Visible = true;
            this.colDoiPho.VisibleIndex = 5;
            this.colDoiPho.Width = 94;
            // 
            // coltenkhoa
            // 
            this.coltenkhoa.Caption = "Tên khoa";
            this.coltenkhoa.FieldName = "tenkhoa";
            this.coltenkhoa.MinWidth = 25;
            this.coltenkhoa.Name = "coltenkhoa";
            this.coltenkhoa.OptionsColumn.ReadOnly = true;
            this.coltenkhoa.Visible = true;
            this.coltenkhoa.VisibleIndex = 6;
            this.coltenkhoa.Width = 94;
            // 
            // coltenxa
            // 
            this.coltenxa.Caption = "Tên xã";
            this.coltenxa.FieldName = "tenxa";
            this.coltenxa.MinWidth = 25;
            this.coltenxa.Name = "coltenxa";
            this.coltenxa.OptionsColumn.ReadOnly = true;
            this.coltenxa.Visible = true;
            this.coltenxa.VisibleIndex = 7;
            this.coltenxa.Width = 94;
            // 
            // colsosv
            // 
            this.colsosv.Caption = "Số sinh viên";
            this.colsosv.FieldName = "sosv";
            this.colsosv.MinWidth = 25;
            this.colsosv.Name = "colsosv";
            this.colsosv.OptionsColumn.ReadOnly = true;
            this.colsosv.Visible = true;
            this.colsosv.VisibleIndex = 8;
            this.colsosv.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1203, 58);
            this.panelControl2.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(478, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(257, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH ĐỘI";
            // 
            // sp_lay_xa_tu_chiendichBindingSource
            // 
            this.sp_lay_xa_tu_chiendichBindingSource.DataMember = "sp_lay_xa_tu_chiendich";
            this.sp_lay_xa_tu_chiendichBindingSource.DataSource = this.dStaoDoi;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.dStaoDoi;
            // 
            // sp_lay_giamsat2_them_vao_doiBindingSource
            // 
            this.sp_lay_giamsat2_them_vao_doiBindingSource.DataMember = "sp_lay_giamsat2_them_vao_doi";
            this.sp_lay_giamsat2_them_vao_doiBindingSource.DataSource = this.dStaoDoi;
            // 
            // sp_lay_giamsat1_them_vao_doiBindingSource
            // 
            this.sp_lay_giamsat1_them_vao_doiBindingSource.DataMember = "sp_lay_giamsat1_them_vao_doi";
            this.sp_lay_giamsat1_them_vao_doiBindingSource.DataSource = this.dStaoDoi;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.dgvNHOM);
            this.panelControl4.Controls.Add(this.panelControl5);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(749, 318);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(458, 305);
            this.panelControl4.TabIndex = 6;
            // 
            // dgvNHOM
            // 
            this.dgvNHOM.AllowUserToAddRows = false;
            this.dgvNHOM.AutoGenerateColumns = false;
            this.dgvNHOM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNHOM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNHOM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNHOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNHOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhomDataGridViewTextBoxColumn,
            this.tenNhomDataGridViewTextBoxColumn,
            this.maDoiDataGridViewTextBoxColumn});
            this.dgvNHOM.DataSource = this.nhomBindingSource1;
            this.dgvNHOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNHOM.Location = new System.Drawing.Point(2, 42);
            this.dgvNHOM.Name = "dgvNHOM";
            this.dgvNHOM.ReadOnly = true;
            this.dgvNHOM.RowHeadersWidth = 51;
            this.dgvNHOM.RowTemplate.Height = 24;
            this.dgvNHOM.Size = new System.Drawing.Size(454, 261);
            this.dgvNHOM.TabIndex = 1;
            // 
            // maNhomDataGridViewTextBoxColumn
            // 
            this.maNhomDataGridViewTextBoxColumn.DataPropertyName = "MaNhom";
            this.maNhomDataGridViewTextBoxColumn.HeaderText = "Mã nhóm";
            this.maNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhomDataGridViewTextBoxColumn.Name = "maNhomDataGridViewTextBoxColumn";
            this.maNhomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên nhóm";
            this.tenNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maDoiDataGridViewTextBoxColumn
            // 
            this.maDoiDataGridViewTextBoxColumn.DataPropertyName = "MaDoi";
            this.maDoiDataGridViewTextBoxColumn.HeaderText = "Mã Đội";
            this.maDoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDoiDataGridViewTextBoxColumn.Name = "maDoiDataGridViewTextBoxColumn";
            this.maDoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nhomBindingSource1
            // 
            this.nhomBindingSource1.DataSource = this.splaydsdoitheochiendichNhomBindingSource;
            // 
            // splaydsdoitheochiendichNhomBindingSource
            // 
            this.splaydsdoitheochiendichNhomBindingSource.DataMember = "sp_lay_dsdoi_theo_chiendich_Nhom";
            this.splaydsdoitheochiendichNhomBindingSource.DataSource = this.bdsDOI;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.labelControl2);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(454, 40);
            this.panelControl5.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(116, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(202, 26);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "DANH SÁCH NHÓM";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DStaoDoiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nhomTableAdapter
            // 
            this.nhomTableAdapter.ClearBeforeFill = true;
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_lay_giamsat1_them_vao_doiTableAdapter
            // 
            this.sp_lay_giamsat1_them_vao_doiTableAdapter.ClearBeforeFill = true;
            // 
            // sp_lay_giamsat2_them_vao_doiTableAdapter
            // 
            this.sp_lay_giamsat2_them_vao_doiTableAdapter.ClearBeforeFill = true;
            // 
            // sp_lay_xa_tu_chiendichTableAdapter
            // 
            this.sp_lay_xa_tu_chiendichTableAdapter.ClearBeforeFill = true;
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDOI, "tendoi", true));
            this.txtTenDoi.Location = new System.Drawing.Point(164, 27);
            this.txtTenDoi.MenuManager = this.barManager1;
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Size = new System.Drawing.Size(198, 26);
            this.txtTenDoi.TabIndex = 1;
            // 
            // txtChienDich
            // 
            this.txtChienDich.Location = new System.Drawing.Point(520, 24);
            this.txtChienDich.MenuManager = this.barManager1;
            this.txtChienDich.Name = "txtChienDich";
            this.txtChienDich.Properties.ReadOnly = true;
            this.txtChienDich.Size = new System.Drawing.Size(198, 26);
            this.txtChienDich.TabIndex = 11;
            // 
            // cmbGiamSat1
            // 
            this.cmbGiamSat1.DataSource = this.sp_lay_giamsat1_them_vao_doiBindingSource;
            this.cmbGiamSat1.DisplayMember = "hoten";
            this.cmbGiamSat1.FormattingEnabled = true;
            this.cmbGiamSat1.Location = new System.Drawing.Point(164, 74);
            this.cmbGiamSat1.Name = "cmbGiamSat1";
            this.cmbGiamSat1.Size = new System.Drawing.Size(198, 28);
            this.cmbGiamSat1.TabIndex = 16;
            this.cmbGiamSat1.ValueMember = "MaGV";
            // 
            // cmbGiamSat2
            // 
            this.cmbGiamSat2.DataSource = this.sp_lay_giamsat2_them_vao_doiBindingSource;
            this.cmbGiamSat2.DisplayMember = "hoten";
            this.cmbGiamSat2.FormattingEnabled = true;
            this.cmbGiamSat2.Location = new System.Drawing.Point(164, 162);
            this.cmbGiamSat2.Name = "cmbGiamSat2";
            this.cmbGiamSat2.Size = new System.Drawing.Size(198, 28);
            this.cmbGiamSat2.TabIndex = 17;
            this.cmbGiamSat2.ValueMember = "MaGV";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.khoaBindingSource;
            this.cmbKhoa.DisplayMember = "TenKhoa";
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(520, 74);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(198, 28);
            this.cmbKhoa.TabIndex = 19;
            this.cmbKhoa.ValueMember = "MaKhoa";
            this.cmbKhoa.SelectionChangeCommitted += new System.EventHandler(this.cmbKhoa_SelectionChangeCommitted);
            // 
            // cmbXa
            // 
            this.cmbXa.DataSource = this.sp_lay_xa_tu_chiendichBindingSource;
            this.cmbXa.DisplayMember = "TenXa";
            this.cmbXa.FormattingEnabled = true;
            this.cmbXa.Location = new System.Drawing.Point(520, 117);
            this.cmbXa.Name = "cmbXa";
            this.cmbXa.Size = new System.Drawing.Size(198, 28);
            this.cmbXa.TabIndex = 21;
            this.cmbXa.ValueMember = "MaXa";
            // 
            // pnlDOI
            // 
            this.pnlDOI.Controls.Add(label2);
            this.pnlDOI.Controls.Add(this.txtMaGS2);
            this.pnlDOI.Controls.Add(label1);
            this.pnlDOI.Controls.Add(this.txtMaGS1);
            this.pnlDOI.Controls.Add(this.cmbXa);
            this.pnlDOI.Controls.Add(this.cmbKhoa);
            this.pnlDOI.Controls.Add(this.cmbGiamSat2);
            this.pnlDOI.Controls.Add(this.cmbGiamSat1);
            this.pnlDOI.Controls.Add(tenxaLabel);
            this.pnlDOI.Controls.Add(tenkhoaLabel);
            this.pnlDOI.Controls.Add(tenchiendichLabel);
            this.pnlDOI.Controls.Add(this.txtChienDich);
            this.pnlDOI.Controls.Add(giamSat2Label);
            this.pnlDOI.Controls.Add(giamSat1Label);
            this.pnlDOI.Controls.Add(tendoiLabel);
            this.pnlDOI.Controls.Add(this.txtTenDoi);
            this.pnlDOI.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDOI.Location = new System.Drawing.Point(0, 318);
            this.pnlDOI.Name = "pnlDOI";
            this.pnlDOI.Size = new System.Drawing.Size(749, 305);
            this.pnlDOI.TabIndex = 5;
            // 
            // sp_lay_dsdoi_theo_chiendichTableAdapter
            // 
            this.sp_lay_dsdoi_theo_chiendichTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(34, 125);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(115, 20);
            label1.TabIndex = 22;
            label1.Text = "Mã giám sát 1:";
            // 
            // txtMaGS1
            // 
            this.txtMaGS1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_lay_giamsat1_them_vao_doiBindingSource, "MaGV", true));
            this.txtMaGS1.Location = new System.Drawing.Point(164, 119);
            this.txtMaGS1.MenuManager = this.barManager1;
            this.txtMaGS1.Name = "txtMaGS1";
            this.txtMaGS1.Properties.ReadOnly = true;
            this.txtMaGS1.Size = new System.Drawing.Size(198, 26);
            this.txtMaGS1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(34, 212);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 20);
            label2.TabIndex = 24;
            label2.Text = "Mã giám sát 2:";
            // 
            // txtMaGS2
            // 
            this.txtMaGS2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_lay_giamsat2_them_vao_doiBindingSource, "MaGV", true));
            this.txtMaGS2.Location = new System.Drawing.Point(164, 206);
            this.txtMaGS2.MenuManager = this.barManager1;
            this.txtMaGS2.Name = "txtMaGS2";
            this.txtMaGS2.Properties.ReadOnly = true;
            this.txtMaGS2.Size = new System.Drawing.Size(198, 26);
            this.txtMaGS2.TabIndex = 25;
            // 
            // frmTaoDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 623);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.pnlDOI);
            this.Controls.Add(this.pnlDSDOI);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.Name = "frmTaoDoi";
            this.Text = "Tạo đội";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoDoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSDOI)).EndInit();
            this.pnlDSDOI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSDOI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDOI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_xa_tu_chiendichBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_giamsat2_them_vao_doiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_giamsat1_them_vao_doiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNHOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splaydsdoitheochiendichNhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChienDich.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDOI)).EndInit();
            this.pnlDOI.ResumeLayout(false);
            this.pnlDOI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGS1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGS2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDSGV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl pnlDSDOI;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridView dgvNHOM;
        private DStaoDoi dStaoDoi;
        private DStaoDoiTableAdapters.TableAdapterManager tableAdapterManager;
        private DStaoDoiTableAdapters.NhomTableAdapter nhomTableAdapter;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DStaoDoiTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.BindingSource sp_lay_giamsat1_them_vao_doiBindingSource;
        private DStaoDoiTableAdapters.sp_lay_giamsat1_them_vao_doiTableAdapter sp_lay_giamsat1_them_vao_doiTableAdapter;
        private System.Windows.Forms.BindingSource sp_lay_giamsat2_them_vao_doiBindingSource;
        private DStaoDoiTableAdapters.sp_lay_giamsat2_them_vao_doiTableAdapter sp_lay_giamsat2_them_vao_doiTableAdapter;
        private System.Windows.Forms.BindingSource sp_lay_xa_tu_chiendichBindingSource;
        private DStaoDoiTableAdapters.sp_lay_xa_tu_chiendichTableAdapter sp_lay_xa_tu_chiendichTableAdapter;
        private System.Windows.Forms.BindingSource nhomBindingSource1;
        private DevExpress.XtraEditors.PanelControl pnlDOI;
        private System.Windows.Forms.ComboBox cmbXa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.ComboBox cmbGiamSat2;
        private System.Windows.Forms.ComboBox cmbGiamSat1;
        private DevExpress.XtraEditors.TextEdit txtChienDich;
        private DevExpress.XtraEditors.TextEdit txtTenDoi;
        private System.Windows.Forms.BindingSource bdsDOI;
        private DStaoDoiTableAdapters.sp_lay_dsdoi_theo_chiendichTableAdapter sp_lay_dsdoi_theo_chiendichTableAdapter;
        private DevExpress.XtraGrid.GridControl gcDSDOI;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDoi;
        private DevExpress.XtraGrid.Columns.GridColumn coltendoi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamSat1;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamSat2;
        private DevExpress.XtraGrid.Columns.GridColumn colDoiTruong;
        private DevExpress.XtraGrid.Columns.GridColumn colDoiPho;
        private DevExpress.XtraGrid.Columns.GridColumn coltenkhoa;
        private DevExpress.XtraGrid.Columns.GridColumn coltenxa;
        private DevExpress.XtraGrid.Columns.GridColumn colsosv;
        private System.Windows.Forms.BindingSource splaydsdoitheochiendichNhomBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoiDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.TextEdit txtMaGS2;
        private DevExpress.XtraEditors.TextEdit txtMaGS1;
    }
}