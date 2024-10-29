using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SMS.Views;

namespace SMS
{
    public partial class FormTeacher : SMS.Views.FormBase
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core(); //实例化BLL层的对象
            this.dataGridView1.DataSource = bll.GetTeacherList(
                    this.textBox1.Text.Trim(),
                    this.textBoxSName.Text.Trim()
                )
                .Tables[0]
                .DefaultView;
        }

        private void AddStripMenuItem_Click(object sender, EventArgs e)
        {
            SMS.Views.FormTeacherEdit frm = new SMS.Views.FormTeacherEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "新增教师档案成功!\n",
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.button1_Click(this.button1, e);
                return;
            }
        }

        private void EditStripMenuItem_Click(object sender, EventArgs e)
        {
            string tno = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FormTeacherEdit frm = new FormTeacherEdit(tno);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "修改教师档案成功!\n",
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.button1_Click(this.button1, e);
                return;
            }
        }

        private void DeleteStripMenuItem_Click(object sender, EventArgs e)
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
                string tno = this.dataGridView1.SelectedRows[0].Cells["TNO"].Value.ToString();
                studentMS.BLL.teacher bll = new studentMS.BLL.teacher(); //实例化BLL层的对象
                try
                {
                    bll.Delete(tno);
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
