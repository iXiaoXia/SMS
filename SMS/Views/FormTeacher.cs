using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormTeacher : SMS.Views.FormBase
    {
        // 添加权限控制变量
        private bool rightAdd,
            rightEdit,
            rightDelete;

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

        // 添加数据绑定完成事件
        private void dataGridView1_DataBindingComplete(
            object sender,
            DataGridViewBindingCompleteEventArgs e
        )
        {
            this.EditStripMenuItem.Enabled = this.dataGridView1.Rows.Count > 0 && rightEdit;
            this.DeleteStripMenuItem.Enabled = this.dataGridView1.Rows.Count > 0 && rightDelete;
        }

        // 添加右键选中行事件
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.X > 0 && e.Y > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        // 添加 Form_Load 事件处理权限初始化
        private void FormTeacher_Load(object sender, EventArgs e)
        {
            studentMS.BLL.core core = new studentMS.BLL.core();
            rightAdd = core.HaveRight("2301"); // 教师增加权限码
            rightEdit = core.HaveRight("2302"); // 教师修改权限码
            rightDelete = core.HaveRight("2303"); // 教师删除权限码

            this.AddStripMenuItem.Enabled = rightAdd;
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
