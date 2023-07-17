using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class frmChiaViec : Form
    {
        private string manhomTruocKhiSua;
        private bool dangThem;
        private int viTri;
        private string maDoi;
        public frmChiaViec()
        {
            InitializeComponent();
        }
        private string UnicodeToUTF8(string strFrom)
        {
            byte[] bytSrc;
            byte[] bytDestination;
            string strTo = String.Empty;

            bytSrc = Encoding.Unicode.GetBytes(strFrom);
            bytDestination = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, bytSrc);
            strTo = Encoding.ASCII.GetString(bytDestination);

            return strTo;
        }

        private void trangThaiBanDau()
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnHieuChinh.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled  = false;
            btnLoc.Enabled = true;
            pnlPhanViec.Enabled = false;
            gcPhanViec.Enabled = true;
            deNgay.Enabled = true;
            cmbBuoi.Enabled = true;
        }

        private void trangThaiChuaGhi()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            btnLoc.Enabled = false;
            pnlPhanViec.Enabled = true;
            gcPhanViec.Enabled = false;
            deNgay.Enabled = false;
            cmbBuoi.Enabled = false;
        }

        private void frmChiaViec_Load(object sender, EventArgs e)
        {
            this.deNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            dgvCongViec.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvCongViec.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
           
            deNgay.DateTime = DateTime.Now.AddDays(1);
            dSchiaViec.EnforceConstraints = false;
            cmbBuoi.SelectedIndex = 0;
            
            using (SqlDataReader layMaDoi = Program.ExecSqlDataReader("SELECT MADOI FROM DOI WHERE GIAMSAT1 = '" + Program.username + "' OR GIAMSAT2='" + Program.username + "'"))
            {
                layMaDoi.Read();
                maDoi = layMaDoi.GetString(0);
            }
            DataTable dsNhom = Program.ExecSqlDataTable("SELECT MANHOM, TENNHOM FROM NHOM WHERE MADOI='" + maDoi+"'");
            
            this.sp_lay_dsphancong_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_dsphancong_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_dsphancong_tu_doi, maDoi, deNgay.Text, cmbBuoi.Text);
            this.sp_lay_dscongviec_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_dscongviec_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_dscongviec_tu_doi, Program.mTeam);
            cmbNhom.DataSource = dsNhom;
            cmbNhom.DisplayMember = "TENNHOM";
            cmbNhom.ValueMember = "MANHOM";
            this.sp_lay_ap_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_ap_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_ap_tu_doi, maDoi);
 
            cmbAp.SelectedIndex = 0;

            this.sp_lay_dscongviec_tu_apTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_dscongviec_tu_apTableAdapter.Fill(this.dSchiaViec.sp_lay_dscongviec_tu_ap, cmbAp.SelectedValue.ToString(), deNgay.Text);
            //if (bdsDSPHANCONG.Count == 0)
            //{
            //    MessageBox.Show("Chưa có nhóm nào được phân việc vào hôm nay", "", MessageBoxButtons.OK);
            //}
            trangThaiBanDau();
        }

        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (deNgay.DateTime.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày này đã trôi qua! Không cần thêm nữa!", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                deNgay.Focus();
                return;
            }

            
            dangThem = true;
            viTri = bdsDSPHANCONG.Position;
            trangThaiChuaGhi();
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDSPHANCONG.Count == 0)
            {
                MessageBox.Show("không có nhóm nào để chỉnh sửa! Vui lòng chọn ngày khác", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                deNgay.Focus();
                return;
            }
            if (deNgay.DateTime.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày này đã trôi qua! Không cần chỉnh sửa nữa!", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                deNgay.Focus();
                return;
            }
            dangThem = false;
            manhomTruocKhiSua = ((DataRowView)bdsDSPHANCONG[bdsDSPHANCONG.Position])["MANHOM"].ToString();
            viTri = bdsDSPHANCONG.Position;
            trangThaiChuaGhi();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (cmbNhom.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn nhóm!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                cmbNhom.Focus();
                return;
            }
           
            if (cmbCongViec.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn công việc!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                cmbCongViec.Focus();
                return;
            }
            if (cmbAp.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn ấp!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                cmbAp.Focus();
                return;
            }


            try
            {
                string cmd;
                if (dangThem == true)
                {
                    cmd = "INSERT INTO PHANCONG VALUES('"
                               + cmbNhom.SelectedValue.ToString() + "', N'"
                               + cmbBuoi.Text.ToString()
                               + "', '" + deNgay.DateTime.Year + "-" + deNgay.DateTime.Month + "-" + deNgay.DateTime.Day + "' , '"
                               + cmbCongViec.SelectedValue.ToString() + "')";
                    Console.WriteLine("cmd them cv: " + cmd);
                }
                else
                {

                    cmd = "UPDATE PHANCONG " +
                        "SET MANHOM = '"+ cmbNhom.SelectedValue.ToString() 
                       + "',  MACV = '" + cmbCongViec.SelectedValue.ToString() 
                       + "' where MANHOM = '" + manhomTruocKhiSua + "' AND NGAY = '" + deNgay.DateTime.Year + "-" + deNgay.DateTime.Month + "-" + deNgay.DateTime.Day + "' AND BUOI = '" + cmbBuoi.Text.ToString() + "'"; ;
                    Console.WriteLine("cmd sua cv: " + cmd);
                }
                // ket thuc hieu chinh: ghi
               
                int hd_them = Program.ExecSqlNonQuery(cmd);
                if (hd_them != 0)
                {
                    MessageBox.Show("Lỗi ghi việc cho nhóm. Nhóm này đã được phân việc ngày này!", "", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("ghi việc cho nhóm thành công", "", MessageBoxButtons.OK);
                //this.ttsv_trong_nhomTableAdapter.Fill(this.dSchiaNhom.ttsv_trong_nhom);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi công việc cho nhóm!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            this.sp_lay_dsphancong_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_dsphancong_tu_doi, maDoi, deNgay.Text, cmbBuoi.Text);
            trangThaiBanDau();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDSPHANCONG.Count == 0)
            {
                MessageBox.Show("không có nhóm nào để xóa! Vui lòng chọn ngày khác", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                deNgay.Focus();
                return;
            }
            if (deNgay.DateTime.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Nhóm này đã hoàn thành công việc! Không thể xóa", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                deNgay.Focus();
                return;
            }
            string buoi = "";
            string manhom = "";
            string ngay = "";
            if (MessageBox.Show("Ban có thật sự muốn xóa công việc đã phân cho nhóm này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // giu lai vi tri con tro chuot dang tro toi giang vien chon de xoa
                    manhom = ((DataRowView)bdsDSPHANCONG[bdsDSPHANCONG.Position])["MANHOM"].ToString();
                    ngay = ((DataRowView)bdsDSPHANCONG[bdsDSPHANCONG.Position])["NGAY"].ToString();
                    buoi = ((DataRowView)bdsDSPHANCONG[bdsDSPHANCONG.Position])["BUOI"].ToString();
                    Console.WriteLine("buoi: " + buoi);
                    Console.WriteLine("manhom: " + manhom);
                    Console.WriteLine("ngay: " + ngay);
                    string cmd = "DELETE FROM PHANCONG WHERE MANHOM = '" + manhom + "' AND NGAY = '" + ngay + "' AND BUOI = '" + buoi + "'";
                    int hd_xoa = Program.ExecSqlNonQuery(cmd);
                    if (hd_xoa != 0)
                    {
                        MessageBox.Show("Lỗi xóa công việc đã chia cho nhóm. Bạn hãy thử xóa lại", "", MessageBoxButtons.OK);
                        return;
                    }
                    MessageBox.Show("Xóa công việc của nhóm thành công", "", MessageBoxButtons.OK);


                }
                catch (Exception ex)
                {
                    // truong hop cap nhat tren db bi loi
                    MessageBox.Show("Lỗi xóa công việc đã chia cho nhóm. Bạn hãy thử xóa lại", "", MessageBoxButtons.OK);
                    // do du lieu tu db vào lại giao diện nếu xóa không thành công

                    // hiển thị dòng được trỏ tới để xóa ở trên
                    bdsDSPHANCONG.Position = bdsDSPHANCONG.Find("MANHOM", manhom);
                    return;
                }
            }
            this.sp_lay_dsphancong_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_dsphancong_tu_doi, maDoi, deNgay.Text, cmbBuoi.Text);
            trangThaiBanDau();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //neu chua ghi

            // dang bam nut button
            if (btnThem.Enabled == false || btnHieuChinh.Enabled == false) bdsDSPHANCONG.Position = viTri;
            trangThaiBanDau();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sp_lay_dsphancong_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_dsphancong_tu_doi, maDoi, deNgay.Text, cmbBuoi.Text);
                this.sp_lay_dscongviec_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_dscongviec_tu_doi, Program.mTeam);

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

    

    

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (deNgay.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn ngày!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                deNgay.Focus();
                return;
            }
            if (cmbBuoi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn buổi!Vui lòng chọn", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                cmbBuoi.Focus();
                return;
            }

            this.sp_lay_dsphancong_tu_doiTableAdapter.Fill(this.dSchiaViec.sp_lay_dsphancong_tu_doi, maDoi, deNgay.Text, cmbBuoi.Text);
            this.sp_lay_dscongviec_tu_apTableAdapter.Fill(this.dSchiaViec.sp_lay_dscongviec_tu_ap, cmbAp.SelectedValue.ToString(), deNgay.Text);
            if (bdsDSPHANCONG.Count == 0)
            {
                MessageBox.Show("Chưa có nhóm nào được phân việc vào ngày này", "", MessageBoxButtons.OK);
            }
        }

        private void cmbAp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.sp_lay_dscongviec_tu_apTableAdapter.Fill(this.dSchiaViec.sp_lay_dscongviec_tu_ap, cmbAp.SelectedValue.ToString(), deNgay.Text);
            if (cmbCongViec.Items.Count == 0)
            {
                MessageBox.Show("không có công việc nào cần phân công lúc này!", "", MessageBoxButtons.OK);
                // đưa con nháy về text box
                deNgay.Focus();
                return;
            }
        }
    }
}
