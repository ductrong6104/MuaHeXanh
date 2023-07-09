namespace MUAHEXANH.FormXemThoiGianCV
{
    partial class frmXemThoiGianLamViec
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
            this.pnlFilterTheoNgay = new DevExpress.XtraEditors.PanelControl();
            this.deNgay = new DevExpress.XtraEditors.DateEdit();
            this.lblNgay = new DevExpress.XtraEditors.LabelControl();
            this.pnlDSCV = new DevExpress.XtraEditors.PanelControl();
            this.gcDSCV = new DevExpress.XtraGrid.GridControl();
            this.sp_xemThoiGianLamViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSxemThoiGianLamViec = new MUAHEXANH.DSxemThoiGianLamViec();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenAp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_xemThoiGianLamViecTableAdapter = new MUAHEXANH.DSxemThoiGianLamViecTableAdapters.sp_xemThoiGianLamViecTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSxemThoiGianLamViecTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterTheoNgay)).BeginInit();
            this.pnlFilterTheoNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSCV)).BeginInit();
            this.pnlDSCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_xemThoiGianLamViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSxemThoiGianLamViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilterTheoNgay
            // 
            this.pnlFilterTheoNgay.Controls.Add(this.deNgay);
            this.pnlFilterTheoNgay.Controls.Add(this.lblNgay);
            this.pnlFilterTheoNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterTheoNgay.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterTheoNgay.Name = "pnlFilterTheoNgay";
            this.pnlFilterTheoNgay.Size = new System.Drawing.Size(800, 56);
            this.pnlFilterTheoNgay.TabIndex = 0;
            // 
            // deNgay
            // 
            this.deNgay.EditValue = null;
            this.deNgay.Location = new System.Drawing.Point(143, 12);
            this.deNgay.Name = "deNgay";
            this.deNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Size = new System.Drawing.Size(216, 26);
            this.deNgay.TabIndex = 2;
            this.deNgay.DateTimeChanged += new System.EventHandler(this.deNgay_DateTimeChanged);
            // 
            // lblNgay
            // 
            this.lblNgay.Location = new System.Drawing.Point(35, 15);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(82, 20);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "Chọn ngày:";
            // 
            // pnlDSCV
            // 
            this.pnlDSCV.Controls.Add(this.gcDSCV);
            this.pnlDSCV.Controls.Add(this.panelControl3);
            this.pnlDSCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDSCV.Location = new System.Drawing.Point(0, 56);
            this.pnlDSCV.Name = "pnlDSCV";
            this.pnlDSCV.Size = new System.Drawing.Size(800, 394);
            this.pnlDSCV.TabIndex = 1;
            // 
            // gcDSCV
            // 
            this.gcDSCV.DataSource = this.sp_xemThoiGianLamViecBindingSource;
            this.gcDSCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSCV.Location = new System.Drawing.Point(2, 55);
            this.gcDSCV.MainView = this.gridView1;
            this.gcDSCV.Name = "gcDSCV";
            this.gcDSCV.Size = new System.Drawing.Size(796, 337);
            this.gcDSCV.TabIndex = 1;
            this.gcDSCV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sp_xemThoiGianLamViecBindingSource
            // 
            this.sp_xemThoiGianLamViecBindingSource.DataMember = "sp_xemThoiGianLamViec";
            this.sp_xemThoiGianLamViecBindingSource.DataSource = this.dSxemThoiGianLamViec;
            // 
            // dSxemThoiGianLamViec
            // 
            this.dSxemThoiGianLamViec.DataSetName = "DSxemThoiGianLamViec";
            this.dSxemThoiGianLamViec.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenCV,
            this.colbuoi,
            this.colTenAp});
            this.gridView1.GridControl = this.gcDSCV;
            this.gridView1.Name = "gridView1";
            // 
            // colTenCV
            // 
            this.colTenCV.FieldName = "TenCV";
            this.colTenCV.MinWidth = 25;
            this.colTenCV.Name = "colTenCV";
            this.colTenCV.Visible = true;
            this.colTenCV.VisibleIndex = 0;
            this.colTenCV.Width = 94;
            // 
            // colbuoi
            // 
            this.colbuoi.FieldName = "buoi";
            this.colbuoi.MinWidth = 25;
            this.colbuoi.Name = "colbuoi";
            this.colbuoi.Visible = true;
            this.colbuoi.VisibleIndex = 1;
            this.colbuoi.Width = 94;
            // 
            // colTenAp
            // 
            this.colTenAp.FieldName = "TenAp";
            this.colTenAp.MinWidth = 25;
            this.colTenAp.Name = "colTenAp";
            this.colTenAp.Visible = true;
            this.colTenAp.VisibleIndex = 2;
            this.colTenAp.Width = 94;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(796, 53);
            this.panelControl3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DANH SÁCH CÔNG VIỆC CỦA NHÓM: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "lblTenNhom";
            // 
            // sp_xemThoiGianLamViecTableAdapter
            // 
            this.sp_xemThoiGianLamViecTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PhanCongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSxemThoiGianLamViecTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmXemThoiGianLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDSCV);
            this.Controls.Add(this.pnlFilterTheoNgay);
            this.Name = "frmXemThoiGianLamViec";
            this.Text = "Xem thời gian làm việc";
            this.Load += new System.EventHandler(this.frmXemThoiGianLamViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterTheoNgay)).EndInit();
            this.pnlFilterTheoNgay.ResumeLayout(false);
            this.pnlFilterTheoNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSCV)).EndInit();
            this.pnlDSCV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_xemThoiGianLamViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSxemThoiGianLamViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlFilterTheoNgay;
        private DevExpress.XtraEditors.PanelControl pnlDSCV;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gcDSCV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lblNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit deNgay;
        private DSxemThoiGianLamViec dSxemThoiGianLamViec;
        private System.Windows.Forms.BindingSource sp_xemThoiGianLamViecBindingSource;
        private DSxemThoiGianLamViecTableAdapters.sp_xemThoiGianLamViecTableAdapter sp_xemThoiGianLamViecTableAdapter;
        private DSxemThoiGianLamViecTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn colbuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenAp;
    }
}