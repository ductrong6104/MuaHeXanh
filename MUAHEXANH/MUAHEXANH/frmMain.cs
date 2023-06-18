using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "KHOA")
            {
                rbKHOA.Visible = true;
                rbGiamSat.Visible = false;
                rbDoiTruong.Visible = false;
            }
            else if (Program.mGroup == "GIAMSAT")
            {
                rbKHOA.Visible = false;
                rbGiamSat.Visible = true;
                rbDoiTruong.Visible = false;
            }
            else if (Program.mGroup == "DOITRUONG" || Program.mGroup == "DOIPHO")
            {
                rbKHOA.Visible = false;
                rbGiamSat.Visible = false;
                rbDoiTruong.Visible = true;
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.frmDN.Show();
            Program.frmChinh.Hide();
        }

        private void btnChiaNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Form frm = this.CheckExists(typeof(frmChiaNhom));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmChiaNhom f = new frmChiaNhom();
                // set property of frmMain: ismdicontainer = true 
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnChiaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChiaViec));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmChiaViec f = new frmChiaViec();
                // set property of frmMain: ismdicontainer = true 
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoDoi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTaoDoi f = new frmTaoDoi();
                // set property of frmMain: ismdicontainer = true 
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChiaDoi));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmChiaDoi f = new frmChiaDoi();
                // set property of frmMain: ismdicontainer = true 
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoNhom));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTaoNhom f = new frmTaoNhom();
                // set property of frmMain: ismdicontainer = true 
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
