using DevExpress.Utils.Gesture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.FormTaoTaiKhoanCuaKhoa
{
    public partial class frmTaoTaiKhoanCuaKhoa : Form
    {
        private string role;
        private DataTable dataTable;
        public frmTaoTaiKhoanCuaKhoa()
        {
            InitializeComponent();
        }

        private void frmTaoTaiKhoanCuaKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dStaoTaiKhoan.sp_lay_doitruong_doipho_chua_tao_taikhoan' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dStaoTaiKhoan.sp_lay_giamsat_chua_tao_taikhoan' table. You can move, or remove it, as needed.
            cmbChonQuyen.SelectedIndex = 0;
            dataTable = Program.ExecSqlDataTable("exec sp_lay_giamsat_chua_tao_taikhoan");
            cmbHoTen.DataSource = dataTable;
            cmbHoTen.DisplayMember = "hoten";
            cmbHoTen.ValueMember= "magv";
            txtTaiKhoan.Text = cmbHoTen.SelectedValue.ToString();
            lblCHONHOTEN.Text = "Họ tên giảng viên";
        }
      

        private void cmbHoTen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = cmbHoTen.SelectedValue.ToString();
        }

        private void cmbChonQuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbChonQuyen.SelectedIndex == 0)
            {
                role = "GIAMSAT";
                dataTable = Program.ExecSqlDataTable("exec sp_lay_giamsat_chua_tao_taikhoan");
                if (dataTable == null)
                {
                    MessageBox.Show("Tất cả các giám sát đã có tài khoản! Không cần tạo nữa!", "", MessageBoxButtons.OK);
                    cmbChonQuyen.Focus();
                    return;
                }
                lblCHONHOTEN.Text = "Họ tên giảng viên";
                cmbHoTen.DataSource = dataTable;
                cmbHoTen.ValueMember = "magv";
                cmbHoTen.DisplayMember = "hoten";
                txtTaiKhoan.Text = cmbHoTen.SelectedValue.ToString();
                Console.WriteLine("so luong hoten: " + cmbHoTen.Items.Count);
            }
            else if (cmbChonQuyen.SelectedIndex == 1)
            {
                dataTable = Program.ExecSqlDataTable("exec sp_lay_doitruong_chua_tao_taikhoan");
                Console.WriteLine("so doi truong chua co tai khoan: " + dataTable.Rows.Count.ToString());
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Tất cả các đội trưởng đã có tài khoản! Không cần tạo nữa!", "", MessageBoxButtons.OK);
                    cmbChonQuyen.Focus();
                    return;
                }
                lblCHONHOTEN.Text = "Họ tên sinh viên";
                cmbHoTen.DataSource = dataTable;
                cmbHoTen.ValueMember = "masv";
                cmbHoTen.DisplayMember = "hoten";
                txtTaiKhoan.Text = cmbHoTen.SelectedValue.ToString();
                Console.WriteLine("so luong hoten: " + cmbHoTen.Items.Count);
                role = "DOITRUONG";

            }
            else
            {
                dataTable = Program.ExecSqlDataTable("exec sp_lay_doipho_chua_tao_taikhoan");
                Console.WriteLine("so doi pho chua co tai khoan: " + dataTable.Rows.Count.ToString());
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Tất cả các đội phó đã có tài khoản! Không cần tạo nữa!", "", MessageBoxButtons.OK);
                    cmbChonQuyen.Focus();
                    return;
                }
                lblCHONHOTEN.Text = "Họ tên sinh viên";
                cmbHoTen.DataSource = dataTable;
                cmbHoTen.ValueMember = "masv";
                cmbHoTen.DisplayMember = "hoten";
                txtTaiKhoan.Text = cmbHoTen.SelectedValue.ToString();
                Console.WriteLine("so luong hoten: " + cmbHoTen.Items.Count);
                role = "DOIPHO";
            }
        }
        public void printDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("MAsv: " + dt.Rows[i]["MAsv"] + ",hoten: " + dt.Rows[i]["hoten"]);
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không để trống!", "", MessageBoxButtons.OK);
                txtMatKhau.Focus();
                return;
            }
            if (txtNhapLaiMK.Text == "")
            {
                MessageBox.Show("Nhập lại mật khẩu không để trống!", "", MessageBoxButtons.OK);
                txtNhapLaiMK.Focus();
                return;
            }
            if (txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "", MessageBoxButtons.OK);
                txtNhapLaiMK.Focus();
                return;
            }

            
            try
            {
                string cmd = "exec SP_TaoLogin '" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "','" + txtTaiKhoan.Text + "','" + role  +"'";
                Console.WriteLine(cmd);
                int taoLogin = Program.ExecSqlNonQuery(cmd);
                if (taoLogin != 0)
                {
                    MessageBox.Show("Tạo tài khoản thất bại!", "", MessageBoxButtons.OK);
                    return;
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tạo tài khoản thất bại! Vui lòng thử lại! Lỗi: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Tạo tài khoản thành công! Hãy thử đăng nhập", "", MessageBoxButtons.OK);
        }
    }
}
