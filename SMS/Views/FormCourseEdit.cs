using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormCourseEdit : SMS.BaseViews.FormEditBase
    {
        private string _cno = "";

        public FormCourseEdit()
        {
            InitializeComponent();
        }

        public FormCourseEdit(string cno)
        {
            InitializeComponent();
            _cno = cno;
        }

        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            string strExpression = "";
            //做数据校验
            if (this.textBox1.Text.Trim() == "")
            {
                strExpression += "课程编号不能为空!\n";
            }
            if (this.textBox2.Text.Trim() == "")
            {
                strExpression += "课程名称不能为空!\n";
            }
            if (this.textBox3.Text.Trim() == "")
            {
                strExpression += "学分不能为空!\n";
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
            studentMS.Model.course courseAdd = new studentMS.Model.course();
            courseAdd.CNO = this.textBox1.Text.Trim();
            courseAdd.CName = this.textBox2.Text.Trim();
            //加一个是否可以转换的判断
            try
            {
                courseAdd.Credit = Decimal.Parse(this.textBox3.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    ex.Message,
                    "学分只能为数字",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            studentMS.BLL.course bll = new studentMS.BLL.course();
            try
            {
                if (_cno == "")
                    bll.Add(courseAdd);
                else
                    bll.Update(courseAdd);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                string str = "新增";
                if (_cno != "")
                    str = "修改";
                MessageBox.Show(
                    this,
                    str + "学生档案信息失败\n" + ex.Message,
                    "出错啦",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        protected override void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCourseEdit_Load(object sender, EventArgs e)
        {
            if (_cno == "")
            {
                this.Text = "新增课程档案信息";
            }
            else
            {
                this.Text = "修改课程档案信息";
                studentMS.BLL.course bll = new studentMS.BLL.course();
                studentMS.Model.course courseEdit = bll.GetModel(_cno);
                this.textBox1.Text = courseEdit.CNO;
                this.textBox2.Text = courseEdit.CName;
                this.textBox3.Text = courseEdit.Credit.ToString();
            }
        }
    }
}
