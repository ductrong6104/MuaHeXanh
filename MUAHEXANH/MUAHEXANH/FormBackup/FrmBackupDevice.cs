using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using MUAHEXANH.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class FrmBackupDevice : Form
    {
        private DataTable dt;
        private BindingSource bds;
        public FrmBackupDevice()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dt = new DataTable();
            bds = new BindingSource();

            this.dt = Program.ExecSqlDataTable("Exec Sp_DanhSachThietBiBackup");
            string[] names = { "Tên backup", "Đường dẫn", "Mô tả", "Trạng thái", "Loại", "Kích thước" };
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].ColumnName = names[i];
            }

            bds.DataSource = dt;
            gcBackup.DataSource = bds;
        }

        private void frmThietBiBackup_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmNhapLieuBackup f = new FrmNhapLieuBackup();
            f.ShowDialog();
            loadData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dt.Rows.Count <= 0)
            {
                Alert.ErrorMessageBox("Không thể xóa.");
                return;
            }
            DialogResult result1 = Alert.QuestionMessageBox("Xóa backup device.");
            if (result1 == DialogResult.Yes)
            {
                int finalResult;

                DataRowView dr = (DataRowView)gvBackup.GetFocusedRow();
                string tenBackup = dr["Tên backup"].ToString();
                
                DialogResult result2 = Alert.QuestionMessageBox("Xóa file backup.");
                if (result2 == DialogResult.Yes)
                {
                    string sql = $"EXEC [dbo].[sp_dropdevice] '{tenBackup}', 'delfile'";
                    finalResult = Program.ExecSqlNonQuery(sql);
                }
                else
                {
                    string sql = $"EXEC [dbo].[sp_dropdevice] '{tenBackup}'";
                    finalResult = Program.ExecSqlNonQuery(sql);
                }
                
                if(finalResult == 0)
                {
                    Alert.InfoMessageBox("Đã xóa");
                    int index = gvBackup.FocusedRowHandle;
                    loadData();
                    if(dt.Rows.Count <= index)
                    {
                        index = dt.Rows.Count - 1;
                    }
                    if(index >= 0)
                        gvBackup.FocusedRowHandle = index;
                }
                else
                {
                    Alert.ErrorMessageBox("Lỗi");

                }
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
