using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.FormKhenThuong
{
    public partial class frmDanhHieu : Form
    {
        private string maSV;

        public frmDanhHieu(string mssv)
        {
            InitializeComponent();
            maSV = mssv;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cmbDanhHieu.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn danh hiệu!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                cmbDanhHieu.Focus();
                return;
            }
            if (txtNoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn nội dung!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                txtNoiDung.Focus();
                return;
            }

            try
            {

                // ket thuc hieu chinh: ghi
                string cmd = "INSERT INTO KHENTHUONG VALUES('"
                                + Program.mTeam + "', '"
                                + maSV + "', N'"
                                + txtNoiDung.Text + "', N'"
                                + cmbDanhHieu.Text + "')";
                Console.WriteLine("cmd chia cv: " + cmd);
                int hd_them = Program.ExecSqlNonQuery(cmd);
                if (hd_them != 0)
                {
                    MessageBox.Show("Lỗi thêm danh hiệu cho sinh viên!", "", MessageBoxButtons.OK);
                    return;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm danh hiệu cho sinh viên! " + ex.Message.ToString(), "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            MessageBox.Show("thêm danh hiệu thành công", "", MessageBoxButtons.OK);
            this.Close();

        }

        
    }
}
