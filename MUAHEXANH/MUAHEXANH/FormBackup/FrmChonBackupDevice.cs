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
    public partial class FrmChonBackupDevice : Form
    {
        private DataTable dt;
        private void loadData()
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            dt = new DataTable();

            using (SqlCommand command = new SqlCommand("Sp_DanhSachThietBiBackup", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dt);
                }
            }

            this.dt = Program.ExecSqlDataTable("Exec Sp_DanhSachThietBiBackup");
            string[] names = { "Tên backup", "Đường dẫn", "Mô tả", "Trạng thái", "Loại", "Kích thước" };
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].ColumnName = names[i];
            }
            gcBackupDevice.DataSource = dt;
        }
        public FrmChonBackupDevice()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                DataRowView dr = (DataRowView)gvBackupDevice.GetFocusedRow();
                Program.backupDeviceName = dr["Tên backup"].ToString();
                this.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChonBackupDevice_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhapLieuBackup f = new FrmNhapLieuBackup();
            f.ShowDialog();
            loadData();
        }
    }
}
