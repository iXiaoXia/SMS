using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.Views;

namespace SMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void GetView(Form form)
        {
            form.MdiParent = this; //设置父窗体
            form.Show(); //调用方法Show把窗体展示到界面
            form.BringToFront();
            this.setStartPosition(form);
        }

        private void MenuItem22_Click(object sender, EventArgs e)
        {
            FormStudent temp = new FormStudent(); //实例化
            temp.MdiParent = this; //设置父窗体
            temp.Show(); //调用方法Show把窗体展示到界面
            temp.BringToFront();
            this.setStartPosition(temp);
        }

        private void setStartPosition(Form temp)
        {
            temp.Left = (this.Width - temp.Width) / 2;
            temp.Top = (this.Height - temp.Height) / 2;
        }

        private void FormMain_QueryAccessibilityHelp(
            object sender,
            QueryAccessibilityHelpEventArgs e
        ) { }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }

        private void MenuItem31_Click(object sender, EventArgs e)
        {
            FormCourse temp = new FormCourse(); //实例化
            GetView(temp);
        }

        private void MenuItem23_Click(object sender, EventArgs e)
        {
            SMS.Views.FormTeacher temp = new SMS.Views.FormTeacher(); //实例化
            GetView(temp);
        }

        private void MenuItem32_Click(object sender, EventArgs e)
        {
            FormCS temp = new FormCS(); //实例化
            GetView(temp);
        }

        private void MenuItem41_Click(object sender, EventArgs e)
        {
            FormInputScore temp = new FormInputScore(); //实例化
            GetView(temp);
        }

        private void MenuItem42_Click(object sender, EventArgs e)
        {
            FormScoreQuery temp = new FormScoreQuery(); //实例化
            GetView(temp);
        }

        private void MenuItem51_Click(object sender, EventArgs e)
        {
            FormScoreStatistic temp = new FormScoreStatistic(); //实例化
            GetView(temp);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRole temp = new FormRole(); //实例化
            GetView(temp);
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser temp = new FormUser(); //实例化
            GetView(temp);
        }

        private void MenuItem52_Click(object sender, EventArgs e)
        {
            FormCourseStatistic temp = new FormCourseStatistic(); //实例化
            GetView(temp);
        }

        private void MenuItem21_Click(object sender, EventArgs e)
        {
            FormDept temp = new FormDept(); //实例化
            GetView(temp);
        }

        /// <summary>
        /// 重新登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem11_Click(object sender, EventArgs e)
        {
            //关闭现在所有的窗体
            //提示是否确定要重新登录
            if (
                MessageBox.Show(
                    "确定要重新登录吗？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                ) == DialogResult.OK
            )
            {
                int Count = Application.OpenForms.Count;
                for (int i = Count - 1; i >= 0; i--)
                {
                    Application.OpenForms[i].Close();
                }

                Application.Restart(); // 重新启动应用
            }
        }

        /// <summary>
        /// 安全退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem12_Click(object sender, EventArgs e)
        {
            //提示是否确定要退出
            if (
                MessageBox.Show(
                    "确定要退出吗？",
                    "提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information
                ) == DialogResult.OK
            )
                Application.Exit();
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            FormGradeChart temp = new FormGradeChart(); //实例化
            GetView(temp);
        }

        private void MenuItem71_Click(object sender, EventArgs e)
        {
            FormManual temp = new FormManual(); //实例化
            GetView(temp);
        }

        private void MenuItem72_Click(object sender, EventArgs e)
        {
            FormAboutSystem temp = new FormAboutSystem(); //实例化
            GetView(temp);
        }
    }
}
