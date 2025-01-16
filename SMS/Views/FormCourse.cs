using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridView1.DataSource = bll.GetCourseList(
                    this.textBox1.Text.Trim(),
                    this.textBox2.Text.Trim()
                )
                .Tables[0]
                .DefaultView;
        }

        private void AddMenuItem_Click(object sender, EventArgs e)
        {
            //弹出新增界面
            FormCourseEdit frm = new FormCourseEdit();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "新增课程档案成功!\n",
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.button1_Click(this.button1, e);
                return;
            }
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            string cno = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FormCourseEdit frm = new FormCourseEdit(cno);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "修改课程档案成功!\n",
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.button1_Click(this.button1, e);
                return;
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    this,
                    "您确定要删除所选的记录吗？\n",
                    "删除确认",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            )
            {
                string sno = this.dataGridView1.SelectedRows[0].Cells["CNO"].Value.ToString();
                studentMS.BLL.course bll = new studentMS.BLL.course(); //实例化BLL层的对象
                try
                {
                    bll.Delete(sno);
                    this.button1_Click(this.button1, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        this,
                        "删除失败！\n" + ex.Message,
                        "出错啦",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
        }
    }
}
