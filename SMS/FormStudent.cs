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
        public FormStudent()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            studentMS.BLL.student bll = new studentMS.BLL.student(); //实例化BLL层的对象
            this.dataGridView1.DataSource = bll.GetAllList().Tables[0].DefaultView;
        }

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
                return;
            }
        }
    }
}
