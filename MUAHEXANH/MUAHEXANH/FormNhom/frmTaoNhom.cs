using DevExpress.Data.Linq.Helpers;
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

namespace MUAHEXANH
{
    public partial class frmTaoNhom : Form
    {
        private int viTri;
        private bool dangThem;
        public frmTaoNhom()
        {
            InitializeComponent();
        }

        public void trangThaiBanDau()
        {
            btnPhucHoi.Enabled = btnGhi.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
            gcNHOM.Enabled = true;
            pnlTHEMNHOM.Enabled = false;
        }
        public void trangThaiChuaGhi()
        {
            btnPhucHoi.Enabled = btnGhi.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
            gcNHOM.Enabled = false;
            pnlTHEMNHOM.Enabled = true;
        }
        private void frmTaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dStaoNhom.ttsv_trongnhom' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dStaoNhom.ttsv_trongnhom' table. You can move, or remove it, as needed.
            lblTenDoi.Text = Program.tenDoiLucDN;
            
            this.sp_lay_nhom_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dStaoNhom.sp_lay_nhom_tu_doi, Program.mTeam);
            this.ttsv_trongnhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ttsv_trongnhomTableAdapter.Fill(this.dStaoNhom.ttsv_trongnhom);
            this.sp_lay_nha_chuaconhom_tudoiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nha_chuaconhom_tudoiTableAdapter.Fill(this.dStaoNhom.sp_lay_nha_chuaconhom_tudoi, Program.mTeam);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDSNHOM.Position;
            txtTENNHOM.Text = "";
            cmbDIACHI.Text = "";
            dangThem = true;
            trangThaiChuaGhi();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDSNHOM.Position;
            dangThem = false;
            trangThaiChuaGhi();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtTENNHOM.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhóm không được để trống! Vui lòng nhập!", "", MessageBoxButtons.OK);
                txtTENNHOM.Focus();
                return;
            }
            if (cmbDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống! Vui lòng chọn!", "", MessageBoxButtons.OK);
                cmbDIACHI.Focus();
                return;
            }
  

            try
            {
                string cmd = "";
                // ket thuc hieu chinh: ghi
                if (dangThem == true)
                {
                    cmd = "INSERT INTO NHOM(TenNhom, MaDoi, MaNha) VALUES(N'"
                                + txtTENNHOM.Text.ToString() + "', '"
                                + Program.mTeam + "', '"
                                + cmbDIACHI.SelectedValue.ToString() + "')";
                }
                else
                {
                    string manhom = ((DataRowView)bdsDSNHOM[bdsDSNHOM.Position])["MANHOM"].ToString();
                    cmd = "UPDATE NHOM SET " +
                        "TENNHOM=N'"+ txtTENNHOM.Text.ToString() 
                        + "', MANHA ='" + cmbDIACHI.SelectedValue.ToString()
                        + "' WHERE MANHOM='" + manhom + "'";
                }
                
                Console.WriteLine(cmd);
                int hd_them = Program.ExecSqlNonQuery(cmd);
                if (hd_them != 0)
                {
                    MessageBox.Show("Lỗi ghi nhóm. Vui lòng kiểm tra lại thông tin!", "", MessageBoxButtons.OK);
                    return;
                }

                // khi ghi đội thì tự động thêm một nhóm chứa đội trưởng, đội phó đội đó 
                MessageBox.Show("ghi nhóm thành công", "", MessageBoxButtons.OK);
                //this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi  nhóm!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dStaoNhom.sp_lay_nhom_tu_doi, Program.mTeam);
            this.sp_lay_nha_chuaconhom_tudoiTableAdapter.Fill(this.dStaoNhom.sp_lay_nha_chuaconhom_tudoi, Program.mTeam);
            trangThaiBanDau();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string manhom = "";
            if (ttsv_trongnhomBindingSource.Count > 0)
            {
                MessageBox.Show("Nhóm này đã có thành viên! Không thể xóa!", "", MessageBoxButtons.OK);
                gcNHOM.Focus();
                return;
            }

            if (MessageBox.Show("Ban có thật sự muốn xóa nhóm này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // giu lai vi tri con tro chuot dang tro toi giang vien chon de xoa
                    manhom = ((DataRowView)bdsDSNHOM[bdsDSNHOM.Position])["MANHOM"].ToString();
                    Console.WriteLine("manhom: " + manhom);
                    string cmd = "DELETE FROM NHOM WHERE MANHOM = '" + manhom + "'";
                    int hd_xoa = Program.ExecSqlNonQuery(cmd);
                    if (hd_xoa != 0)
                    {
                        MessageBox.Show("Lỗi xóa nhóm. Bạn hãy thử xóa lại", "", MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show("Xóa nhóm thành công", "", MessageBoxButtons.OK);


                }
                catch (Exception ex)
                {
                    // truong hop cap nhat tren db bi loi
                    MessageBox.Show("Lỗi xóa nhóm. Bạn hãy thử xóa lại!", "", MessageBoxButtons.OK);
                    // do du lieu tu db vào lại giao diện nếu xóa không thành công

                    // hiển thị dòng được trỏ tới để xóa ở trên
                    bdsDSNHOM.Position = bdsDSNHOM.Find("MANHOM", manhom);
                    return;
                }
            }
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dStaoNhom.sp_lay_nhom_tu_doi, Program.mTeam);
            trangThaiBanDau();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
               bdsDSNHOM.Position = viTri;
            }
           
            trangThaiBanDau();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dStaoNhom.sp_lay_nhom_tu_doi, Program.mTeam);
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
    }
}
