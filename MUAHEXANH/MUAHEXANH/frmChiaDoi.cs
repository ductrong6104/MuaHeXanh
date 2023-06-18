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
    public partial class frmChiaDoi : Form
    {
        private string maKhoaCuaDoi;
        public frmChiaDoi()
        {
            InitializeComponent();
        }
        
        private void frmChiaDoi_Load(object sender, EventArgs e)
        {
            this.sp_lay_doi_tu_chiendichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_doi_tu_chiendichTableAdapter.Fill(this.dSchiaDoi.sp_lay_doi_tu_chiendich, Program.maChienDich);
            this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Fill(this.dSchiaDoi.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi, cmbDOI.SelectedValue.ToString());
            this.sp_lay_nhom_tu_manhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaDoi.sp_lay_nhom_tu_manhom, txtMANHOM.Text);
            this.sp_lay_dssv_chuacodoi_theo_makhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            maKhoaCuaDoi = ((DataRowView)sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiBindingSource[0])["MAKHOA"].ToString();
            this.sp_lay_dssv_chuacodoi_theo_makhoaTableAdapter.Fill(this.dSchiaDoi.sp_lay_dssv_chuacodoi_theo_makhoa, maKhoaCuaDoi);
        }

        private void cmbDOI_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Fill(this.dSchiaDoi.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi, cmbDOI.SelectedValue.ToString());
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaDoi.sp_lay_nhom_tu_manhom, txtMANHOM.Text);
            maKhoaCuaDoi = ((DataRowView)sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiBindingSource[0])["MAKHOA"].ToString();
            this.sp_lay_dssv_chuacodoi_theo_makhoaTableAdapter.Fill(this.dSchiaDoi.sp_lay_dssv_chuacodoi_theo_makhoa, maKhoaCuaDoi);
            for (int i = 0; i < dgvSVCHUACODOI.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                dgvSVCHUACODOI.Rows[i].Cells[3].Value = "False";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            DataTable dtThem = new DataTable();
            dtThem.Columns.Add("MANHOM", typeof(string));
            dtThem.Columns.Add("MASV", typeof(string));
            // lay ra ma nhom chua sinh vien de them sang nhom khac
            string manhomthem = txtMANHOM.Text;
            Console.WriteLine("manhomthem: " + manhomthem);
            int countTick = 0;
            Console.WriteLine("dgvSVCHUACODOIrow count: " + dgvSVCHUACODOI.RowCount.ToString());
            if (dgvSVCHUACODOI.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên trong khoa này!", "", MessageBoxButtons.OK);
                dgvSVCHUACODOI.Focus();
                return;

            }

            for (int i = 0; i < dgvSVCHUACODOI.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                if (dgvSVCHUACODOI.Rows[i].Cells[3].Value.ToString() == "True")
                {
                    Console.WriteLine(dgvSVCHUACODOI.Rows[i].Cells[0].Value.ToString());
                    dtThem.Rows.Add(manhomthem, dgvSVCHUACODOI.Rows[i].Cells[0].Value.ToString());
                    countTick++;
                }
            }

            if (countTick == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên nào thêm vào đội! Vui lòng chọn!", "", MessageBoxButtons.OK);
                dgvSVCHUACODOI.Focus();
                return;
            }
            printDT(dtThem);
            SqlParameter para = new SqlParameter();
            para.SqlDbType = SqlDbType.Structured;
            para.TypeName = "dbo.TYPE_CHIANHOM";
            para.ParameterName = "@SVTHEM";
            para.Value = dtThem;

            try
            {
                Program.KetNoi();
                SqlCommand sqlcmd = new SqlCommand("sp_chiadoi", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Sinh viên chuyển sang đội thành công!", "", MessageBoxButtons.OK);
                Console.WriteLine("manhomdangchon trong btnChuyen: " + manhomthem);
                //ghiThanhCong = true;
                this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Fill(this.dSchiaDoi.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi, cmbDOI.SelectedValue.ToString());
                this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaDoi.sp_lay_nhom_tu_manhom, txtMANHOM.Text);
                maKhoaCuaDoi = ((DataRowView)sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiBindingSource[0])["MAKHOA"].ToString();
                this.sp_lay_dssv_chuacodoi_theo_makhoaTableAdapter.Fill(this.dSchiaDoi.sp_lay_dssv_chuacodoi_theo_makhoa, maKhoaCuaDoi);
                for (int i = 0; i < dgvSVCHUACODOI.Rows.Count; i++)
                {
                    // chi lay sinh vien nào được tick
                    dgvSVCHUACODOI.Rows[i].Cells[3].Value = "False";
                }

                //this.thongtinsinhvien_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
                //this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm sinh viên vào đội không thành công! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }
        }
        public void printDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("MANHOM: " + dt.Rows[i]["MANHOM"] + ",MASV: " + dt.Rows[i]["MASV"]);
            }
        }
    }
}
