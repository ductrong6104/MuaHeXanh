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
            if (Program.mGroup == "GIAMSAT")
            {
                rbGiamSat.Visible = true;
                rbDoiTruong.Visible = false;
            }
            else if (Program.mGroup == "DOITRUONG" || Program.mGroup == "DOIPHO")
            {
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
    }
}
