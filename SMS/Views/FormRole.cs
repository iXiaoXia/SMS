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
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取当前记录的RoleID和RoleName
            string RoleID = dataGridView1.CurrentRow.Cells["RoleID"].Value.ToString();
            string RoleName = dataGridView1.CurrentRow.Cells["RoleName"].Value.ToString();
            //打开权限管理界面
            FormRoleRight frm = new FormRoleRight(RoleID, RoleName);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(
                    this,
                    "权限设置成功！",
                    "系统提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
