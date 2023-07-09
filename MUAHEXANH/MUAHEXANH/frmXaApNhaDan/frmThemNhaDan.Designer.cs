namespace MUAHEXANH.frmXaApNhaDan
{
    partial class frmThemNhaDan
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
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label chuHoLabel;
            System.Windows.Forms.Label maApLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhaDan));
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
            this.cmbDiaBan = new System.Windows.Forms.ComboBox();
            this.diaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSthemXaApNhaDan = new MUAHEXANH.DSthemXaApNhaDan();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbXa = new System.Windows.Forms.ComboBox();
            this.xaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmbAp = new System.Windows.Forms.ComboBox();
            this.apBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsNhaDan = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaAp = new DevExpress.XtraEditors.TextEdit();
            this.chuHoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diaBanTableAdapter = new MUAHEXANH.DSthemXaApNhaDanTableAdapters.DiaBanTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSthemXaApNhaDanTableAdapters.TableAdapterManager();
            this.apTableAdapter = new MUAHEXANH.DSthemXaApNhaDanTableAdapters.ApTableAdapter();
            this.nhaDanTableAdapter = new MUAHEXANH.DSthemXaApNhaDanTableAdapters.NhaDanTableAdapter();
            this.xaTableAdapter = new MUAHEXANH.DSthemXaApNhaDanTableAdapters.XaTableAdapter();
            diaChiLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            chuHoLabel = new System.Windows.Forms.Label();
            maApLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSthemXaApNhaDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhaDan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaAp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuHoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(49, 33);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(68, 20);
            diaChiLabel.TabIndex = 0;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(70, 94);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(47, 20);
            sDTLabel.TabIndex = 2;
            sDTLabel.Text = "SDT:";
            // 
            // chuHoLabel
            // 
            chuHoLabel.AutoSize = true;
            chuHoLabel.Location = new System.Drawing.Point(430, 33);
            chuHoLabel.Name = "chuHoLabel";
            chuHoLabel.Size = new System.Drawing.Size(70, 20);
            chuHoLabel.TabIndex = 4;
            chuHoLabel.Text = "Chu Ho:";
            // 
            // maApLabel
            // 
            maApLabel.AutoSize = true;
            maApLabel.Location = new System.Drawing.Point(438, 91);
            maApLabel.Name = "maApLabel";
            maApLabel.Size = new System.Drawing.Size(62, 20);
            maApLabel.TabIndex = 6;
            maApLabel.Text = "Ma Ap:";
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
            this.barDockControl3.Size = new System.Drawing.Size(1088, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1088, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1088, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
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
            // cmbDiaBan
            // 
            this.cmbDiaBan.DataSource = this.diaBanBindingSource;
            this.cmbDiaBan.DisplayMember = "TenDiaBan";
            this.cmbDiaBan.FormattingEnabled = true;
            this.cmbDiaBan.Location = new System.Drawing.Point(165, 9);
            this.cmbDiaBan.Name = "cmbDiaBan";
            this.cmbDiaBan.Size = new System.Drawing.Size(199, 28);
            this.cmbDiaBan.TabIndex = 4;
            this.cmbDiaBan.ValueMember = "MaDiaBan";
            this.cmbDiaBan.SelectionChangeCommitted += new System.EventHandler(this.cmbDiaBan_SelectionChangeCommitted);
            // 
            // diaBanBindingSource
            // 
            this.diaBanBindingSource.DataMember = "DiaBan";
            this.diaBanBindingSource.DataSource = this.dSthemXaApNhaDan;
            // 
            // dSthemXaApNhaDan
            // 
            this.dSthemXaApNhaDan.DataSetName = "DSthemXaApNhaDan";
            this.dSthemXaApNhaDan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 20);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Chon địa bàn:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(390, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 20);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Chọn xã:";
            // 
            // cmbXa
            // 
            this.cmbXa.DataSource = this.xaBindingSource;
            this.cmbXa.DisplayMember = "TenXa";
            this.cmbXa.FormattingEnabled = true;
            this.cmbXa.Location = new System.Drawing.Point(482, 9);
            this.cmbXa.Name = "cmbXa";
            this.cmbXa.Size = new System.Drawing.Size(189, 28);
            this.cmbXa.TabIndex = 6;
            this.cmbXa.ValueMember = "MaXa";
            this.cmbXa.SelectionChangeCommitted += new System.EventHandler(this.cmbXa_SelectionChangeCommitted);
            // 
            // xaBindingSource
            // 
            this.xaBindingSource.DataMember = "FK_Xa_DiaBan";
            this.xaBindingSource.DataSource = this.diaBanBindingSource;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(742, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 20);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Chọn ấp:";
            // 
            // cmbAp
            // 
            this.cmbAp.DataSource = this.apBindingSource;
            this.cmbAp.DisplayMember = "TenAp";
            this.cmbAp.FormattingEnabled = true;
            this.cmbAp.Location = new System.Drawing.Point(861, 9);
            this.cmbAp.Name = "cmbAp";
            this.cmbAp.Size = new System.Drawing.Size(188, 28);
            this.cmbAp.TabIndex = 10;
            this.cmbAp.ValueMember = "MaAp";
            this.cmbAp.SelectionChangeCommitted += new System.EventHandler(this.cmbAp_SelectionChangeCommitted);
            // 
            // apBindingSource
            // 
            this.apBindingSource.DataMember = "FK_Ap_Xa";
            this.apBindingSource.DataSource = this.xaBindingSource;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbDiaBan);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmbAp);
            this.panelControl1.Controls.Add(this.cmbXa);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1088, 60);
            this.panelControl1.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsNhaDan;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1088, 200);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsNhaDan
            // 
            this.bdsNhaDan.DataMember = "FK_NhaDan_Ap";
            this.bdsNhaDan.DataSource = this.apBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNha,
            this.colDiaChi,
            this.colSDT,
            this.colChuHo,
            this.colMaAp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaNha
            // 
            this.colMaNha.FieldName = "MaNha";
            this.colMaNha.MinWidth = 25;
            this.colMaNha.Name = "colMaNha";
            this.colMaNha.OptionsColumn.ReadOnly = true;
            this.colMaNha.Visible = true;
            this.colMaNha.VisibleIndex = 0;
            this.colMaNha.Width = 94;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.MinWidth = 25;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.ReadOnly = true;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 1;
            this.colDiaChi.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.ReadOnly = true;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            this.colSDT.Width = 94;
            // 
            // colChuHo
            // 
            this.colChuHo.FieldName = "ChuHo";
            this.colChuHo.MinWidth = 25;
            this.colChuHo.Name = "colChuHo";
            this.colChuHo.OptionsColumn.ReadOnly = true;
            this.colChuHo.Visible = true;
            this.colChuHo.VisibleIndex = 3;
            this.colChuHo.Width = 94;
            // 
            // colMaAp
            // 
            this.colMaAp.FieldName = "MaAp";
            this.colMaAp.MinWidth = 25;
            this.colMaAp.Name = "colMaAp";
            this.colMaAp.OptionsColumn.ReadOnly = true;
            this.colMaAp.Visible = true;
            this.colMaAp.VisibleIndex = 4;
            this.colMaAp.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(maApLabel);
            this.panelControl2.Controls.Add(this.txtMaAp);
            this.panelControl2.Controls.Add(chuHoLabel);
            this.panelControl2.Controls.Add(this.chuHoTextEdit);
            this.panelControl2.Controls.Add(sDTLabel);
            this.panelControl2.Controls.Add(this.txtSDT);
            this.panelControl2.Controls.Add(diaChiLabel);
            this.panelControl2.Controls.Add(this.diaChiTextEdit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 290);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1088, 160);
            this.panelControl2.TabIndex = 14;
            // 
            // txtMaAp
            // 
            this.txtMaAp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhaDan, "MaAp", true));
            this.txtMaAp.Location = new System.Drawing.Point(506, 88);
            this.txtMaAp.MenuManager = this.barManager1;
            this.txtMaAp.Name = "txtMaAp";
            this.txtMaAp.Properties.ReadOnly = true;
            this.txtMaAp.Size = new System.Drawing.Size(125, 26);
            this.txtMaAp.TabIndex = 7;
            // 
            // chuHoTextEdit
            // 
            this.chuHoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhaDan, "ChuHo", true));
            this.chuHoTextEdit.Location = new System.Drawing.Point(506, 30);
            this.chuHoTextEdit.MenuManager = this.barManager1;
            this.chuHoTextEdit.Name = "chuHoTextEdit";
            this.chuHoTextEdit.Size = new System.Drawing.Size(125, 26);
            this.chuHoTextEdit.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhaDan, "SDT", true));
            this.txtSDT.Location = new System.Drawing.Point(123, 91);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(125, 26);
            this.txtSDT.TabIndex = 3;
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhaDan, "DiaChi", true));
            this.diaChiTextEdit.Location = new System.Drawing.Point(123, 30);
            this.diaChiTextEdit.MenuManager = this.barManager1;
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(125, 26);
            this.diaChiTextEdit.TabIndex = 1;
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
            this.tableAdapterManager.NhaDanTableAdapter = this.nhaDanTableAdapter;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSthemXaApNhaDanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XaTableAdapter = this.xaTableAdapter;
            // 
            // apTableAdapter
            // 
            this.apTableAdapter.ClearBeforeFill = true;
            // 
            // nhaDanTableAdapter
            // 
            this.nhaDanTableAdapter.ClearBeforeFill = true;
            // 
            // xaTableAdapter
            // 
            this.xaTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemNhaDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.Name = "frmThemNhaDan";
            this.Text = "frmThemNhaDan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThemNhaDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSthemXaApNhaDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhaDan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaAp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuHoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbDiaBan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbAp;
        private System.Windows.Forms.ComboBox cmbXa;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DSthemXaApNhaDan dSthemXaApNhaDan;
        private System.Windows.Forms.BindingSource diaBanBindingSource;
        private DSthemXaApNhaDanTableAdapters.DiaBanTableAdapter diaBanTableAdapter;
        private DSthemXaApNhaDanTableAdapters.TableAdapterManager tableAdapterManager;
        private DSthemXaApNhaDanTableAdapters.XaTableAdapter xaTableAdapter;
        private System.Windows.Forms.BindingSource xaBindingSource;
        private DSthemXaApNhaDanTableAdapters.ApTableAdapter apTableAdapter;
        private System.Windows.Forms.BindingSource apBindingSource;
        private DSthemXaApNhaDanTableAdapters.NhaDanTableAdapter nhaDanTableAdapter;
        private System.Windows.Forms.BindingSource bdsNhaDan;
        private DevExpress.XtraEditors.TextEdit txtMaAp;
        private DevExpress.XtraEditors.TextEdit chuHoTextEdit;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNha;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colChuHo;
        private DevExpress.XtraGrid.Columns.GridColumn colMaAp;
    }
}