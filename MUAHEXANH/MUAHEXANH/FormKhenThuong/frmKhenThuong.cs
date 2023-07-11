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
    public partial class frmKhenThuong : Form
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }

        private void cmbTenNhom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.sp_laySinhVienTuNhomTableAdapter.Fill(this.dSkhenThuong.sp_laySinhVienTuNhom, cmbTenNhom.SelectedValue.ToString());
            Console.WriteLine(dgvDSSV.RowCount);
            if (dgvDSSV.RowCount == 0)
            {
                cmsThemKhenThuong.Enabled = false;
            }
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            { 
                Console.WriteLine("check " + i.ToString() + ": " + dgvDSSV.Rows[i].Cells[3].Value.ToString());
                // chi lay sinh vien nào được tick
                if (dgvDSSV.Rows[i].Cells[3].Value.ToString() == "1")
                {
                    dgvDSSV.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                } 
            }
        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            this.dSkhenThuong.EnforceConstraints = false;
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSkhenThuong.sp_lay_nhom_tu_doi, Program.mTeam);
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter.Fill(this.dSkhenThuong.sp_laySinhVienKhenThuongTheoDoi, Program.mTeam);
            this.sp_laySinhVienTuNhomTableAdapter.Fill(this.dSkhenThuong.sp_laySinhVienTuNhom, cmbTenNhom.SelectedValue.ToString());
            lblTenDoi.Text = Program.tenDoiLucDN;
            dgvDSSV.ContextMenuStrip = cmsThemKhenThuong;
            dgvDSKhenThuong.ContextMenuStrip = cmsXoaKhenThuong;
            if (dgvDSKhenThuong.RowCount == 0)
            {
                dgvDSKhenThuong.ContextMenuStrip.Enabled = false;
            }
            
            Console.WriteLine(dgvDSSV.RowCount);
            if (dgvDSSV.RowCount == 0)
            {
                dgvDSSV.ContextMenuStrip.Enabled = false;
            }
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            {
                Console.WriteLine("check " + i.ToString() + ": " + dgvDSSV.Rows[i].Cells[3].Value.ToString());
                // chi lay sinh vien nào được tick
                if (dgvDSSV.Rows[i].Cells[3].Value.ToString() == "1")
                {
                    dgvDSSV.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void dgvDSSV_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            {
                Console.WriteLine("check " + i.ToString() + ": " + dgvDSSV.Rows[i].Cells[3].Value.ToString());
                // chi lay sinh vien nào được tick
                if (dgvDSSV.Rows[i].Cells[3].Value.ToString() == "1")
                {
                    dgvDSSV.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string masv = ((DataRowView)sp_laySinhVienTuNhomBindingSource[sp_laySinhVienTuNhomBindingSource.Position])["masv"].ToString();
            for (int i = 0; i < dgvDSKhenThuong.Rows.Count; i++)
            {
                Console.WriteLine("check " + i.ToString() + ": " + dgvDSKhenThuong.Rows[i].Cells[0].Value.ToString());
                // chi lay sinh vien nào được tick
                if (dgvDSKhenThuong.Rows[i].Cells[0].Value.ToString() == masv)
                {
                    MessageBox.Show("Sinh viên này đã được chọn khen thưởng! Vui lòng chọn sinh viên khác", "", MessageBoxButtons.OK);
                    // đưa con nháy về text box
                    dgvDSSV.Focus();
                    return;
                }
            }
            
            frmDanhHieu frmDanhHieu = new frmDanhHieu(masv);
            frmDanhHieu.ShowDialog();
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter.Fill(this.dSkhenThuong.sp_laySinhVienKhenThuongTheoDoi, Program.mTeam);
            
        }

        private void xóaKhỏiKhenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn xóa sinh viên này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    string masv = ((DataRowView)sp_laySinhVienKhenThuongTheoDoiBindingSource[sp_laySinhVienKhenThuongTheoDoiBindingSource.Position])["MASV"].ToString();
                    // ket thuc hieu chinh: ghi
                    string cmd = "DELETE FROM KHENTHUONG WHERE MADOI = '"
                                    + Program.mTeam + "' AND MASV = '"
                                    + masv + "'";

                    Console.WriteLine("cmd xoa sinh vien khen thuong: " + cmd);
                    int hd_them = Program.ExecSqlNonQuery(cmd);
                    if (hd_them != 0)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên khen thưởng. Vui lòng kiểm tra lại thông tin!", "", MessageBoxButtons.OK);
                        return;
                    }

                    // khi ghi đội thì tự động thêm một nhóm chứa đội trưởng, đội phó đội đó 

                    //this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên khen thưởng!" + ex.Message, "", MessageBoxButtons.OK);
                    Console.WriteLine(ex.ToString());
                    // tro ve trang thai luc them cho user dieu chinh lai
                    return;
                }
                MessageBox.Show("xóa sinh viên khen thưởng thành công", "", MessageBoxButtons.OK);

            }
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter.Fill(this.dSkhenThuong.sp_laySinhVienKhenThuongTheoDoi, Program.mTeam);
        }
    }
}
