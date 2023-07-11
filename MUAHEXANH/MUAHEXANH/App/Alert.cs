using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUAHEXANH.App
{
    public static class Alert
    {
        //Hiển thị thông báo
        public static DialogResult InfoMessageBox(string content, string caption = "Info")
        {
            DialogResult r = MessageBox.Show(content, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return r;
        }


        //Hiển thị lỗi
        public static void ErrorMessageBox(string content, string caption = "Error")
        {
            MessageBox.Show(content, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Hiển thị câu hỏi
        public static DialogResult QuestionMessageBox(string content, string caption = "Question")
        {
            DialogResult r = MessageBox.Show(content, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return r;
        }
    }
}
