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
            FormTeacher temp = new FormTeacher(); //实例化
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

        private void GetView(Form form)
        {
            form.MdiParent = this; //设置父窗体
            form.Show(); //调用方法Show把窗体展示到界面
            form.BringToFront();
            this.setStartPosition(form);
        }

        private void 角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRole temp = new FormRole(); //实例化
            GetView(temp);
        }
    }
}
