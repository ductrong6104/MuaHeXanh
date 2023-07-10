using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.frmXaApNhaDan
{
    public partial class frmThemDiaBan : Form
    {
        private int viTri;
        public frmThemDiaBan()
        {
            InitializeComponent();
        }
        public void trangThaiBanDau()
        {
            btnThem.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            gcDiaBan.Enabled = true;
            pnlThemDiaBan.Enabled = false;
        }
        public void trangThaiChuaGhi()
        {
            btnThem.Enabled  = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            gcDiaBan.Enabled = false;
            pnlThemDiaBan.Enabled = true;
        }
        private void frmThemDiaBan_Load(object sender, EventArgs e)
        {
            dSthemXaApNhaDan.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dSthemXaApNhaDan.DiaBan' table. You can move, or remove it, as needed.
            this.diaBanTableAdapter.Fill(this.dSthemXaApNhaDan.DiaBan);

            trangThaiBanDau();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDiaBan.Position;
            bdsDiaBan.AddNew();
            trangThaiChuaGhi();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                bdsDiaBan.EndEdit();
                bdsDiaBan.ResetCurrentItem();
                this.diaBanTableAdapter.Update(this.dSthemXaApNhaDan.DiaBan);
            }

            catch(Exception ex) 
            {
                MessageBox.Show("Lỗi ghi địa bàn!", "", MessageBoxButtons.OK);
                Console.WriteLine(ex.ToString());
                // tro ve trang thai luc them cho user dieu chinh lai
                return;
            }
            MessageBox.Show("Ghi địa bàn thành công!", "", MessageBoxButtons.OK);
            this.diaBanTableAdapter.Fill(this.dSthemXaApNhaDan.DiaBan);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn xóa địa bàn này không?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsDiaBan.RemoveCurrent();
                    this.diaBanTableAdapter.Update(this.dSthemXaApNhaDan.DiaBan);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa địa bàn!", "", MessageBoxButtons.OK);
                    Console.WriteLine(ex.ToString());
                    // tro ve trang thai luc them cho user dieu chinh lai
                    return;
                }
                MessageBox.Show("Xóa địa bàn thành công!", "", MessageBoxButtons.OK);
            }    
                
            this.diaBanTableAdapter.Fill(this.dSthemXaApNhaDan.DiaBan);
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
                bdsDiaBan.Position = viTri;
            bdsDiaBan.CancelEdit();
            trangThaiBanDau();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.diaBanTableAdapter.Fill(this.dSthemXaApNhaDan.DiaBan);

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
