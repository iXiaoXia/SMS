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
    public partial class FormRoleEdit : Form
    {
        private string _roleID;

        public string RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
        }

        public FormRoleEdit()
        {
            InitializeComponent();
            //给comboBox1设置数据源
            comboBox1.DataSource = new string[] { "1", "0" };
        }

        public FormRoleEdit(string roleID)
        {
            InitializeComponent();
            _roleID = roleID;
            textBox1.Text = _roleID;

            //给comboBox1设置数据源
            comboBox1.DataSource = new string[] { "1", "0" };
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //获取文本框的值
            string label = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            //将label尝试转成int型，如果转不成，则提示用户
            if (!int.TryParse(label, out int labelInt))
            {
                MessageBox.Show("用户编号请输入正确的数字");
                return;
            }
            int status = Convert.ToInt32(comboBox1.SelectedValue);
            string strExpression = "";
            //做数据校验
            if (label == "")
            {
                strExpression += "角色编号不能为空!\n";
            }
            if (name == "")
            {
                strExpression += "角色名称不能为空!\n";
            }
            if (strExpression != "")
            {
                MessageBox.Show(
                    this,
                    strExpression,
                    "校验错误",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            studentMS.BLL.b_role bll = new studentMS.BLL.b_role();
            studentMS.Model.b_role model = new studentMS.Model.b_role();
            model.RoleName = name;
            model.RoleID = labelInt;
            model.Status = status;
            try
            {
                if (!String.IsNullOrEmpty(_roleID))
                    bll.Update(model);
                else
                    bll.Add(model);

                this.DialogResult = DialogResult.OK;

                _roleID = model.RoleID.ToString();
            }
            catch (Exception ex)
            {
                if (String.IsNullOrEmpty(_roleID))
                    MessageBox.Show(
                        this,
                        ex.Message,
                        "新增失败",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                else if (_roleID != "")
                    MessageBox.Show(
                        this,
                        ex.Message,
                        "修改失败",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRoleEdit_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_roleID))
                this.Text = "新增角色信息";
            else
            {
                this.Text = "修改角色信息";
                studentMS.Model.b_role model = new studentMS.BLL.b_role().GetModel(
                    int.Parse(_roleID)
                );
                textBox1.Text = model.RoleID.ToString();
                textBox2.Text = model.RoleName;
                comboBox1.Text = model.Status.ToString();
            }
        }
    }
}
