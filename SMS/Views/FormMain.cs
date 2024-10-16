﻿using System;
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
            temp.MdiParent = this; //设置父窗体
            temp.Show(); //调用方法Show把窗体展示到界面
            temp.BringToFront();
            this.setStartPosition(temp);
        }

        private void MenuItem23_Click(object sender, EventArgs e)
        {
            FormTeacher temp = new FormTeacher(); //实例化
            temp.MdiParent = this; //设置父窗体
            temp.Show(); //调用方法Show把窗体展示到界面
            temp.BringToFront();
            this.setStartPosition(temp);
        }
    }
}
