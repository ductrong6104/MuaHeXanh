using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class frmTaoDoi : Form
    {
        private int viTri
        public frmTaoDoi()
        {
            InitializeComponent();
        }

        public void trangThaiBanDau()
        {
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
        }
        public void trangThaiChuaGhi()
        {
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
        }

        private void frmTaoDoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dStaoDoi.Doi' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dStaoDoi.Doi' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dStaoDoi.Khoa' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dStaoDoi.Nhom' table. You can move, or remove it, as needed.

            this.sp_lay_dsdoi_theo_chiendichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_dsdoi_theo_chiendichTableAdapter.Fill(this.dStaoDoi.sp_lay_dsdoi_theo_chiendich, Program.maChienDich);
            this.nhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhomTableAdapter.Fill(this.dStaoDoi.Nhom);
            this.khoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoaTableAdapter.Fill(this.dStaoDoi.Khoa);
            txtChienDich.Text = Program.tenChienDich;
            this.sp_lay_giamsat1_them_vao_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_giamsat1_them_vao_doiTableAdapter.Fill(this.dStaoDoi.sp_lay_giamsat1_them_vao_doi, cmbKhoa.SelectedValue.ToString(), "", Program.maChienDich);
            this.sp_lay_giamsat2_them_vao_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_giamsat2_them_vao_doiTableAdapter.Fill(this.dStaoDoi.sp_lay_giamsat2_them_vao_doi, cmbKhoa.SelectedValue.ToString(), "", Program.maChienDich);
           
            this.sp_lay_xa_tu_chiendichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_xa_tu_chiendichTableAdapter.Fill(this.dStaoDoi.sp_lay_xa_tu_chiendich, Program.maChienDich);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenDoi.Text = "";
            cmbGiamSat1.Text = "";
            cmbGiamSat2.Text = "";
            trangThaiChuaGhi();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThaiChuaGhi();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTenDoi.Text.Trim() == "")
            {
                MessageBox.Show("Tên đội không được để trống! Vui lòng nhập!", "", MessageBoxButtons.OK);
                txtTenDoi.Focus();
                return;
            }
            if (cmbGiamSat1.Text.Trim() == "")
            {
                MessageBox.Show("Tên giám sát 1 không được để trống! Vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbGiamSat1.Focus();
                return;
            }
            if (cmbGiamSat2.Text.Trim() == "")
            {
                MessageBox.Show("Tên giám sát 2 không được để trống! Vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbGiamSat2.Focus();
                return;
            }
     
            try
            {
                // ket thuc hieu chinh: ghi
                
                string cmd = "INSERT INTO DOI(TENDOI, GIAMSAT1, GIAMSAT2, MACHIENDICH, MAKHOA, MAXA) VALUES(N'"
                                + txtTenDoi.Text + "', '"
                                + cmbGiamSat1.SelectedValue.ToString() + "', '"
                                + cmbGiamSat2.SelectedValue.ToString() + "', '"
                                + Program.maChienDich + "', '"
                                + cmbKhoa.SelectedValue.ToString() + "', '"
                                + cmbXa.SelectedValue.ToString() + "')";
                Console.WriteLine(cmd);
                int hd_them = Program.ExecSqlNonQuery(cmd);
                if (hd_them != 0)
                {
                    MessageBox.Show("Lỗi thêm đội cho chiến dịch. Vui lòng kiểm tra lại thông tin!", "", MessageBoxButtons.OK);
                    return;
                }

                // khi ghi đội thì tự động thêm một nhóm chứa đội trưởng, đội phó đội đó 
                MessageBox.Show("thêm đội thành công", "", MessageBoxButtons.OK);
                //this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm đội!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            this.sp_lay_dsdoi_theo_chiendichTableAdapter.Fill(this.dStaoDoi.sp_lay_dsdoi_theo_chiendich, Program.maChienDich);
            trangThaiBanDau();

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            trangThaiBanDau();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

       
    }
}
