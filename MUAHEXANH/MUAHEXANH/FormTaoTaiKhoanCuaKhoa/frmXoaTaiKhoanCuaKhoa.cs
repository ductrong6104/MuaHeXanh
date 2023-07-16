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

namespace MUAHEXANH.FormTaoTaiKhoanCuaKhoa
{
    public partial class frmXoaTaiKhoanCuaKhoa : Form
    {
        private string role;
        public frmXoaTaiKhoanCuaKhoa()
        {
            InitializeComponent();
        }

        private void frmXoaTaiKhoanCuaKhoa_Load(object sender, EventArgs e)
        {
            cmbChonTK.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'dStaoTaiKhoan.sp_lay_ds_taikhoan_vohieuhoa' table. You can move, or remove it, as needed.
            if (cmbChonTK.SelectedIndex == 0)
                role = "GIAMSAT";
            this.sp_lay_ds_taikhoanTableAdapter.Fill(this.dStaoTaiKhoan.sp_lay_ds_taikhoan, role);
            if (dgvTaiKhoanXoa.RowCount == 0)
            {
                MessageBox.Show("Không có tài khoản nào để xóa lúc này!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmbChonTK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbChonTK.SelectedIndex == 0)
            {
                role = "GIAMSAT";
            }
            else if (cmbChonTK.SelectedIndex == 1)
            {
                role = "DOITRUONG";
            }
            else if (cmbChonTK.SelectedIndex == 2)
            {
                role = "DOIPHO";
            }
            else if (cmbChonTK.SelectedIndex == 3)
            {
                role = "NHOMTRUONG";
            }
            this.sp_lay_ds_taikhoanTableAdapter.Fill(this.dStaoTaiKhoan.sp_lay_ds_taikhoan, role);
            Console.WriteLine(dgvTaiKhoanXoa.Rows.Count);
            if (dgvTaiKhoanXoa.RowCount == 0)
            {
                MessageBox.Show("Không có tài khoản nào để xóa lúc này!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dtThem = new DataTable();
            dtThem.Columns.Add("LGNAME", typeof(string));
            // lay ra ma nhom chua sinh vien de them sang nhom khac
            int countTick = 0;


            for (int i = 0; i < dgvTaiKhoanXoa.Rows.Count; i++)
            {
                Console.WriteLine(dgvTaiKhoanXoa.Rows[i].Cells[1].Value?.ToString());
                // chi lay sinh vien nào được tick
                // them ? sau value cho truong hop value = null thi van convert qua string ''
                if (dgvTaiKhoanXoa.Rows[i].Cells[1].Value?.ToString() == "True")
                {
                    Console.WriteLine(dgvTaiKhoanXoa.Rows[i].Cells[0].Value.ToString());
                    dtThem.Rows.Add(dgvTaiKhoanXoa.Rows[i].Cells[0].Value.ToString());
                    countTick++;
                }
            }

            if (countTick == 0)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản nào để xóa! Vui lòng chọn!", "", MessageBoxButtons.OK);
                dgvTaiKhoanXoa.Focus();
                return;
            }
            printDT(dtThem);
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_KHOIPHUCTAIKHOAN";
            para.ParameterName = "@taiKhoan";
            para.Value = dtThem;
            if (MessageBox.Show("Ban có thật sự muốn xóa những tài khoản đã chọn không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Program.KetNoi();
                    SqlCommand sqlcmd = new SqlCommand("SP_XoaLogin", Program.conn);
                    sqlcmd.Parameters.Clear();
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(para);
                    sqlcmd.ExecuteNonQuery();
                    this.sp_lay_ds_taikhoanTableAdapter.Fill(this.dStaoTaiKhoan.sp_lay_ds_taikhoan, role);
                    if (dgvTaiKhoanXoa.RowCount == 0)
                    {
                        MessageBox.Show("Không có tài khoản nào để xóa lúc này!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa tài khoản không thành công! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                    Console.WriteLine(ex.Message);
                    return;
                }
                MessageBox.Show("Xóa tài khoản thành công!", "", MessageBoxButtons.OK);
            }
        }
        public void printDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("loginname: " + dt.Rows[i]["LGNAME"]);
            }
        }
    }
}
