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
            lblTenDoi.Text = Program.tenDoiLucDN;
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSkhenThuong.sp_lay_nhom_tu_doi, Program.mTeam);
            this.sp_laySinhVienKhenThuongTheoDoiTableAdapter.Fill(this.dSkhenThuong.sp_laySinhVienKhenThuongTheoDoi, Program.mTeam);
            dgvDSSV.ContextMenuStrip = cmsThemKhenThuong;
            dgvDSKhenThuong.ContextMenuStrip = cmsXoaKhenThuong;
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
            frmDanhHieu frmDanhHieu = new frmDanhHieu();
            frmDanhHieu.ShowDialog();
        }
    }
}
