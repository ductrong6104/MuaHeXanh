namespace MUAHEXANH.FormTaoTaiKhoanCuaKhoa
{
    partial class frmVoHieuHoaTaiKhoanCuaKhoa
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
            this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dStaoTaiKhoan = new MUAHEXANH.DStaoTaiKhoan();
            this.cmbChonTK = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnVoHieuHoa = new DevExpress.XtraEditors.SimpleButton();
            this.sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter = new MUAHEXANH.DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager();
            this.pnlVoHieu = new DevExpress.XtraEditors.PanelControl();
            this.dgvTaiKhoanVoHieu = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlVoHieu)).BeginInit();
            this.pnlVoHieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanVoHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_lay_ds_taikhoan_chuavohieuhoaBindingSource
            // 
            this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource.DataMember = "sp_lay_ds_taikhoan_chuavohieuhoa";
            this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource.DataSource = this.dStaoTaiKhoan;
            // 
            // dStaoTaiKhoan
            // 
            this.dStaoTaiKhoan.DataSetName = "DStaoTaiKhoan";
            this.dStaoTaiKhoan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbChonTK
            // 
            this.cmbChonTK.FormattingEnabled = true;
            this.cmbChonTK.Items.AddRange(new object[] {
            "Giám sát",
            "Đội trưởng",
            "Đội phó",
            "Nhóm trưởng"});
            this.cmbChonTK.Location = new System.Drawing.Point(136, 33);
            this.cmbChonTK.Name = "cmbChonTK";
            this.cmbChonTK.Size = new System.Drawing.Size(185, 28);
            this.cmbChonTK.TabIndex = 1;
            this.cmbChonTK.SelectionChangeCommitted += new System.EventHandler(this.cmbChonTK_SelectionChangeCommitted);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 36);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Chọn quyền:";
            // 
            // btnVoHieuHoa
            // 
            this.btnVoHieuHoa.Location = new System.Drawing.Point(584, 198);
            this.btnVoHieuHoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoHieuHoa.Name = "btnVoHieuHoa";
            this.btnVoHieuHoa.Size = new System.Drawing.Size(165, 36);
            this.btnVoHieuHoa.TabIndex = 3;
            this.btnVoHieuHoa.Text = "Vô hiệu hóa";
            this.btnVoHieuHoa.Click += new System.EventHandler(this.btnVoHieuHoa_Click);
            // 
            // sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter
            // 
            this.sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pnlVoHieu
            // 
            this.pnlVoHieu.Controls.Add(this.dgvTaiKhoanVoHieu);
            this.pnlVoHieu.Controls.Add(this.panelControl1);
            this.pnlVoHieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVoHieu.Location = new System.Drawing.Point(0, 0);
            this.pnlVoHieu.Name = "pnlVoHieu";
            this.pnlVoHieu.Size = new System.Drawing.Size(525, 450);
            this.pnlVoHieu.TabIndex = 4;
            // 
            // dgvTaiKhoanVoHieu
            // 
            this.dgvTaiKhoanVoHieu.AllowUserToAddRows = false;
            this.dgvTaiKhoanVoHieu.AutoGenerateColumns = false;
            this.dgvTaiKhoanVoHieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanVoHieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoanVoHieu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTaiKhoanVoHieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanVoHieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvTaiKhoanVoHieu.DataSource = this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource;
            this.dgvTaiKhoanVoHieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoanVoHieu.Location = new System.Drawing.Point(2, 86);
            this.dgvTaiKhoanVoHieu.Name = "dgvTaiKhoanVoHieu";
            this.dgvTaiKhoanVoHieu.RowHeadersWidth = 51;
            this.dgvTaiKhoanVoHieu.RowTemplate.Height = 24;
            this.dgvTaiKhoanVoHieu.Size = new System.Drawing.Size(521, 362);
            this.dgvTaiKhoanVoHieu.TabIndex = 1;
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
            this.Column1.HeaderText = "Vô hiệu hóa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChonTK);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(521, 84);
            this.panelControl1.TabIndex = 0;
            // 
            // frmVoHieuHoaTaiKhoanCuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlVoHieu);
            this.Controls.Add(this.btnVoHieuHoa);
            this.Name = "frmVoHieuHoaTaiKhoanCuaKhoa";
            this.Text = "Vô hiệu hóa tài khoản";
            this.Load += new System.EventHandler(this.frmVoHieuHoaTaiKhoanCuaKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlVoHieu)).EndInit();
            this.pnlVoHieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanVoHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbChonTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnVoHieuHoa;
        private DStaoTaiKhoan dStaoTaiKhoan;
        private System.Windows.Forms.BindingSource sp_lay_ds_taikhoan_chuavohieuhoaBindingSource;
        private DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter;
        private DStaoTaiKhoanTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl pnlVoHieu;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvTaiKhoanVoHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}