using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Views;

namespace SMS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NeedVerifyCode();
            //new studentMS.BLL.core().GetRightByUser("xzz");
            //Application.Run(new FormGradeChart());
        }

        //需要验证码
        public static void NeedVerifyCode()
        {
            //登录
            FormLogin login = new FormLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
