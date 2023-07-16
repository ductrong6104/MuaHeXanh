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
    public partial class frmChiaDoi : Form
    {
        private string maKhoaCuaDoi;
        public frmChiaDoi()
        {
            InitializeComponent();
        }
        
        private void frmChiaDoi_Load(object sender, EventArgs e)
        {
            this.dSchiaDoi.EnforceConstraints = false;
            this.sp_lay_doi_tu_chiendichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_doi_tu_chiendichTableAdapter.Fill(this.dSchiaDoi.sp_lay_doi_tu_chiendich, Program.maChienDich);
            this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Fill(this.dSchiaDoi.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi, cmbDOI.SelectedValue.ToString());
            this.sp_lay_nhom_tu_manhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaDoi.sp_lay_nhom_tu_manhom, txtMANHOM.Text);
            this.sp_lay_dssv_chuacodoi_theo_makhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            maKhoaCuaDoi = ((DataRowView)sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiBindingSource[0])["MAKHOA"].ToString();
            this.sp_lay_dssv_chuacodoi_theo_makhoaTableAdapter.Fill(this.dSchiaDoi.sp_lay_dssv_chuacodoi_theo_makhoa, maKhoaCuaDoi);

            dgvTHANHVIENDOI.ContextMenuStrip = contextMenuStrip1;
            
            
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
            int soSVToiDa = int.Parse(((DataRowView)sp_lay_doi_tu_chiendichBindingSource[sp_lay_doi_tu_chiendichBindingSource.Position])["SOSVTOIDA"].ToString());

            Console.WriteLine("so sinh vien toi da trong doi: " + soSVToiDa);
            if (soSVToiDa == sp_lay_nhom_tu_manhomBindingSource.Count)
            {
                MessageBox.Show("Đội này có tối đa " + soSVToiDa.ToString() + " sinh viên! Không thể thêm sinh viên được nữa!", "", MessageBoxButtons.OK);
                dgvSVCHUACODOI.Focus();
                return;

            }
            for (int i = 0; i < dgvSVCHUACODOI.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                if (dgvSVCHUACODOI.Rows[i].Cells[3].Value?.ToString() == "True")
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
            if (countTick+dgvTHANHVIENDOI.RowCount > soSVToiDa)
            {
                MessageBox.Show("Đội này có tối đa " + soSVToiDa.ToString() + " sinh viên! Vui lòng chọn ít hơn " + (soSVToiDa+1-dgvTHANHVIENDOI.RowCount).ToString() + " sinh viên! ", "", MessageBoxButtons.OK);
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
                this.sp_lay_doi_tu_chiendichTableAdapter.Fill(this.dSchiaDoi.sp_lay_doi_tu_chiendich, Program.maChienDich);
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

        private void dgvTHANHVIENDOI_Sorted(object sender, EventArgs e)
        {
            
        }

        

        

       

        private void chọnLàmĐộiTrưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Ban có thật sự muốn chọn sinh viên này làm đội trưởng không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int position = cmbDOI.SelectedIndex;
                try
                {
                    
                    string doiTruong = ((DataRowView)sp_lay_nhom_tu_manhomBindingSource[sp_lay_nhom_tu_manhomBindingSource.Position])["masv"].ToString();
                    string cmd = "UPDATE DOI SET DOITRUONG = '" + doiTruong + "' WHERE MADOI = '" + cmbDOI.SelectedValue.ToString() + "'";
                    Console.WriteLine("cmd set doi truong: " + cmd);
                    int setDoiTruong = Program.ExecSqlNonQuery(cmd);
                    if (setDoiTruong != 0)
                    {
                        MessageBox.Show("Lỗi thay đổi đội trưởng! ", "", MessageBoxButtons.OK);
                        return;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thay đổi đội trưởng! " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Thay đổi đội trưởng thành công! ", "", MessageBoxButtons.OK);
                this.sp_lay_doi_tu_chiendichTableAdapter.Fill(this.dSchiaDoi.sp_lay_doi_tu_chiendich, Program.maChienDich);
                cmbDOI.SelectedIndex = position;
                this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Fill(this.dSchiaDoi.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi, cmbDOI.SelectedValue.ToString());
                this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaDoi.sp_lay_nhom_tu_manhom, txtMANHOM.Text);
            }    
                
        }

        private void chọnLàmĐộiPhóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn chọn sinh viên này làm đội trưởng không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int position = cmbDOI.SelectedIndex;
                try
                {

                    string doipho = ((DataRowView)sp_lay_nhom_tu_manhomBindingSource[sp_lay_nhom_tu_manhomBindingSource.Position])["masv"].ToString();
                    string cmd = "UPDATE DOI SET DOIPHO = '" + doipho + "' WHERE MADOI = '" + cmbDOI.SelectedValue.ToString() + "'";
                    Console.WriteLine("cmd set doi PHO: " + cmd);
                    int setDoiTruong = Program.ExecSqlNonQuery(cmd);
                    if (setDoiTruong != 0)
                    {
                        MessageBox.Show("Lỗi thay đổi dội phó! ", "", MessageBoxButtons.OK);
                        return;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thay đổi đội phó! " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Thay đổi đội phó thành công! ", "", MessageBoxButtons.OK);
                this.sp_lay_doi_tu_chiendichTableAdapter.Fill(this.dSchiaDoi.sp_lay_doi_tu_chiendich, Program.maChienDich);
                cmbDOI.SelectedIndex = position;
                this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Fill(this.dSchiaDoi.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi, cmbDOI.SelectedValue.ToString());
                this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaDoi.sp_lay_nhom_tu_manhom, txtMANHOM.Text);
            }
        }

        private void dgvTHANHVIENDOI_Paint(object sender, PaintEventArgs e)
        {
            string doitruong = ((DataRowView)sp_lay_doi_tu_chiendichBindingSource[sp_lay_doi_tu_chiendichBindingSource.Position])["DOITRUONG"].ToString();
            string doipho = ((DataRowView)sp_lay_doi_tu_chiendichBindingSource[sp_lay_doi_tu_chiendichBindingSource.Position])["DOIPHO"].ToString();
            for (int i = 0; i < dgvTHANHVIENDOI.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                if (dgvTHANHVIENDOI.Rows[i].Cells[0].Value.ToString().Trim() == doitruong.Trim())
                {
                    dgvTHANHVIENDOI.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dgvTHANHVIENDOI.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (dgvTHANHVIENDOI.Rows[i].Cells[0].Value.ToString().Trim() == doipho.Trim())
                {
                    dgvTHANHVIENDOI.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dgvTHANHVIENDOI.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void xóaKhỏiĐộiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string doitruong = ((DataRowView)sp_lay_doi_tu_chiendichBindingSource[sp_lay_doi_tu_chiendichBindingSource.Position])["DOITRUONG"].ToString();
            string doipho = ((DataRowView)sp_lay_doi_tu_chiendichBindingSource[sp_lay_doi_tu_chiendichBindingSource.Position])["DOIPHO"].ToString();
            if (MessageBox.Show("Ban có thật sự muốn xóa sinh viên này khỏi đội không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int position = cmbDOI.SelectedIndex;
                try
                {

                    string svCanXoa = ((DataRowView)sp_lay_nhom_tu_manhomBindingSource[sp_lay_nhom_tu_manhomBindingSource.Position])["masv"].ToString();
                    
                    if (svCanXoa.Trim() == doitruong.Trim())
                    {
                        string cmdDOITRUONG = "UPDATE DOI SET DOITRUONG = NULL WHERE MADOI = '" + cmbDOI.SelectedValue.ToString() + "'";
                        Console.WriteLine("cmd set doi TRUONG NULL: " + cmdDOITRUONG);
                        int setDoiTruong = Program.ExecSqlNonQuery(cmdDOITRUONG);
                        if (setDoiTruong != 0)
                        {
                            MessageBox.Show("Lỗi xóa đội trưởng! ", "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else if (svCanXoa.Trim() == doipho.Trim())
                    {
                        string cmdDOITRUONG = "UPDATE DOI SET DOIPHO = NULL WHERE MADOI = '" + cmbDOI.SelectedValue.ToString() + "'";
                        Console.WriteLine("cmd set doi PHO NULL: " + cmdDOITRUONG);
                        int setDoiTruong = Program.ExecSqlNonQuery(cmdDOITRUONG);
                        if (setDoiTruong != 0)
                        {
                            MessageBox.Show("Lỗi xóa đội phó! ", "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    string cmd = "DELETE FROM THANHVIENNHOM WHERE MASV = '" + svCanXoa + "' AND MANHOM = (SELECT MANHOM FROM NHOM WHERE MADOI =  '" + cmbDOI.SelectedValue.ToString() + "' AND TENNHOM = 'temp')";
                    Console.WriteLine("cmd xóa sinh viên khỏi đội: " + cmd);
                    int xoaSV = Program.ExecSqlNonQuery(cmd);
                    if (xoaSV != 0)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên khỏi đội! ", "", MessageBoxButtons.OK);
                        return;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên khỏi đội! " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Xóa sinh viên khỏi đội thành công! ", "", MessageBoxButtons.OK);
                this.sp_lay_doi_tu_chiendichTableAdapter.Fill(this.dSchiaDoi.sp_lay_doi_tu_chiendich, Program.maChienDich);
                cmbDOI.SelectedIndex = position;
                this.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiTableAdapter.Fill(this.dSchiaDoi.sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoi, cmbDOI.SelectedValue.ToString());
                this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaDoi.sp_lay_nhom_tu_manhom, txtMANHOM.Text);
                maKhoaCuaDoi = ((DataRowView)sp_lay_manhom_tenhom_makhoa_tenkhoa_tu_madoiBindingSource[0])["MAKHOA"].ToString();
                this.sp_lay_dssv_chuacodoi_theo_makhoaTableAdapter.Fill(this.dSchiaDoi.sp_lay_dssv_chuacodoi_theo_makhoa, maKhoaCuaDoi);
            }
        }
    }
}
