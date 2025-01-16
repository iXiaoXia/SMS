using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormTeacherEdit : SMS.BaseViews.FormEditBase
    {
        private string _tno = "";

        public FormTeacherEdit()
        {
            InitializeComponent();
        }

        public FormTeacherEdit(string tno)
        {
            InitializeComponent();
            _tno = tno;
        }

        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            string strExpression = "";
            //做数据校验
            if (this.textBox1.Text.Trim() == "")
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
            studentMS.Model.teacher teacherAdd = new studentMS.Model.teacher();
            teacherAdd.TNO = this.textBox1.Text.Trim();
            teacherAdd.TName = this.textBoxSName.Text.Trim();
            if (this.radioButtonBoy.Checked)
                teacherAdd.TSex = "男";
            else if (this.radioButtonGirl.Checked)
                teacherAdd.TSex = "女";
            teacherAdd.Address = this.textBoxAddress.Text.Trim();
            teacherAdd.DeptNO = this.comboBox1.SelectedValue.ToString();
            studentMS.BLL.teacher bll = new studentMS.BLL.teacher();
            try
            {
                if (_tno == "")
                    bll.Add(teacherAdd);
                else
                    bll.Update(teacherAdd);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                string str = "新增";
                if (_tno != "")
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

            //MessageBox.Show("父类Ok");
        }

        protected override void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTeacherEdit_Load(object sender, EventArgs e)
        {
            studentMS.BLL.department bllDept = new studentMS.BLL.department();
            this.comboBox1.DataSource = bllDept.GetAllList().Tables[0];
            this.comboBox1.DisplayMember = "DeptName";
            this.comboBox1.ValueMember = "DeptNO";

            if (_tno == "")
            {
                this.Text = "新增教师档案信息";
            }
            else
            {
                this.Text = "修改教师档案信息";
                studentMS.BLL.teacher bll = new studentMS.BLL.teacher();
                studentMS.Model.teacher studentAdd = bll.GetModel(_tno);
                this.textBox1.Text = studentAdd.TNO;
                this.textBoxSName.Text = studentAdd.TName;
                if (studentAdd.TSex == "男")
                    this.radioButtonBoy.Checked = true;
                else if (studentAdd.TSex == "女")
                    this.radioButtonGirl.Checked = true;
                this.comboBox1.SelectedValue = studentAdd.DeptNO.ToString();
                this.textBoxAddress.Text = studentAdd.Address;
            }
        }
    }
}
