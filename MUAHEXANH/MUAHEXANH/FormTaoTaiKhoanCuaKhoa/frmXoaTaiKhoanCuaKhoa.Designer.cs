namespace MUAHEXANH.FormTaoTaiKhoanCuaKhoa
{
    partial class frmXoaTaiKhoanCuaKhoa
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
            this.cmbChonTK = new System.Windows.Forms.ComboBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.dStaoTaiKhoan = new MUAHEXANH.DStaoTaiKhoan();
            this.sp_lay_ds_taikhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_lay_ds_taikhoanTableAdapter = new MUAHEXANH.DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoanTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dgvTaiKhoanXoa = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chonXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbChonTK
            // 
            this.cmbChonTK.FormattingEnabled = true;
            this.cmbChonTK.Items.AddRange(new object[] {
            "Giám sát",
            "Đội trưởng ",
            "Đội phó",
            "Nhóm trưởng"});
            this.cmbChonTK.Location = new System.Drawing.Point(153, 19);
            this.cmbChonTK.Name = "cmbChonTK";
            this.cmbChonTK.Size = new System.Drawing.Size(194, 28);
            this.cmbChonTK.TabIndex = 0;
            this.cmbChonTK.SelectionChangeCommitted += new System.EventHandler(this.cmbChonTK_SelectionChangeCommitted);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(464, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dStaoTaiKhoan
            // 
            this.dStaoTaiKhoan.DataSetName = "DStaoTaiKhoan";
            this.dStaoTaiKhoan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_lay_ds_taikhoanBindingSource
            // 
            this.sp_lay_ds_taikhoanBindingSource.DataMember = "sp_lay_ds_taikhoan";
            this.sp_lay_ds_taikhoanBindingSource.DataSource = this.dStaoTaiKhoan;
            // 
            // sp_lay_ds_taikhoanTableAdapter
            // 
            this.sp_lay_ds_taikhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DStaoTaiKhoanTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 20);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Chọn quyền:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgvTaiKhoanXoa);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(383, 450);
            this.panelControl1.TabIndex = 4;
            // 
            // dgvTaiKhoanXoa
            // 
            this.dgvTaiKhoanXoa.AllowUserToAddRows = false;
            this.dgvTaiKhoanXoa.AutoGenerateColumns = false;
            this.dgvTaiKhoanXoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanXoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTaiKhoanXoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTaiKhoanXoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanXoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.chonXoa});
            this.dgvTaiKhoanXoa.DataSource = this.sp_lay_ds_taikhoanBindingSource;
            this.dgvTaiKhoanXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoanXoa.Location = new System.Drawing.Point(2, 76);
            this.dgvTaiKhoanXoa.Name = "dgvTaiKhoanXoa";
            this.dgvTaiKhoanXoa.RowHeadersWidth = 51;
            this.dgvTaiKhoanXoa.RowTemplate.Height = 24;
            this.dgvTaiKhoanXoa.Size = new System.Drawing.Size(379, 372);
            this.dgvTaiKhoanXoa.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chonXoa
            // 
            this.chonXoa.HeaderText = "Chọn xóa";
            this.chonXoa.MinimumWidth = 6;
            this.chonXoa.Name = "chonXoa";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmbChonTK);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(379, 74);
            this.panelControl2.TabIndex = 4;
            // 
            // frmXoaTaiKhoanCuaKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnXoa);
            this.Name = "frmXoaTaiKhoanCuaKhoa";
            this.Text = "Xóa tài khoản";
            this.Load += new System.EventHandler(this.frmXoaTaiKhoanCuaKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dStaoTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_lay_ds_taikhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChonTK;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DStaoTaiKhoan dStaoTaiKhoan;
        private System.Windows.Forms.BindingSource sp_lay_ds_taikhoanBindingSource;
        private DStaoTaiKhoanTableAdapters.sp_lay_ds_taikhoanTableAdapter sp_lay_ds_taikhoanTableAdapter;
        private DStaoTaiKhoanTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvTaiKhoanXoa;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chonXoa;
    }
}