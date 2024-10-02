using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentMS.Model;

namespace SMS
{
    public partial class FormStudentEdit : Form
    {
        public FormStudentEdit()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string strExpression = "";
            //做数据校验
            if (this.textBoxSNO.Text.Trim() == "")
            {
                strExpression += "学号不能为空!\n";
            }
            if (this.textBoxSName.Text.Trim() == "")
            {
                strExpression += "姓名不能为空!\n";
            }
            if (this.textBoxAddress.Text.Trim() == "")
            {
                strExpression += "地址不能为空!\n";
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

            //从界面获取数据并保存到Model里面的studentAdd对象
            student studentAdd = new student();
            studentAdd.SNO = this.textBoxSNO.Text.Trim();
            studentAdd.SName = this.textBoxSName.Text.Trim();
            if (this.radioButtonBoy.Checked)
                studentAdd.SSex = "男";
            else if (this.radioButtonGirl.Checked)
                studentAdd.SSex = "女";
            studentAdd.SBirthday = this.dateTimePickerSBirthday.Value;
            studentAdd.DeptNO = this.textBoxDeptNO.Text.Trim();
            studentAdd.Address = this.textBoxAddress.Text.Trim();

            //调用BLL层的方法将数据保存到数据库
            studentMS.BLL.student bll = new studentMS.BLL.student();
            try
            {
                bll.Add(studentAdd);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "新增学生档案信息失败\n" + ex.Message,
                    "出错啦",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    }
}
