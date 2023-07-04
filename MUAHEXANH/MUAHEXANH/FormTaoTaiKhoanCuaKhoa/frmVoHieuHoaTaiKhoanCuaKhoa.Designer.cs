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
            this.dgvTaiKhoanVoHieu = new System.Windows.Forms.DataGridView();
            this.VoHieu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbChonTK = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnVoHieuHoa = new DevExpress.XtraEditors.SimpleButton();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dStaoTaiKhoan = new MUAHEXANH.DStaoTaiKhoan();
            this.sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter = new MUAHEXANH.DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanVoHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).BeginInit();
            this.SuspendLayout();
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
            this.VoHieu});
            this.dgvTaiKhoanVoHieu.DataSource = this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource;
            this.dgvTaiKhoanVoHieu.Location = new System.Drawing.Point(74, 172);
            this.dgvTaiKhoanVoHieu.Name = "dgvTaiKhoanVoHieu";
            this.dgvTaiKhoanVoHieu.RowHeadersWidth = 51;
            this.dgvTaiKhoanVoHieu.RowTemplate.Height = 24;
            this.dgvTaiKhoanVoHieu.Size = new System.Drawing.Size(395, 150);
            this.dgvTaiKhoanVoHieu.TabIndex = 0;
            // 
            // VoHieu
            // 
            this.VoHieu.HeaderText = "Vô hiệu hóa";
            this.VoHieu.MinimumWidth = 6;
            this.VoHieu.Name = "VoHieu";
            this.VoHieu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VoHieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmbChonTK
            // 
            this.cmbChonTK.FormattingEnabled = true;
            this.cmbChonTK.Items.AddRange(new object[] {
            "Giám sát",
            "Đội trưởng",
            "Đội phó"});
            this.cmbChonTK.Location = new System.Drawing.Point(255, 72);
            this.cmbChonTK.Name = "cmbChonTK";
            this.cmbChonTK.Size = new System.Drawing.Size(185, 24);
            this.cmbChonTK.TabIndex = 1;
            this.cmbChonTK.SelectionChangeCommitted += new System.EventHandler(this.cmbChonTK_SelectionChangeCommitted);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(140, 72);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Chọn quyền:";
            // 
            // btnVoHieuHoa
            // 
            this.btnVoHieuHoa.Location = new System.Drawing.Point(584, 198);
            this.btnVoHieuHoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnVoHieuHoa.Name = "btnVoHieuHoa";
            this.btnVoHieuHoa.Size = new System.Drawing.Size(165, 36);
            this.btnVoHieuHoa.TabIndex = 3;
            this.btnVoHieuHoa.Text = "Vô hiệu hóa";
            this.btnVoHieuHoa.Click += new System.EventHandler(this.btnVoHieuHoa_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // frmVoHieuHoaTaiKhoanCuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoHieuHoa);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbChonTK);
            this.Controls.Add(this.dgvTaiKhoanVoHieu);
            this.Name = "frmVoHieuHoaTaiKhoanCuaKhoa";
            this.Text = "frmVoHieuHoaTaiKhoanCuaKhoa";
            this.Load += new System.EventHandler(this.frmVoHieuHoaTaiKhoanCuaKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanVoHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_chuavohieuhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoanVoHieu;
        private System.Windows.Forms.ComboBox cmbChonTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnVoHieuHoa;
        private DStaoTaiKhoan dStaoTaiKhoan;
        private System.Windows.Forms.BindingSource sp_lay_ds_taikhoan_chuavohieuhoaBindingSource;
        private DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter sp_lay_ds_taikhoan_chuavohieuhoaTableAdapter;
        private DStaoTaiKhoanTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn VoHieu;
    }
}