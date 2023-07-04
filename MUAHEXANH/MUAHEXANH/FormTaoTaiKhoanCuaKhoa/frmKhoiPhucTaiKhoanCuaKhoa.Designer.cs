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
            this.dgvTaiKhoanKhoiPhuc = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new DevExpress.XtraEditors.SimpleButton();
            this.khoiPhuc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbChonTK = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_lay_ds_taikhoan_vohieuhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dStaoTaiKhoan = new MUAHEXANH.DStaoTaiKhoan();
            this.tableAdapterManager = new MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager();
            this.sp_lay_ds_taikhoan_vohieuhoaTableAdapter = new MUAHEXANH.DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_vohieuhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanKhoiPhuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_vohieuhoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaiKhoanKhoiPhuc
            // 
            this.dgvTaiKhoanKhoiPhuc.AllowUserToAddRows = false;
            this.dgvTaiKhoanKhoiPhuc.AutoGenerateColumns = false;
            this.dgvTaiKhoanKhoiPhuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanKhoiPhuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoanKhoiPhuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoanKhoiPhuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanKhoiPhuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.khoiPhuc});
            this.dgvTaiKhoanKhoiPhuc.DataSource = this.sp_lay_ds_taikhoan_vohieuhoaBindingSource;
            this.dgvTaiKhoanKhoiPhuc.Location = new System.Drawing.Point(68, 138);
            this.dgvTaiKhoanKhoiPhuc.Name = "dgvTaiKhoanKhoiPhuc";
            this.dgvTaiKhoanKhoiPhuc.RowHeadersWidth = 51;
            this.dgvTaiKhoanKhoiPhuc.RowTemplate.Height = 24;
            this.dgvTaiKhoanKhoiPhuc.Size = new System.Drawing.Size(441, 150);
            this.dgvTaiKhoanKhoiPhuc.TabIndex = 0;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Location = new System.Drawing.Point(551, 191);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(133, 29);
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // khoiPhuc
            // 
            this.khoiPhuc.HeaderText = "Khôi phục";
            this.khoiPhuc.MinimumWidth = 6;
            this.khoiPhuc.Name = "khoiPhuc";
            // 
            // cmbChonTK
            // 
            this.cmbChonTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChonTK.FormattingEnabled = true;
            this.cmbChonTK.Items.AddRange(new object[] {
            "Giám sát",
            "Đội trưởng ",
            "Đội phó"});
            this.cmbChonTK.Location = new System.Drawing.Point(202, 54);
            this.cmbChonTK.Name = "cmbChonTK";
            this.cmbChonTK.Size = new System.Drawing.Size(121, 24);
            this.cmbChonTK.TabIndex = 2;
            this.cmbChonTK.SelectionChangeCommitted += new System.EventHandler(this.cmbChonTK_SelectionChangeCommitted);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Chọn tài khoản";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // frmKhoiPhucTaiKhoanCuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmbChonTK);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.dgvTaiKhoanKhoiPhuc);
            this.Name = "frmKhoiPhucTaiKhoanCuaKhoa";
            this.Text = "frmKhoiPhucTaiKhoanCuaKhoa";
            this.Load += new System.EventHandler(this.frmKhoiPhucTaiKhoanCuaKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanKhoiPhuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoan_vohieuhoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaiKhoanKhoiPhuc;
        private DevExpress.XtraEditors.SimpleButton btnKhoiPhuc;
        private DStaoTaiKhoan dStaoTaiKhoan;
        private DStaoTaiKhoanTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sp_lay_ds_taikhoan_vohieuhoaBindingSource;
        private DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoan_vohieuhoaTableAdapter sp_lay_ds_taikhoan_vohieuhoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn khoiPhuc;
        private System.Windows.Forms.ComboBox cmbChonTK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}