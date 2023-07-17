using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class frmChiaNhom : Form
    {
        private int viTri;
        private string maDoi;
        private string maNhomDangChon = "";
        private bool ghiThanhCong = false;
        private string maDoiTruong ="";
        private string maDoiPho ="";
        public frmChiaNhom()
        {
            InitializeComponent();
        }

        // chua cho phep hieu chinh tren bảng thanhviennhom
        // chi nhung sinh vien thuộc đội chứa nhóm này thì mới thêm
        private void batTatContextMenuStrip()
        {
            dgvSVNHOM.ContextMenuStrip = contextMenuStrip1;


            if (dgvSVNHOM.RowCount == 0)
            {
                dgvSVNHOM.ContextMenuStrip.Enabled = false;
            }
            else
            {
                dgvSVNHOM.ContextMenuStrip.Enabled = true;
            }
        }
        private void frmChiaNhom_Load(object sender, EventArgs e)
        {
         



            // TODO: This line of code loads data into the 'dSchiaNhom.Nhom' table. You can move, or remove it, as needed.
            dSchiaNhom.EnforceConstraints = false;
            string cmd = "exec sp_lay_madoitruong_madoipho_tudoi '" + Program.mTeam + "'";
            using (SqlDataReader reader = Program.ExecSqlDataReader(cmd))
            {
                if (reader == null)
                {
                    return;
                }
                reader.Read();
                if (reader.GetString(0) == null)
                    return;
                if (reader.GetString(1) == null)
                    return;
                maDoiTruong = reader.GetString(0);
                maDoiPho = reader.GetString(1);
                Console.WriteLine("ma doi truong: " + maDoiTruong);
                Console.WriteLine("ma doi pho: " + maDoiPho);
            }
                this.sp_lay_nhom_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi, Program.mTeam);
            batTatContextMenuStrip();

            //this.thongtinsinhvien_trongnhomTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.thongtinsinhvien_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
            //maNhomDangChon = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOM"].ToString();
            //if (maNhomDangChon == "")
            //{
            //    Console.WriteLine("maNhomDangChon trong form load rong ");
            //}
            //this.sp_lay_nhom_tu_doi_de_chiaTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sp_lay_nhom_tu_doi_de_chiaTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi_de_chia, Program.mTeam, maNhomDangChon);
            //this.sp_lay_nhom_tu_manhomTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());

        }

        
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            
            Console.WriteLine("manhomdangchon khi vo selectionchanged: " + maNhomDangChon);
            Console.WriteLine("soluongnhom: khi vo selectionchanged" + bdsNHOM.Count.ToString());
            if (maNhomDangChon == "")
            {
                Console.WriteLine("maNhomDangChon trong form selection changed rong ");
            }
            
            this.thongtinsinhvien_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
            
            if (!ghiThanhCong) 
                maNhomDangChon = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOM"].ToString();
            Console.WriteLine("manhomdangchon trong datagridview3: " + maNhomDangChon);
            Console.WriteLine("vi tri bdsNHOM: " + bdsNHOM.Position.ToString());
            Console.WriteLine("soluongnhom: " + bdsNHOM.Count.ToString());
            Console.WriteLine("soluongsvnhom: " + dgvSVNHOM.RowCount.ToString());

            this.sp_lay_nhom_tu_doi_de_chiaTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi_de_chia, Program.mTeam, maNhomDangChon);
            if (sp_lay_nhom_tu_doi_de_chiaBindingSource.Count == 0)
            {
                MessageBox.Show("Đội này hiện chưa có nhóm để chia, Vui lòng thêm nhóm!", "", MessageBoxButtons.OK);
                dgvSVNHOM.Enabled = false;
                btnCHUYEN.Enabled = false;
                return;
            }
            dgvSVNHOM.Enabled = true;
            btnCHUYEN.Enabled = true;
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());
            batTatContextMenuStrip();
            for (int i = 0; i < dgvSVNHOM.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                dgvSVNHOM.Rows[i].Cells[3].Value = "False";
            }
            ghiThanhCong = false;
            
        }

        private void cmbNHOMCANTHEM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());
            batTatContextMenuStrip();
        }

        private void btnCHUYEN_Click(object sender, EventArgs e)
        {
            if (maNhomDangChon == "")
            {
                Console.WriteLine("maNhomDangChon trong btn chuyen rong ");
            }
            DataTable dtThem = new DataTable();
            DataTable dtXoa = new DataTable();
            dtThem.Columns.Add("MANHOM", typeof(string));
            dtThem.Columns.Add("MASV", typeof(string));
            dtXoa.Columns.Add("MANHOM", typeof(string));
            dtXoa.Columns.Add("MASV", typeof(string));
            // lay ra ma nhom chua sinh vien de them sang nhom khac
            string manhomxoa = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOM"].ToString();
            string manhomthem = cmbNHOMCANTHEM.SelectedValue.ToString();
            Console.WriteLine("manhomxoa: " + manhomxoa);
            Console.WriteLine("manhomthem: " + manhomthem);
            int countTick = 0;
            Console.WriteLine("dgvSVNHOM row count: " + dgvSVNHOM.RowCount.ToString());
            if (dgvSVNHOM.Rows.Count == 0)
            {
                MessageBox.Show("Nhóm này không chứa sinh viên nào để chuyển! Vui lòng chọn nhóm khác", "", MessageBoxButtons.OK);
                dgvNHOM.Focus();
                return;

            }
            if (dgvSVNHOMCANTHEM.Rows.Count == 6)
            {
                MessageBox.Show("Một nhóm tối đa 6 sinh viên! Vui lòng chọn nhóm khác", "", MessageBoxButtons.OK);
                dgvNHOM.Focus();
                return;

            }
            string nhomTruong = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOMTRUONG"].ToString();
            for (int i = 0; i < dgvSVNHOM.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                if (dgvSVNHOM.Rows[i].Cells[3].Value?.ToString() == "True")
                {
                    if (dgvSVNHOM.Rows[i].Cells[0].Value.ToString() == nhomTruong.Trim())
                    {
                        MessageBox.Show("Bạn không thể chuyển nhóm trưởng sang nhóm khác! Vui lòng chọn sinh viên khác!", "", MessageBoxButtons.OK);
                        dgvSVNHOM.Focus();
                        return;
                    }
                    if (dgvSVNHOM.Rows[i].Cells[0].Value.ToString() == maDoiTruong)
                    {
                        MessageBox.Show("Bạn không thể chuyển đội trưởng sang nhóm khác! Vui lòng chọn sinh viên khác!", "", MessageBoxButtons.OK);
                        dgvSVNHOM.Focus();
                        return;
                    }
                    if (dgvSVNHOM.Rows[i].Cells[0].Value.ToString() == maDoiTruong)
                    {
                        MessageBox.Show("Bạn không thể chuyển đội phó sang nhóm khác! Vui lòng chọn sinh viên khác!", "", MessageBoxButtons.OK);
                        dgvSVNHOM.Focus();
                        return;
                    }
                    Console.WriteLine(dgvSVNHOM.Rows[i].Cells[0].Value.ToString());
                    dtXoa.Rows.Add(manhomxoa, dgvSVNHOM.Rows[i].Cells[0].Value.ToString());
                    dtThem.Rows.Add(manhomthem, dgvSVNHOM.Rows[i].Cells[0].Value.ToString());
                    countTick++;
                }
            }

            if (countTick == 0)
            {
                MessageBox.Show("Bạn chưa chọn sinh viên nào để chuyển! Vui lòng chọn!", "", MessageBoxButtons.OK);
                dgvSVNHOM.Focus();
                return;
            }
            if (countTick+dgvSVNHOMCANTHEM.RowCount > 6)
            {
                MessageBox.Show("Một nhóm tối đa 6 sinh viên! Vui lòng chuyển ít hơn " + (7-dgvSVNHOMCANTHEM.RowCount).ToString() + " sinh viên!", "", MessageBoxButtons.OK);
                dgvSVNHOM.Focus();
                return;
            }
            printDT(dtThem);
            printDT(dtXoa);
            SqlParameter para1 = new SqlParameter();
            para1.SqlDbType = SqlDbType.Structured;
            para1.TypeName = "dbo.TYPE_CHIANHOM";
            para1.ParameterName = "@SVXOA";
            para1.Value = dtXoa;
            SqlParameter para2 = new SqlParameter();
            para2.SqlDbType = SqlDbType.Structured;
            para2.SqlDbType = SqlDbType.Structured;
            para2.TypeName = "dbo.TYPE_CHIANHOM";
            para2.ParameterName = "@SVTHEM";
            para2.Value = dtThem;

            try
            {
                Program.KetNoi();
                SqlCommand sqlcmd = new SqlCommand("sp_chianhom", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para1);
                sqlcmd.Parameters.Add(para2);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Sinh viên chuyển sang nhóm thành công!", "", MessageBoxButtons.OK);
                Console.WriteLine("manhomdangchon trong btnChuyen: " + maNhomDangChon);
                ghiThanhCong = true;
                this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi, Program.mTeam.Trim());
                
                //this.thongtinsinhvien_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
                //this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinh viên chuyển sang nhóm không thành công! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }

            batTatContextMenuStrip();

        }
        public void printDT(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("MANHOM: " + dt.Rows[i]["MANHOM"] + ",MASV: " + dt.Rows[i]["MASV"]);
            }
        }

        

        private void chọnLàmNhómTrưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nhomTruong = ((DataRowView)bdsSVNHOM[bdsSVNHOM.Position])["masv"].ToString();
            if (nhomTruong == maDoiTruong)
            {
                MessageBox.Show("Đây là đội trưởng! Không thể làm nhóm trưởng!", "", MessageBoxButtons.OK);
                return;
            }
            if (nhomTruong == maDoiPho)
            {
                MessageBox.Show("Đây là đội phó! Không thể làm nhóm trưởng!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Ban có thật sự muốn chọn sinh viên này làm nhóm trưởng không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                try
                {
                    string maNhom = ((DataRowView)bdsNHOM[bdsNHOM.Position])["manhom"].ToString();
                    
                    string cmd = "UPDATE NHOM SET NHOMTRUONG = '" + nhomTruong + "' WHERE MANHOM = '" + maNhom + "'";
                    Console.WriteLine("cmd set nhom truong: " + cmd);
                    int setNhomTruong = Program.ExecSqlNonQuery(cmd);
                    if (setNhomTruong != 0)
                    {
                        MessageBox.Show("Lỗi thay đổi nhóm trưởng! ", "", MessageBoxButtons.OK);
                        return;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thay đổi nhóm trưởng! " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Thay đổi nhóm trưởng thành công! ", "", MessageBoxButtons.OK);
                ghiThanhCong = true;
                this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi, Program.mTeam.Trim());
                
                //this.thongtinsinhvien_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
                //this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());
            }
        }

        private void dgvSVNHOM_Paint(object sender, PaintEventArgs e)
        {
            string nhomTruong = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOMTRUONG"].ToString();
            for (int i = 0; i < dgvSVNHOM.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                for (int j = 0; j < dgvNHOM.Rows.Count; j++)
                {
                    // chi lay sinh vien nào được tick
                    if (dgvSVNHOM.Rows[i].Cells[0].Value?.ToString().Trim() == dgvNHOM.Rows[j].Cells[7].Value?.ToString().Trim())
                    {
                        dgvSVNHOM.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;

                    }
                    if (dgvSVNHOM.Rows[i].Cells[0].Value?.ToString().Trim() == maDoiTruong)
                    {
                        dgvSVNHOM.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvSVNHOM.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (dgvSVNHOM.Rows[i].Cells[0].Value?.ToString().Trim() == maDoiPho)
                    {
                        dgvSVNHOM.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        dgvSVNHOM.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }

            }
        }

        private void dgvSVNHOMCANTHEM_Paint(object sender, PaintEventArgs e)
        {
            string nhomTruong = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOMTRUONG"].ToString();
            for (int i = 0; i < dgvSVNHOMCANTHEM.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                for (int j = 0; j < dgvNHOM.Rows.Count; j++)
                {
                    // chi lay sinh vien nào được tick
                    if (dgvSVNHOMCANTHEM.Rows[i].Cells[0].Value?.ToString().Trim() == dgvNHOM.Rows[j].Cells[7].Value?.ToString().Trim())
                    {
                        dgvSVNHOMCANTHEM.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;

                    }
                    if (dgvSVNHOMCANTHEM.Rows[i].Cells[0].Value?.ToString().Trim() == maDoiTruong)
                    {
                        dgvSVNHOMCANTHEM.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvSVNHOMCANTHEM.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (dgvSVNHOMCANTHEM.Rows[i].Cells[0].Value?.ToString().Trim() == maDoiPho)
                    {
                        dgvSVNHOMCANTHEM.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        dgvSVNHOMCANTHEM.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }

            }
        }

        private void hủyLàmNhómTrưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nhomTruong = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOMTRUONG"].ToString();
            string svDuocChon = ((DataRowView)bdsSVNHOM[bdsSVNHOM.Position])["masv"].ToString();
            if (svDuocChon != nhomTruong)
            {
                MessageBox.Show("Đây không phải nhóm trưởng!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Ban hủy nhóm trưởng cho sinh viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    string maNhom = ((DataRowView)bdsNHOM[bdsNHOM.Position])["manhom"].ToString();

                    string cmd = "UPDATE NHOM SET NHOMTRUONG = NULL WHERE MANHOM = '" + maNhom + "'";
                    Console.WriteLine("cmd huy nhom truong: " + cmd);
                    int setNhomTruong = Program.ExecSqlNonQuery(cmd);
                    if (setNhomTruong != 0)
                    {
                        MessageBox.Show("Lỗi hủy nhóm trưởng! ", "", MessageBoxButtons.OK);
                        return;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hủy nhóm trưởng! " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Hủy thành công! ", "", MessageBoxButtons.OK);
                ghiThanhCong = true;
                this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi, Program.mTeam.Trim());

                //this.thongtinsinhvien_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
                //this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());
            }
        }
    }
}
