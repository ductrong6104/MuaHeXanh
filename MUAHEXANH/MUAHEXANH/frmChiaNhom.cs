using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraPrinting.Native;
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
    public partial class frmChiaNhom : Form
    {
        private int viTri;
        private string maDoi;
        private string maNhomDangChon = "";
        public frmChiaNhom()
        {
            InitializeComponent();
        }

        // chua cho phep hieu chinh tren bảng thanhviennhom
        // chi nhung sinh vien thuộc đội chứa nhóm này thì mới thêm
        
        private void frmChiaNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSchiaNhom.thongtinsinhvien_trongnhom' table. You can move, or remove it, as needed.
      
            // TODO: This line of code loads data into the 'dSchiaNhom.ttsv_trong_doi' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dSchiaNhom.ThanhVienNhom' table. You can move, or remove it, as needed.



            // TODO: This line of code loads data into the 'dSchiaNhom.Nhom' table. You can move, or remove it, as needed.
            dSchiaNhom.EnforceConstraints = false;
            this.sp_lay_nhom_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi, Program.mTeam);
            this.ttsv_trongnhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ttsv_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
            maNhomDangChon = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOM"].ToString();
            if (maNhomDangChon == "")
            {
                Console.WriteLine("maNhomDangChon trong form load rong ");
            }
            this.sp_lay_nhom_tu_doi_de_chiaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_doi_de_chiaTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi_de_chia, Program.mTeam, maNhomDangChon);
            this.sp_lay_nhom_tu_manhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());

        }


        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (maNhomDangChon == "")
            {
                Console.WriteLine("maNhomDangChon trong form selection changed rong ");
            }
            this.ttsv_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
            maNhomDangChon = ((DataRowView)bdsNHOM[bdsNHOM.Position])["MANHOM"].ToString();
            Console.WriteLine("manhomdangchon trong datagridview3: " + maNhomDangChon);
            Console.WriteLine("vi tri bdsNHOM: " + bdsNHOM.Position.ToString());
            Console.WriteLine("soluongnhom: " + bdsNHOM.Count.ToString());
            Console.WriteLine("soluongsvnhom: " + dgvSVNHOM.RowCount.ToString());

            this.sp_lay_nhom_tu_doi_de_chiaTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi_de_chia, Program.mTeam, maNhomDangChon);
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());
            for (int i = 0; i < dgvSVNHOM.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                dgvSVNHOM.Rows[i].Cells[3].Value = "False";
            }
        }

        private void cmbNHOMCANTHEM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());
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

            for (int i = 0; i < dgvSVNHOM.Rows.Count; i++)
            {
                // chi lay sinh vien nào được tick
                if (dgvSVNHOM.Rows[i].Cells[3].Value.ToString() == "True")
                {
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
                this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi, Program.mTeam);
                this.ttsv_trongnhomTableAdapter.Fill(this.dSchiaNhom.thongtinsinhvien_trongnhom);
                this.sp_lay_nhom_tu_manhomTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_manhom, cmbNHOMCANTHEM.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sinh viên chuyển sang nhóm không thành công! Vui lòng kiểm tra lại", "", MessageBoxButtons.OK);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
