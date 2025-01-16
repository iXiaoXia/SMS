using System;
using System.CodeDom.Compiler;
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
    public partial class FormRole : Form
    {
        public bool rightAdd = false;
        public bool rightDelete = false;
        public bool rightEdit = false;
        public bool rightManage = false;

        public FormRole()
        {
            InitializeComponent();
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new studentMS.BLL.b_role()
                .GetAllList()
                .Tables[0]
                .DefaultView;

            studentMS.BLL.core core = new studentMS.BLL.core(); //实例化BLL层的对象
            rightAdd = core.HaveRight("1101");
            rightEdit = core.HaveRight("1102");
            rightDelete = core.HaveRight("1103");
            rightManage = core.HaveRight("1104");
            this.MenuItemAdd.Enabled = rightAdd;
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取当前记录的RoleID和RoleName
            string RoleID = dataGridView1.CurrentRow.Cells["RoleID"].Value.ToString();
            string RoleName = dataGridView1.CurrentRow.Cells["RoleName"].Value.ToString();
            //打开权限管理界面
            FormRoleRight frm = new FormRoleRight(RoleID, RoleName);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "权限设置成功！",
                    "系统提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                new studentMS.BLL.core().GetRightByRoleID(RoleID);
                FormRole_Load(sender, e);
            }
        }

        private void MenuItemAdd_Click(object sender, EventArgs e)
        {
            FormRoleEdit formRoleEdit = new FormRoleEdit();
            if (formRoleEdit.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("添加成功");
                FormRole_Load(sender, e);
            }
        }

        private void MenuItemEdit_Click(object sender, EventArgs e)
        {
            //获取当前选中的这一行的RoleID
            string RoleID = dataGridView1.CurrentRow.Cells["RoleID"].Value.ToString();
            FormRoleEdit formRoleEdit = new FormRoleEdit(RoleID);
            if (formRoleEdit.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("修改成功");
                FormRole_Load(sender, e);
            }
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            //删除当前选中的这一行的RoleID
            string RoleID = dataGridView1.CurrentRow.Cells["RoleID"].Value.ToString();
            new studentMS.BLL.b_role().Delete(int.Parse(RoleID));
            FormRole_Load(sender, e);
        }
    }
}
