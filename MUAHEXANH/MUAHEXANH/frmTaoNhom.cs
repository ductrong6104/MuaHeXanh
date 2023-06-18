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
        public frmTaoNhom()
        {
            InitializeComponent();
        }

        private void frmTaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dStaoNhom.ttsv_trongnhom' table. You can move, or remove it, as needed.
            this.ttsv_trongnhomTableAdapter.Fill(this.dStaoNhom.ttsv_trongnhom);
            // TODO: This line of code loads data into the 'dStaoNhom.ttsv_trongnhom' table. You can move, or remove it, as needed.
            this.ttsv_trongnhomTableAdapter.Fill(this.dStaoNhom.ttsv_trongnhom);
            this.sp_lay_nhom_tu_doiTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_lay_nhom_tu_doiTableAdapter.Fill(this.dStaoNhom.sp_lay_nhom_tu_doi, Program.mTeam);
            this.ttsv_trongnhomTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ttsv_trongnhomTableAdapter.Fill(this.dStaoNhom.ttsv_trongnhom);

        }

        

        
    }
}
