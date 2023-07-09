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
        private int viTri;
        private bool dangThem;
        public frmTaoDoi()
        {
            InitializeComponent();
        }

        public void trangThaiBanDau()
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnHieuChinh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            pnlDOI.Enabled = false;
            gcDSDOI.Enabled = true;

        }
        public void trangThaiChuaGhi()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            pnlDOI.Enabled = true;
            gcDSDOI.Enabled = false;
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
            trangThaiBanDau();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDOI.Position;
            dangThem = true;
            txtTenDoi.Text = "";
            cmbGiamSat1.Text = "";
            cmbGiamSat2.Text = "";
            trangThaiChuaGhi();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (int.Parse(((DataRowView)bdsDOI[bdsDOI.Position])["sosv"].ToString()) > 0)
            {
                MessageBox.Show("Đội này đã có sinh viên, không thể chỉnh sửa! Vui lòng chọn đội khác!", "", MessageBoxButtons.OK);
                gcDSDOI.Focus();
                return;
            }
            viTri = bdsDOI.Position;
            dangThem = false;
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
            if (cmbGiamSat1.Text.Trim() == cmbGiamSat2.Text.Trim())
            {
                MessageBox.Show("Trùng tên 2 giám sát! Vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbGiamSat1.Focus();
                return;
            }


            try
            {
                string cmd = "";
                // ket thuc hieu chinh: ghi
                if (dangThem == true)
                {
                    cmd = "INSERT INTO DOI(TENDOI, GIAMSAT1, GIAMSAT2, MACHIENDICH, MAKHOA, MAXA) VALUES(N'"
                                + txtTenDoi.Text + "', '"
                                + cmbGiamSat1.SelectedValue.ToString() + "', '"
                                + cmbGiamSat2.SelectedValue.ToString() + "', '"
                                + Program.maChienDich + "', '"
                                + cmbKhoa.SelectedValue.ToString() + "', '"
                                + cmbXa.SelectedValue.ToString() + "')";
                }
                else
                {
                    string madoi = ((DataRowView)bdsDOI[bdsDOI.Position])["MADOI"].ToString();
                    cmd = "UPDATE DOI " +
                        "SET TENDOI = N'" + txtTenDoi.Text
                        + "', GIAMSAT1 = '" + cmbGiamSat1.SelectedValue.ToString()
                        + "', GIAMSAT2 = '" + cmbGiamSat2.SelectedValue.ToString()
                        + "', MAKHOA = '" + cmbKhoa.SelectedValue.ToString()
                        + "', MAXA = '" + cmbXa.SelectedValue.ToString()
                        + "' WHERE MADOI = '" + madoi + "'";
                }
                


                Console.WriteLine(cmd);
                int hd_them = Program.ExecSqlNonQuery(cmd);
                if (hd_them != 0)
                {
                    MessageBox.Show("Ghi đội không thành công! Không còn nhà trống trong xã này! Vui lòng chọn xã khác!", "", MessageBoxButtons.OK);
                    return;
                }

                // khi ghi đội thì tự động thêm một nhóm chứa đội trưởng, đội phó đội đó 
                MessageBox.Show("ghi đội thành công", "", MessageBoxButtons.OK);
                //this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi đội!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            this.sp_lay_dsdoi_theo_chiendichTableAdapter.Fill(this.dStaoDoi.sp_lay_dsdoi_theo_chiendich, Program.maChienDich);
            
            
            trangThaiBanDau();

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (int.Parse(((DataRowView)bdsDOI[bdsDOI.Position])["sosv"].ToString()) > 0)
            {
                MessageBox.Show("Đội này đã có sinh viên, không thể xóa! Vui lòng chọn đội khác!", "", MessageBoxButtons.OK);
                gcDSDOI.Focus();
                return;
            }
            try
            {
                
                string madoi = ((DataRowView)bdsDOI[bdsDOI.Position])["MADOI"].ToString();
                // ket thuc hieu chinh: ghi
                string cmd = "DELETE FROM DOI WHERE MADOI = '"
                                + madoi + "' AND MACHIENDICH = '"
                                + Program.maChienDich + "'";

                Console.WriteLine("cmd xoa doi: " + cmd);
                int hd_them = Program.ExecSqlNonQuery(cmd);
                if (hd_them != 0)
                {
                    MessageBox.Show("Lỗi xóa đội trong chiến dịch. Vui lòng kiểm tra lại thông tin!", "", MessageBoxButtons.OK);
                    return;
                }

                // khi ghi đội thì tự động thêm một nhóm chứa đội trưởng, đội phó đội đó 
                
                //this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa đội!" + ex.Message, "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            MessageBox.Show("xóa đội thành công", "", MessageBoxButtons.OK);
            this.sp_lay_dsdoi_theo_chiendichTableAdapter.Fill(this.dStaoDoi.sp_lay_dsdoi_theo_chiendich, Program.maChienDich);


            trangThaiBanDau();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                bdsDOI.Position = viTri;
            }
            trangThaiBanDau();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sp_lay_dsdoi_theo_chiendichTableAdapter.Fill(this.dStaoDoi.sp_lay_dsdoi_theo_chiendich, Program.maChienDich);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show("Lỗi reload!", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbKhoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.sp_lay_giamsat1_them_vao_doiTableAdapter.Fill(this.dStaoDoi.sp_lay_giamsat1_them_vao_doi, cmbKhoa.SelectedValue.ToString(), "", Program.maChienDich);
            this.sp_lay_giamsat2_them_vao_doiTableAdapter.Fill(this.dStaoDoi.sp_lay_giamsat2_them_vao_doi, cmbKhoa.SelectedValue.ToString(), "", Program.maChienDich);
            if (cmbGiamSat1.Items.Count <= 1)
            {
                MessageBox.Show("Không đủ số lượng giám sát cho khoa này, vui lòng chọn khoa khác !", "", MessageBoxButtons.OK);
                cmbKhoa.Focus();    
            }
        }
    }
}
