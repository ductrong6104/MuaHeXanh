namespace MUAHEXANH.FormKhenThuong
{
    partial class frmKhenThuong
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNha = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenNhom = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnlDSSV = new DevExpress.XtraEditors.PanelControl();
            this.gcDSSV = new DevExpress.XtraGrid.GridControl();
            this.sp_laySinhVienTuNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSkhenThuong = new MUAHEXANH.DSkhenThuong();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmasv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheckNhomTruong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlSVKHENTHUONG = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sp_laySinhVienTuNhomTableAdapter = new MUAHEXANH.DSkhenThuongTableAdapters.sp_laySinhVienTuNhomTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSkhenThuongTableAdapters.TableAdapterManager();
            this.sp_laySinhVienKhenThuongTheoDoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter = new MUAHEXANH.DSkhenThuongTableAdapters.sp_laySinhVienKhenThuongTheoDoiTableAdapter();
            this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSSV)).BeginInit();
            this.pnlDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienTuNhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSkhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSVKHENTHUONG)).BeginInit();
            this.pnlSVKHENTHUONG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienKhenThuongTheoDoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.txtNha);
            this.panel1.Controls.Add(this.cmbTenNhom);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(676, 24);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 20);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Số nhà:";
            // 
            // txtNha
            // 
            this.txtNha.Location = new System.Drawing.Point(815, 22);
            this.txtNha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNha.Name = "txtNha";
            this.txtNha.Size = new System.Drawing.Size(285, 26);
            this.txtNha.TabIndex = 2;
            // 
            // cmbTenNhom
            // 
            this.cmbTenNhom.FormattingEnabled = true;
            this.cmbTenNhom.Location = new System.Drawing.Point(252, 19);
            this.cmbTenNhom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbTenNhom.Name = "cmbTenNhom";
            this.cmbTenNhom.Size = new System.Drawing.Size(280, 28);
            this.cmbTenNhom.TabIndex = 1;
            this.cmbTenNhom.Text = "tên nhóm";
            this.cmbTenNhom.SelectionChangeCommitted += new System.EventHandler(this.cmbTenNhom_SelectionChangeCommitted);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 24);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Chọn nhóm";
            // 
            // pnlDSSV
            // 
            this.pnlDSSV.Controls.Add(this.gcDSSV);
            this.pnlDSSV.Controls.Add(this.panelControl1);
            this.pnlDSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDSSV.Location = new System.Drawing.Point(0, 90);
            this.pnlDSSV.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlDSSV.Name = "pnlDSSV";
            this.pnlDSSV.Size = new System.Drawing.Size(800, 401);
            this.pnlDSSV.TabIndex = 1;
            // 
            // gcDSSV
            // 
            this.gcDSSV.DataSource = this.sp_laySinhVienTuNhomBindingSource;
            this.gcDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSSV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gcDSSV.Location = new System.Drawing.Point(2, 61);
            this.gcDSSV.MainView = this.gridView1;
            this.gcDSSV.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gcDSSV.Name = "gcDSSV";
            this.gcDSSV.Size = new System.Drawing.Size(796, 338);
            this.gcDSSV.TabIndex = 1;
            this.gcDSSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sp_laySinhVienTuNhomBindingSource
            // 
            this.sp_laySinhVienTuNhomBindingSource.DataMember = "sp_laySinhVienTuNhom";
            this.sp_laySinhVienTuNhomBindingSource.DataSource = this.dSkhenThuong;
            // 
            // dSkhenThuong
            // 
            this.dSkhenThuong.DataSetName = "DSkhenThuong";
            this.dSkhenThuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmasv,
            this.colhoten,
            this.colMaKhoa,
            this.colcheckNhomTruong});
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gcDSSV;
            this.gridView1.Name = "gridView1";
            // 
            // colmasv
            // 
            this.colmasv.FieldName = "masv";
            this.colmasv.MinWidth = 31;
            this.colmasv.Name = "colmasv";
            this.colmasv.Visible = true;
            this.colmasv.VisibleIndex = 0;
            this.colmasv.Width = 117;
            // 
            // colhoten
            // 
            this.colhoten.FieldName = "hoten";
            this.colhoten.MinWidth = 31;
            this.colhoten.Name = "colhoten";
            this.colhoten.Visible = true;
            this.colhoten.VisibleIndex = 1;
            this.colhoten.Width = 117;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.MinWidth = 31;
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 2;
            this.colMaKhoa.Width = 117;
            // 
            // colcheckNhomTruong
            // 
            this.colcheckNhomTruong.FieldName = "checkNhomTruong";
            this.colcheckNhomTruong.MinWidth = 31;
            this.colcheckNhomTruong.Name = "colcheckNhomTruong";
            this.colcheckNhomTruong.Visible = true;
            this.colcheckNhomTruong.VisibleIndex = 3;
            this.colcheckNhomTruong.Width = 117;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(796, 59);
            this.panelControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(268, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(307, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH SINH VIÊN TRONG ĐỘI:";
            // 
            // pnlSVKHENTHUONG
            // 
            this.pnlSVKHENTHUONG.Controls.Add(this.dataGridView1);
            this.pnlSVKHENTHUONG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSVKHENTHUONG.Location = new System.Drawing.Point(0, 491);
            this.pnlSVKHENTHUONG.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pnlSVKHENTHUONG.Name = "pnlSVKHENTHUONG";
            this.pnlSVKHENTHUONG.Size = new System.Drawing.Size(800, 157);
            this.pnlSVKHENTHUONG.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.lydoDataGridViewTextBoxColumn,
            this.danhhieuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sp_laySinhVienKhenThuongTheoDoiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(365, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // sp_laySinhVienTuNhomTableAdapter
            // 
            this.sp_laySinhVienTuNhomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSkhenThuongTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_laySinhVienKhenThuongTheoDoiBindingSource
            // 
            this.sp_laySinhVienKhenThuongTheoDoiBindingSource.DataMember = "sp_laySinhVienKhenThuongTheoDoi";
            this.sp_laySinhVienKhenThuongTheoDoiBindingSource.DataSource = this.dSkhenThuong;
            // 
            // sp_laySinhVienKhenThuongTheoDoiTableAdapter
            // 
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter.ClearBeforeFill = true;
            // 
            // masvDataGridViewTextBoxColumn
            // 
            this.masvDataGridViewTextBoxColumn.DataPropertyName = "masv";
            this.masvDataGridViewTextBoxColumn.HeaderText = "masv";
            this.masvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "hoten";
            this.hotenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            this.hotenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lydoDataGridViewTextBoxColumn
            // 
            this.lydoDataGridViewTextBoxColumn.DataPropertyName = "lydo";
            this.lydoDataGridViewTextBoxColumn.HeaderText = "lydo";
            this.lydoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lydoDataGridViewTextBoxColumn.Name = "lydoDataGridViewTextBoxColumn";
            // 
            // danhhieuDataGridViewTextBoxColumn
            // 
            this.danhhieuDataGridViewTextBoxColumn.DataPropertyName = "danhhieu";
            this.danhhieuDataGridViewTextBoxColumn.HeaderText = "danhhieu";
            this.danhhieuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.danhhieuDataGridViewTextBoxColumn.Name = "danhhieuDataGridViewTextBoxColumn";
            // 
            // frmKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.pnlSVKHENTHUONG);
            this.Controls.Add(this.pnlDSSV);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhenThuong";
            this.Text = "frmKhenThuong";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSSV)).EndInit();
            this.pnlDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienTuNhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSkhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSVKHENTHUONG)).EndInit();
            this.pnlSVKHENTHUONG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienKhenThuongTheoDoiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.PanelControl pnlDSSV;
        private DevExpress.XtraEditors.PanelControl pnlSVKHENTHUONG;
        private DevExpress.XtraGrid.GridControl gcDSSV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTenNhom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DSkhenThuong dSkhenThuong;
        private System.Windows.Forms.BindingSource sp_laySinhVienTuNhomBindingSource;
        private DSkhenThuongTableAdapters.sp_laySinhVienTuNhomTableAdapter sp_laySinhVienTuNhomTableAdapter;
        private DSkhenThuongTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colmasv;
        private DevExpress.XtraGrid.Columns.GridColumn colhoten;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colcheckNhomTruong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sp_laySinhVienKhenThuongTheoDoiBindingSource;
        private DSkhenThuongTableAdapters.sp_laySinhVienKhenThuongTheoDoiTableAdapter sp_laySinhVienKhenThuongTheoDoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhhieuDataGridViewTextBoxColumn;
    }
}