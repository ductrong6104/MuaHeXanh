namespace MUAHEXANH.FormKhenThuong
{
    partial class frmDanhHieu
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDanhHieu = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoiDung = new DevExpress.XtraEditors.TextEdit();
            this.dSkhenThuong = new MUAHEXANH.DSkhenThuong();
            this.sp_laySinhVienKhenThuongTheoDoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter = new MUAHEXANH.DSkhenThuongTableAdapters.sp_laySinhVienKhenThuongTheoDoiTableAdapter();
            this.tableAdapterManager = new MUAHEXANH.DSkhenThuongTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSkhenThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienKhenThuongTheoDoiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(118, 94);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn danh hiệu:";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Appearance.Options.UseBackColor = true;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(420, 230);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 29);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Location = new System.Drawing.Point(227, 230);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbDanhHieu
            // 
            this.cmbDanhHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanhHieu.FormattingEnabled = true;
            this.cmbDanhHieu.Items.AddRange(new object[] {
            "Năng động sáng tạo",
            "Lao động tích cực",
            "Hăng hài trong công việc",
            "Chăm chỉ miệt mài"});
            this.cmbDanhHieu.Location = new System.Drawing.Point(272, 94);
            this.cmbDanhHieu.Name = "cmbDanhHieu";
            this.cmbDanhHieu.Size = new System.Drawing.Size(303, 24);
            this.cmbDanhHieu.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(70, 153);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(166, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nội dung khen thưởng:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(272, 150);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(303, 26);
            this.txtNoiDung.TabIndex = 6;
            // 
            // dSkhenThuong
            // 
            this.dSkhenThuong.DataSetName = "DSkhenThuong";
            this.dSkhenThuong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KhenThuongTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MUAHEXANH.DSkhenThuongTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDanhHieu
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cmbDanhHieu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDanhHieu";
            this.Text = "frmDanhHieu";
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSkhenThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_laySinhVienKhenThuongTheoDoiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.ComboBox cmbDanhHieu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNoiDung;
        private DSkhenThuong dSkhenThuong;
        private System.Windows.Forms.BindingSource sp_laySinhVienKhenThuongTheoDoiBindingSource;
        private DSkhenThuongTableAdapters.sp_laySinhVienKhenThuongTheoDoiTableAdapter sp_laySinhVienKhenThuongTheoDoiTableAdapter;
        private DSkhenThuongTableAdapters.TableAdapterManager tableAdapterManager;
    }
}