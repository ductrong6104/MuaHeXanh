 using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class FrmWaitTaoDevice : WaitForm
    {
        public Action<String, String, String> Worker;
        public String loai;
        public String ten;
        public String path;

        public FrmWaitTaoDevice(Action<String, String, String> worker, String loai, String ten, String path)
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
            this.StartPosition = FormStartPosition.CenterParent;
            if (worker == null ) 
            {
                throw new ArgumentException();    
            }
            Worker = worker;
            this.loai = loai;
            this.ten = ten;
            this.path = path;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(() => Worker(loai, ten, path)).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void frmWait_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}