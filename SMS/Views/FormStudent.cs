using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class FormStudent : Form
    {
        private bool rightAdd,
            rightEdit,
            rightDelete;

        public FormStudent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询学生档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core(); //实例化BLL层的对象
            this.dataGridView1.DataSource = bll.GetStudentList(
                    this.textBoxSNO.Text.Trim(),
                    this.textBoxSName.Text.Trim()
                )
                .Tables[0]
                .DefaultView;
        }

        /// <summary>
        /// 增加学生档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            //弹出新增界面
            FormStudentEdit frm = new FormStudentEdit();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "新增学生档案成功!\n",
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.buttonQuery_Click(this.buttonQuery, e);
                this.DataGridViewReLocation(dataGridView1, "SNO", frm.SNO);
                return;
            }
        }

        /// <summary>
        /// 修改学生档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            string sno = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            FormStudentEdit frm = new FormStudentEdit(sno);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "修改学生档案成功!\n",
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.buttonQuery_Click(this.buttonQuery, e);
                return;
            }
        }

        /// <summary>
        /// 删除学生档案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemDelete_Click(object sender, EventArgs e)
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
                string sno = this.dataGridView1.SelectedRows[0].Cells["SNO"].Value.ToString();
                studentMS.BLL.student bll = new studentMS.BLL.student(); //实例化BLL层的对象
                try
                {
                    bll.Delete(sno);
                    this.buttonQuery_Click(this.buttonQuery, e);
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

        /// <summary>
        /// 数据绑定后，判断是否启用编辑和删除菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DataBindingComplete(
            object sender,
            DataGridViewBindingCompleteEventArgs e
        )
        {
            this.MenuItemEdit.Enabled = this.dataGridView1.Rows.Count > 0 && rightEdit;
            this.MenuItemDelete.Enabled = this.dataGridView1.Rows.Count > 0 && rightDelete;
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            studentMS.BLL.core core = new studentMS.BLL.core(); //实例化BLL层的对象
            rightAdd = core.HaveRight("2201");
            rightEdit = core.HaveRight("2202");
            rightDelete = core.HaveRight("2203");

            this.MenuItemAdd.Enabled = rightAdd;
        }

        /// <summary>
        /// 右键菜单选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.X > 0 && e.Y > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        /// <summary>
        /// 重新设置选中的行
        /// </summary>
        /// <param name="datagrid"></param>
        /// <param name="filedName"></param>
        /// <param name="keyValue"></param>
        private void DataGridViewReLocation(
            DataGridView datagrid,
            string filedName,
            string keyValue
        )
        {
            if (
                !string.IsNullOrEmpty(keyValue)
                && !string.IsNullOrEmpty(filedName)
                && datagrid != null
            )
            {
                for (int i = 0; i < datagrid.Rows.Count; i++)
                {
                    if (datagrid.Rows[i].Cells[filedName].Value.ToString().Equals(keyValue))
                    {
                        datagrid.ClearSelection();
                        datagrid.Rows[i].Selected = true;
                        datagrid.FirstDisplayedScrollingRowIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
