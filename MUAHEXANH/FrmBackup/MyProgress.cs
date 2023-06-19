using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MUAHEXANH.FrmBackup
{
    public partial class MyProgress : Form
    {
        public static int progressValue = 0;
        public static Timer timer;
        public MyProgress()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            progressBarControl.EditValue = 0;
            timer = new Timer();
            timer.Interval = 1000; // Đặt khoảng thời gian cập nhật (ms)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật giá trị của ProgressBarControl từ biến public static
            ProgressBarControl progressBarControl = ((Timer)sender).Tag as ProgressBarControl;
            if (progressBarControl != null)
            {
                progressBarControl.EditValue = progressValue;
                progressBarControl.Refresh();
            }

            // Dừng Timer khi đạt giá trị tối đa
            if (progressValue >= 100)
            {
                timer.Stop();
            }
            else
            {
                progressValue += 10; // Tăng giá trị theo nhu cầu của bạn
            }
        }

    }
}
