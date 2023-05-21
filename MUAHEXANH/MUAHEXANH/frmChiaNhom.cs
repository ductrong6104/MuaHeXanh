using DevExpress.XtraEditors.Mask.Design;
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
    public partial class frmChiaNhom : Form
    {
        int viTri;
        
        public frmChiaNhom()
        {
            InitializeComponent();
        }

        // chua cho phep hieu chinh tren bảng thanhviennhom
        // chi nhung sinh vien thuộc đội chứa nhóm này thì mới thêm
        private void trangThaiBanDau()
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = btnHieuChinh.Enabled  = false;

            gcNhom.Enabled = true;
            dgvTVN.Enabled = true;
            pnlTVN.Enabled = false;
        }

        private void trangThaiChuaGhi()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;

            gcNhom.Enabled = false;
            dgvTVN.Enabled = false;
            pnlTVN.Enabled = true;
        }
        private void frmChiaNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSchiaNhom.ttsv_trong_doi' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dSchiaNhom.ThanhVienNhom' table. You can move, or remove it, as needed.
            


            // TODO: This line of code loads data into the 'dSchiaNhom.Nhom' table. You can move, or remove it, as needed.
            dSchiaNhom.EnforceConstraints = false;

            this.sp_lay_doi_tu_chiendichTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_doi_tu_chiendichTableAdapter.Fill(this.dSchiaNhom.sp_lay_doi_tu_chiendich, Program.maChienDich);
            
            cmbDoi.DataSource = sp_lay_doi_tu_chiendichBindingSource;
            cmbDoi.ValueMember = "MADOI";
            cmbDoi.DisplayMember = "TENDOI";
            cmbDoi.SelectedIndex = 0;
            trangThaiBanDau();
        }



       

        private void btnDoi_Click(object sender, EventArgs e)
        {
            this.ttsv_trong_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ttsv_trong_doiTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_doi);
            this.sp_lay_nhom_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dSchiaNhom.sp_lay_nhom_tu_doi, cmbDoi.SelectedValue.ToString());
            // TODO: This line of code loads data into the 'dSchiaNhom.ttsv_trong_nhom' table. You can move, or remove it, as needed.
            this.ttsv_trong_nhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom);
        }



        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = ttsv_trong_nhomBindingSource.Position;
            
            txtMaNhom.Text = ((DataRowView)sp_lay_nhom_tu_doiBindingSource[sp_lay_nhom_tu_doiBindingSource.Position])["MANHOM"].ToString();
            txtMaSV.Text = cmbSinhVien.SelectedValue.ToString();
            trangThaiChuaGhi();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = ttsv_trong_nhomBindingSource.Position;

            trangThaiChuaGhi();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Console.WriteLine(txtMaNhom.Text);
            Console.WriteLine(txtMaSV.Text);
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn sinh viên!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                cmbSinhVien.Focus();
                return;
            }


            try
            {
                // ket thuc hieu chinh: ghi
                string cmd = "INSERT INTO THANHVIENNHOM VALUES('" + txtMaNhom.Text.ToString() + "', '" + txtMaSV.Text.ToString() + "')";
                int hd_them = Program.ExecSqlNonQuery(cmd);
                if (hd_them != 0)
                {
                    MessageBox.Show("Lỗi xóa thành viên trong nhóm. Bạn hãy thử xóa lại\n" + hd_them.ToString(), "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("thêm thành viên thành công", "", MessageBoxButtons.OK);
                //this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên vào nhóm, vui lòng kiểm tra lại!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom);
            trangThaiBanDau();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string masv = "";
            string manhom = "";
            if (MessageBox.Show("Ban có thật sự muốn xóa sinh viên khỏi nhóm này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // giu lai vi tri con tro chuot dang tro toi giang vien chon de xoa
                    masv = ((DataRowView)ttsv_trong_nhomBindingSource[ttsv_trong_nhomBindingSource.Position])["MASV"].ToString();
                    manhom = ((DataRowView)sp_lay_nhom_tu_doiBindingSource[sp_lay_nhom_tu_doiBindingSource.Position])["MANHOM"].ToString();
                    Console.WriteLine(masv);
                    Console.WriteLine(manhom);
                    string cmd = "DELETE FROM THANHVIENNHOM WHERE MANHOM = '" + manhom + "' AND MASV = '" + masv + "'";
                    int hd_xoa = Program.ExecSqlNonQuery(cmd);
                    if (hd_xoa != 0)
                    {
                        MessageBox.Show("Lỗi xóa thành viên trong nhóm. Bạn hãy thử xóa lại\n" + hd_xoa.ToString(), "", MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show("Xóa thành viên thành công", "", MessageBoxButtons.OK);
                    
                 
                }
                catch (Exception ex)
                {
                    // truong hop cap nhat tren db bi loi
                    MessageBox.Show("Lỗi xóa lớp. Bạn hãy thử xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    // do du lieu tu db vào lại giao diện nếu xóa không thành công

                    // hiển thị dòng được trỏ tới để xóa ở trên
                    ttsv_trong_nhomBindingSource.Position = ttsv_trong_nhomBindingSource.Find("MASV", masv);
                    return;
                }
            }
            this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom);
            trangThaiBanDau();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //neu chua ghi
            
            // dang bam nut button
            if (btnThem.Enabled == false || btnHieuChinh.Enabled == false) ttsv_trong_nhomBindingSource.Position = viTri;
            trangThaiBanDau();

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.ttsv_trong_doiTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_doi);
                this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.Message, " ", MessageBoxButtons.OK);
                return;
            }
            trangThaiBanDau();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbSinhVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                txtMaSV.Text = cmbSinhVien.SelectedValue.ToString();
            }
            catch
            {

            }
        }

        
    }
}
