using DevExpress.XtraWaitForm;
using MUAHEXANH.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH
{
    public partial class FrmWaitBackup : WaitForm
    {
        public Action<int, String, String, String> Worker;
        public int backupType;
        public String deviceName;
        public String url;
        public String description;
        public FrmWaitBackup(Action<int, String, String, String> worker, int backupType,
            String deviceName, String url, String description)
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
            this.StartPosition = FormStartPosition.CenterParent;
            if (worker == null)
            {
                throw new ArgumentException();
            }
            this.Worker = worker;
            this.backupType = backupType;
            this.deviceName = deviceName;
            this.url = url;
            this.description = description;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(() => Worker(backupType, deviceName, url, description))
                .ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
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