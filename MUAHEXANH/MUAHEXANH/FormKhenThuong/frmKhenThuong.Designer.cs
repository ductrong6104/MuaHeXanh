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
            this.txtSoNha = new DevExpress.XtraEditors.TextEdit();
            this.sp_lay_nhom_tu_doiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSkhenThuong = new MUAHEXANH.DSkhenThuong();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbTenNhom = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnlDSSV = new DevExpress.XtraEditors.PanelControl();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.masvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkNhomTruongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_laySinhVienTuNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTenDoi = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlSVKHENTHUONG = new DevExpress.XtraEditors.PanelControl();
            this.dgvDSKhenThuong = new System.Windows.Forms.DataGridView();
            this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhhieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_laySinhVienKhenThuongTheoDoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_laySinhVienTuNhomTableAdapter = new MUAHEXANH.DSkhenThuongTableAdapters.sp_laySinhVienTuNhomTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSkhenThuongTableAdapters.TableAdapterManager();
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter = new MUAHEXANH.DSkhenThuongTableAdapters.sp_laySinhVienKhenThuongTheoDoiTableAdapter();
            this.sp_lay_nhom_tu_doiTableAdapter = new MUAHEXANH.DSkhenThuongTableAdapters.sp_lay_nhom_tu_doiTableAdapter();
            this.cmsThemKhenThuong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnKhenThuong = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXoaKhenThuong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaKhỏiKhenThưởngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_nhom_tu_doiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSkhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSSV)).BeginInit();
            this.pnlDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienTuNhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSVKHENTHUONG)).BeginInit();
            this.pnlSVKHENTHUONG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienKhenThuongTheoDoiBindingSource)).BeginInit();
            this.cmsThemKhenThuong.SuspendLayout();
            this.cmsXoaKhenThuong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoNha);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.cmbTenNhom);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 90);
            this.panel1.TabIndex = 0;
            // 
            // txtSoNha
            // 
            this.txtSoNha.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sp_lay_nhom_tu_doiBindingSource, "diachi", true));
            this.txtSoNha.Location = new System.Drawing.Point(598, 23);
            this.txtSoNha.Name = "txtSoNha";
            this.txtSoNha.Properties.ReadOnly = true;
            this.txtSoNha.Size = new System.Drawing.Size(343, 26);
            this.txtSoNha.TabIndex = 6;
            // 
            // sp_lay_nhom_tu_doiBindingSource
            // 
            this.sp_lay_nhom_tu_doiBindingSource.DataMember = "sp_lay_nhom_tu_doi";
            this.sp_lay_nhom_tu_doiBindingSource.DataSource = this.dSkhenThuong;
            // 
            // dSkhenThuong
            // 
            this.dSkhenThuong.DataSetName = "DSkhenThuong";
            this.dSkhenThuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(1138, 21);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 20);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Nhóm trưởng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(1105, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(524, 25);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 20);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Số nhà:";
            // 
            // cmbTenNhom
            // 
            this.cmbTenNhom.DataSource = this.sp_lay_nhom_tu_doiBindingSource;
            this.cmbTenNhom.DisplayMember = "TENNHOM";
            this.cmbTenNhom.FormattingEnabled = true;
            this.cmbTenNhom.Location = new System.Drawing.Point(161, 21);
            this.cmbTenNhom.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTenNhom.Name = "cmbTenNhom";
            this.cmbTenNhom.Size = new System.Drawing.Size(280, 28);
            this.cmbTenNhom.TabIndex = 1;
            this.cmbTenNhom.ValueMember = "MANHOM";
            this.cmbTenNhom.SelectionChangeCommitted += new System.EventHandler(this.cmbTenNhom_SelectionChangeCommitted);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 24);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Chọn nhóm";
            // 
            // pnlDSSV
            // 
            this.pnlDSSV.Controls.Add(this.dgvDSSV);
            this.pnlDSSV.Controls.Add(this.panelControl1);
            this.pnlDSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDSSV.Location = new System.Drawing.Point(0, 90);
            this.pnlDSSV.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDSSV.Name = "pnlDSSV";
            this.pnlDSSV.Size = new System.Drawing.Size(1500, 302);
            this.pnlDSSV.TabIndex = 1;
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AllowUserToAddRows = false;
            this.dgvDSSV.AutoGenerateColumns = false;
            this.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSSV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvDataGridViewTextBoxColumn1,
            this.hotenDataGridViewTextBoxColumn1,
            this.maKhoaDataGridViewTextBoxColumn,
            this.checkNhomTruongDataGridViewTextBoxColumn});
            this.dgvDSSV.DataSource = this.sp_laySinhVienTuNhomBindingSource;
            this.dgvDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSV.Location = new System.Drawing.Point(2, 61);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.Size = new System.Drawing.Size(1496, 239);
            this.dgvDSSV.TabIndex = 1;
            this.dgvDSSV.Sorted += new System.EventHandler(this.dgvDSSV_Sorted);
            // 
            // masvDataGridViewTextBoxColumn1
            // 
            this.masvDataGridViewTextBoxColumn1.DataPropertyName = "masv";
            this.masvDataGridViewTextBoxColumn1.HeaderText = "masv";
            this.masvDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.masvDataGridViewTextBoxColumn1.Name = "masvDataGridViewTextBoxColumn1";
            this.masvDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hotenDataGridViewTextBoxColumn1
            // 
            this.hotenDataGridViewTextBoxColumn1.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn1.HeaderText = "hoten";
            this.hotenDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hotenDataGridViewTextBoxColumn1.Name = "hotenDataGridViewTextBoxColumn1";
            this.hotenDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkNhomTruongDataGridViewTextBoxColumn
            // 
            this.checkNhomTruongDataGridViewTextBoxColumn.DataPropertyName = "checkNhomTruong";
            this.checkNhomTruongDataGridViewTextBoxColumn.HeaderText = "checkNhomTruong";
            this.checkNhomTruongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkNhomTruongDataGridViewTextBoxColumn.Name = "checkNhomTruongDataGridViewTextBoxColumn";
            this.checkNhomTruongDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkNhomTruongDataGridViewTextBoxColumn.Visible = false;
            // 
            // sp_laySinhVienTuNhomBindingSource
            // 
            this.sp_laySinhVienTuNhomBindingSource.DataMember = "sp_laySinhVienTuNhom";
            this.sp_laySinhVienTuNhomBindingSource.DataSource = this.dSkhenThuong;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblTenDoi);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1496, 59);
            this.panelControl1.TabIndex = 0;
            // 
            // lblTenDoi
            // 
            this.lblTenDoi.AutoSize = true;
            this.lblTenDoi.Location = new System.Drawing.Point(629, 26);
            this.lblTenDoi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenDoi.Name = "lblTenDoi";
            this.lblTenDoi.Size = new System.Drawing.Size(51, 20);
            this.lblTenDoi.TabIndex = 1;
            this.lblTenDoi.Text = "label1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(268, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(307, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "DANH SÁCH SINH VIÊN TRONG ĐỘI:";
            // 
            // pnlSVKHENTHUONG
            // 
            this.pnlSVKHENTHUONG.Controls.Add(this.dgvDSKhenThuong);
            this.pnlSVKHENTHUONG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSVKHENTHUONG.Location = new System.Drawing.Point(0, 392);
            this.pnlSVKHENTHUONG.Margin = new System.Windows.Forms.Padding(10);
            this.pnlSVKHENTHUONG.Name = "pnlSVKHENTHUONG";
            this.pnlSVKHENTHUONG.Size = new System.Drawing.Size(1500, 256);
            this.pnlSVKHENTHUONG.TabIndex = 2;
            // 
            // dgvDSKhenThuong
            // 
            this.dgvDSKhenThuong.AllowUserToAddRows = false;
            this.dgvDSKhenThuong.AutoGenerateColumns = false;
            this.dgvDSKhenThuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSKhenThuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSKhenThuong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSKhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhenThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.lydoDataGridViewTextBoxColumn,
            this.danhhieuDataGridViewTextBoxColumn});
            this.dgvDSKhenThuong.DataSource = this.sp_laySinhVienKhenThuongTheoDoiBindingSource;
            this.dgvDSKhenThuong.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvDSKhenThuong.Location = new System.Drawing.Point(844, 2);
            this.dgvDSKhenThuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSKhenThuong.Name = "dgvDSKhenThuong";
            this.dgvDSKhenThuong.RowHeadersWidth = 51;
            this.dgvDSKhenThuong.RowTemplate.Height = 24;
            this.dgvDSKhenThuong.Size = new System.Drawing.Size(654, 252);
            this.dgvDSKhenThuong.TabIndex = 0;
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
            // sp_laySinhVienKhenThuongTheoDoiBindingSource
            // 
            this.sp_laySinhVienKhenThuongTheoDoiBindingSource.DataMember = "sp_laySinhVienKhenThuongTheoDoi";
            this.sp_laySinhVienKhenThuongTheoDoiBindingSource.DataSource = this.dSkhenThuong;
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
            // sp_laySinhVienKhenThuongTheoDoiTableAdapter
            // 
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter.ClearBeforeFill = true;
            // 
            // sp_lay_nhom_tu_doiTableAdapter
            // 
            this.sp_lay_nhom_tu_doiTableAdapter.ClearBeforeFill = true;
            // 
            // cmsThemKhenThuong
            // 
            this.cmsThemKhenThuong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsThemKhenThuong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKhenThuong});
            this.cmsThemKhenThuong.Name = "cmsThemKhenThuong";
            this.cmsThemKhenThuong.Size = new System.Drawing.Size(164, 28);
            // 
            // btnKhenThuong
            // 
            this.btnKhenThuong.Name = "btnKhenThuong";
            this.btnKhenThuong.Size = new System.Drawing.Size(163, 24);
            this.btnKhenThuong.Text = "Khen thưởng";
            this.btnKhenThuong.Click += new System.EventHandler(this.khenThưởngToolStripMenuItem_Click);
            // 
            // cmsXoaKhenThuong
            // 
            this.cmsXoaKhenThuong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsXoaKhenThuong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaKhỏiKhenThưởngToolStripMenuItem});
            this.cmsXoaKhenThuong.Name = "cmsXoaKhenThuong";
            this.cmsXoaKhenThuong.Size = new System.Drawing.Size(224, 28);
            // 
            // xóaKhỏiKhenThưởngToolStripMenuItem
            // 
            this.xóaKhỏiKhenThưởngToolStripMenuItem.Name = "xóaKhỏiKhenThưởngToolStripMenuItem";
            this.xóaKhỏiKhenThưởngToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.xóaKhỏiKhenThưởngToolStripMenuItem.Text = "Xóa khỏi khen thưởng";
            // 
            // frmKhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 648);
            this.Controls.Add(this.pnlSVKHENTHUONG);
            this.Controls.Add(this.pnlDSSV);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhenThuong";
            this.Text = "frmKhenThuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoNha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_nhom_tu_doiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSkhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDSSV)).EndInit();
            this.pnlDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienTuNhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSVKHENTHUONG)).EndInit();
            this.pnlSVKHENTHUONG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienKhenThuongTheoDoiBindingSource)).EndInit();
            this.cmsThemKhenThuong.ResumeLayout(false);
            this.cmsXoaKhenThuong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.PanelControl pnlDSSV;
        private DevExpress.XtraEditors.PanelControl pnlSVKHENTHUONG;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label lblTenDoi;
        private System.Windows.Forms.ComboBox cmbTenNhom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DSkhenThuong dSkhenThuong;
        private System.Windows.Forms.BindingSource sp_laySinhVienTuNhomBindingSource;
        private DSkhenThuongTableAdapters.sp_laySinhVienTuNhomTableAdapter sp_laySinhVienTuNhomTableAdapter;
        private DSkhenThuongTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvDSKhenThuong;
        private System.Windows.Forms.BindingSource sp_laySinhVienKhenThuongTheoDoiBindingSource;
        private DSkhenThuongTableAdapters.sp_laySinhVienKhenThuongTheoDoiTableAdapter sp_laySinhVienKhenThuongTheoDoiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn danhhieuDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtSoNha;
        private System.Windows.Forms.BindingSource sp_lay_nhom_tu_doiBindingSource;
        private DSkhenThuongTableAdapters.sp_lay_nhom_tu_doiTableAdapter sp_lay_nhom_tu_doiTableAdapter;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkNhomTruongDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsThemKhenThuong;
        private System.Windows.Forms.ToolStripMenuItem btnKhenThuong;
        private System.Windows.Forms.ContextMenuStrip cmsXoaKhenThuong;
        private System.Windows.Forms.ToolStripMenuItem xóaKhỏiKhenThưởngToolStripMenuItem;
    }
}