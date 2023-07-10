namespace MUAHEXANH
{
    partial class FrmChienDich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChienDich));
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
            this.gcDiaBanChuaCo = new DevExpress.XtraGrid.GridControl();
            this.gvDiaBanChuaCo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcDiaBanChienDich = new DevExpress.XtraGrid.GridControl();
            this.gvDiaBanChienDich = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoaDiaBan = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDiaBan = new DevExpress.XtraEditors.SimpleButton();
            this.dSTaoChienDich = new MUAHEXANH.DSTaoChienDich();
            this.bdsChienDich = new System.Windows.Forms.BindingSource(this.components);
            this.chienDichTableAdapter = new MUAHEXANH.DSTaoChienDichTableAdapters.ChienDichTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSTaoChienDichTableAdapters.TableAdapterManager();
            this.gcChienDich = new DevExpress.XtraGrid.GridControl();
            this.gvChienDich = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaChienDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChienDich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayPhatDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiaBanChuaCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiaBanChuaCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiaBanChienDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiaBanChienDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTaoChienDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChienDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChienDich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChienDich)).BeginInit();
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
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(1688, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 795);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1688, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 765);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1688, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 765);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gcDiaBanChuaCo);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 301);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1688, 494);
            this.panelControl1.TabIndex = 6;
            // 
            // gcDiaBanChuaCo
            // 
            this.gcDiaBanChuaCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiaBanChuaCo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDiaBanChuaCo.Location = new System.Drawing.Point(0, 0);
            this.gcDiaBanChuaCo.MainView = this.gvDiaBanChuaCo;
            this.gcDiaBanChuaCo.Margin = new System.Windows.Forms.Padding(4);
            this.gcDiaBanChuaCo.MenuManager = this.barManager1;
            this.gcDiaBanChuaCo.Name = "gcDiaBanChuaCo";
            this.gcDiaBanChuaCo.Size = new System.Drawing.Size(467, 494);
            this.gcDiaBanChuaCo.TabIndex = 1;
            this.gcDiaBanChuaCo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiaBanChuaCo});
            // 
            // gvDiaBanChuaCo
            // 
            this.gvDiaBanChuaCo.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvDiaBanChuaCo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDiaBanChuaCo.DetailHeight = 431;
            this.gvDiaBanChuaCo.GridControl = this.gcDiaBanChuaCo;
            this.gvDiaBanChuaCo.Name = "gvDiaBanChuaCo";
            this.gvDiaBanChuaCo.OptionsBehavior.Editable = false;
            this.gvDiaBanChuaCo.OptionsView.ShowGroupPanel = false;
            this.gvDiaBanChuaCo.OptionsView.ShowViewCaption = true;
            this.gvDiaBanChuaCo.ViewCaption = "Địa bàn";
            this.gvDiaBanChuaCo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDiaBanChuaCo_RowClick);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.gcDiaBanChienDich);
            this.panelControl2.Controls.Add(this.btnXoaDiaBan);
            this.panelControl2.Controls.Add(this.btnThemDiaBan);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(467, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1221, 494);
            this.panelControl2.TabIndex = 0;
            // 
            // gcDiaBanChienDich
            // 
            this.gcDiaBanChienDich.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcDiaBanChienDich.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcDiaBanChienDich.Location = new System.Drawing.Point(232, 0);
            this.gcDiaBanChienDich.MainView = this.gvDiaBanChienDich;
            this.gcDiaBanChienDich.Margin = new System.Windows.Forms.Padding(4);
            this.gcDiaBanChienDich.MenuManager = this.barManager1;
            this.gcDiaBanChienDich.Name = "gcDiaBanChienDich";
            this.gcDiaBanChienDich.Size = new System.Drawing.Size(989, 494);
            this.gcDiaBanChienDich.TabIndex = 2;
            this.gcDiaBanChienDich.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDiaBanChienDich});
            // 
            // gvDiaBanChienDich
            // 
            this.gvDiaBanChienDich.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvDiaBanChienDich.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDiaBanChienDich.DetailHeight = 431;
            this.gvDiaBanChienDich.GridControl = this.gcDiaBanChienDich;
            this.gvDiaBanChienDich.Name = "gvDiaBanChienDich";
            this.gvDiaBanChienDich.OptionsBehavior.Editable = false;
            this.gvDiaBanChienDich.OptionsView.ShowGroupPanel = false;
            this.gvDiaBanChienDich.OptionsView.ShowViewCaption = true;
            this.gvDiaBanChienDich.ViewCaption = "Đã thêm";
            this.gvDiaBanChienDich.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDiaBanChienDich_RowClick);
            // 
            // btnXoaDiaBan
            // 
            this.btnXoaDiaBan.Enabled = false;
            this.btnXoaDiaBan.Location = new System.Drawing.Point(68, 282);
            this.btnXoaDiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaDiaBan.Name = "btnXoaDiaBan";
            this.btnXoaDiaBan.Size = new System.Drawing.Size(105, 31);
            this.btnXoaDiaBan.TabIndex = 1;
            this.btnXoaDiaBan.Text = "Xóa";
            this.btnXoaDiaBan.Click += new System.EventHandler(this.btnXoaDiaBan_Click);
            // 
            // btnThemDiaBan
            // 
            this.btnThemDiaBan.Enabled = false;
            this.btnThemDiaBan.Location = new System.Drawing.Point(68, 145);
            this.btnThemDiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemDiaBan.Name = "btnThemDiaBan";
            this.btnThemDiaBan.Size = new System.Drawing.Size(105, 31);
            this.btnThemDiaBan.TabIndex = 0;
            this.btnThemDiaBan.Text = "Thêm";
            this.btnThemDiaBan.Click += new System.EventHandler(this.btnThemDiaBan_Click);
            // 
            // dSTaoChienDich
            // 
            this.dSTaoChienDich.DataSetName = "DSTaoChienDich";
            this.dSTaoChienDich.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsChienDich
            // 
            this.bdsChienDich.DataMember = "ChienDich";
            this.bdsChienDich.DataSource = this.dSTaoChienDich;
            // 
            // chienDichTableAdapter
            // 
            this.chienDichTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChienDichTableAdapter = this.chienDichTableAdapter;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSTaoChienDichTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcChienDich
            // 
            this.gcChienDich.DataSource = this.bdsChienDich;
            this.gcChienDich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChienDich.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcChienDich.Location = new System.Drawing.Point(0, 30);
            this.gcChienDich.MainView = this.gvChienDich;
            this.gcChienDich.Margin = new System.Windows.Forms.Padding(4);
            this.gcChienDich.MenuManager = this.barManager1;
            this.gcChienDich.Name = "gcChienDich";
            this.gcChienDich.Size = new System.Drawing.Size(1688, 271);
            this.gcChienDich.TabIndex = 11;
            this.gcChienDich.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChienDich});
            // 
            // gvChienDich
            // 
            this.gvChienDich.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
            this.gvChienDich.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvChienDich.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaChienDich,
            this.colTenChienDich,
            this.colNgayPhatDong,
            this.colNgayKetThuc});
            this.gvChienDich.DetailHeight = 431;
            this.gvChienDich.GridControl = this.gcChienDich;
            this.gvChienDich.Name = "gvChienDich";
            this.gvChienDich.OptionsBehavior.Editable = false;
            this.gvChienDich.OptionsView.ShowGroupPanel = false;
            this.gvChienDich.OptionsView.ShowViewCaption = true;
            this.gvChienDich.ViewCaption = "Chiến dịch";
            this.gvChienDich.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvChienDich_SelectionChanged);
            // 
            // colMaChienDich
            // 
            this.colMaChienDich.Caption = "Mã";
            this.colMaChienDich.FieldName = "MaChienDich";
            this.colMaChienDich.MinWidth = 27;
            this.colMaChienDich.Name = "colMaChienDich";
            this.colMaChienDich.Visible = true;
            this.colMaChienDich.VisibleIndex = 0;
            this.colMaChienDich.Width = 100;
            // 
            // colTenChienDich
            // 
            this.colTenChienDich.Caption = "Tên chiến dịch";
            this.colTenChienDich.FieldName = "TenChienDich";
            this.colTenChienDich.MinWidth = 27;
            this.colTenChienDich.Name = "colTenChienDich";
            this.colTenChienDich.Visible = true;
            this.colTenChienDich.VisibleIndex = 1;
            this.colTenChienDich.Width = 100;
            // 
            // colNgayPhatDong
            // 
            this.colNgayPhatDong.Caption = "Ngày phát dộng";
            this.colNgayPhatDong.FieldName = "NgayPhatDong";
            this.colNgayPhatDong.MinWidth = 27;
            this.colNgayPhatDong.Name = "colNgayPhatDong";
            this.colNgayPhatDong.Visible = true;
            this.colNgayPhatDong.VisibleIndex = 2;
            this.colNgayPhatDong.Width = 100;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.Caption = "Ngày kết thúc";
            this.colNgayKetThuc.FieldName = "NgayKetThuc";
            this.colNgayKetThuc.MinWidth = 25;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Visible = true;
            this.colNgayKetThuc.VisibleIndex = 3;
            this.colNgayKetThuc.Width = 100;
            // 
            // FrmChienDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 795);
            this.Controls.Add(this.gcChienDich);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmChienDich";
            this.Text = "FrmTaoChienDich";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTaoChienDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDiaBanChuaCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiaBanChuaCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDiaBanChienDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDiaBanChienDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTaoChienDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChienDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChienDich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChienDich)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsChienDich;
        private DSTaoChienDich dSTaoChienDich;
        private DSTaoChienDichTableAdapters.ChienDichTableAdapter chienDichTableAdapter;
        private DSTaoChienDichTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcChienDich;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChienDich;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoaDiaBan;
        private DevExpress.XtraEditors.SimpleButton btnThemDiaBan;
        private DevExpress.XtraGrid.GridControl gcDiaBanChuaCo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiaBanChuaCo;
        private DevExpress.XtraGrid.GridControl gcDiaBanChienDich;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDiaBanChienDich;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChienDich;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChienDich;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayPhatDong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
    }
}