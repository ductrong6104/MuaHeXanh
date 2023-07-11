namespace MUAHEXANH.FormTaoTaiKhoanCuaKhoa
{
    partial class frmKhoiPhucTaiKhoanCuaKhoa
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
            this.sp_lay_ds_taikhoan_vohieuhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dStaoTaiKhoan = new MUAHEXANH.DStaoTaiKhoan();
            this.btnKhoiPhuc = new DevExpress.XtraEditors.SimpleButton();
            this.cmbChonTK = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tableAdapterManager = new MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager();
            this.sp_lay_ds_taikhoan_vohieuhoaTableAdapter = new MUAHEXANH.DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_vohieuhoaTableAdapter();
            this.pnlKhoiPhuc = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvTaiKhoanKhoiPhuc = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_vohieuhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoiPhuc)).BeginInit();
            this.pnlKhoiPhuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanKhoiPhuc)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_lay_ds_taikhoan_vohieuhoaBindingSource
            // 
            this.sp_lay_ds_taikhoan_vohieuhoaBindingSource.DataMember = "sp_lay_ds_taikhoan_vohieuhoa";
            this.sp_lay_ds_taikhoan_vohieuhoaBindingSource.DataSource = this.dStaoTaiKhoan;
            // 
            // dStaoTaiKhoan
            // 
            this.dStaoTaiKhoan.DataSetName = "DStaoTaiKhoan";
            this.dStaoTaiKhoan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Location = new System.Drawing.Point(503, 185);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(133, 29);
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // cmbChonTK
            // 
            this.cmbChonTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChonTK.FormattingEnabled = true;
            this.cmbChonTK.Items.AddRange(new object[] {
            "Giám sát",
            "Đội trưởng ",
            "Đội phó",
            "Nhóm trưởng"});
            this.cmbChonTK.Location = new System.Drawing.Point(163, 18);
            this.cmbChonTK.Name = "cmbChonTK";
            this.cmbChonTK.Size = new System.Drawing.Size(193, 28);
            this.cmbChonTK.TabIndex = 2;
            this.cmbChonTK.SelectionChangeCommitted += new System.EventHandler(this.cmbChonTK_SelectionChangeCommitted);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Chọn tài khoản";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_lay_ds_taikhoan_vohieuhoaTableAdapter
            // 
            this.sp_lay_ds_taikhoan_vohieuhoaTableAdapter.ClearBeforeFill = true;
            // 
            // pnlKhoiPhuc
            // 
            this.pnlKhoiPhuc.Controls.Add(this.dgvTaiKhoanKhoiPhuc);
            this.pnlKhoiPhuc.Controls.Add(this.panelControl2);
            this.pnlKhoiPhuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKhoiPhuc.Location = new System.Drawing.Point(0, 0);
            this.pnlKhoiPhuc.Name = "pnlKhoiPhuc";
            this.pnlKhoiPhuc.Size = new System.Drawing.Size(433, 450);
            this.pnlKhoiPhuc.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbChonTK);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(429, 68);
            this.panelControl2.TabIndex = 5;
            // 
            // dgvTaiKhoanKhoiPhuc
            // 
            this.dgvTaiKhoanKhoiPhuc.AllowUserToAddRows = false;
            this.dgvTaiKhoanKhoiPhuc.AutoGenerateColumns = false;
            this.dgvTaiKhoanKhoiPhuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanKhoiPhuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoanKhoiPhuc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTaiKhoanKhoiPhuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanKhoiPhuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvTaiKhoanKhoiPhuc.DataSource = this.sp_lay_ds_taikhoan_vohieuhoaBindingSource;
            this.dgvTaiKhoanKhoiPhuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoanKhoiPhuc.Location = new System.Drawing.Point(2, 70);
            this.dgvTaiKhoanKhoiPhuc.Name = "dgvTaiKhoanKhoiPhuc";
            this.dgvTaiKhoanKhoiPhuc.RowHeadersWidth = 51;
            this.dgvTaiKhoanKhoiPhuc.RowTemplate.Height = 24;
            this.dgvTaiKhoanKhoiPhuc.Size = new System.Drawing.Size(429, 378);
            this.dgvTaiKhoanKhoiPhuc.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Khôi phục";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // frmKhoiPhucTaiKhoanCuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlKhoiPhuc);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Name = "frmKhoiPhucTaiKhoanCuaKhoa";
            this.Text = "Khôi phục tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhoiPhucTaiKhoanCuaKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_vohieuhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlKhoiPhuc)).EndInit();
            this.pnlKhoiPhuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanKhoiPhuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKhoiPhuc;
        private DStaoTaiKhoan dStaoTaiKhoan;
        private DStaoTaiKhoanTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sp_lay_ds_taikhoan_vohieuhoaBindingSource;
        private DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_vohieuhoaTableAdapter sp_lay_ds_taikhoan_vohieuhoaTableAdapter;
        private System.Windows.Forms.ComboBox cmbChonTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnlKhoiPhuc;
        private System.Windows.Forms.DataGridView dgvTaiKhoanKhoiPhuc;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}