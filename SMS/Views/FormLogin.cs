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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strError = "";
            string UID = this.textBoxUID.Text.Trim();
            string UCode = this.textBoxUCode.Text.Trim();
            if (UID == "")
                strError += "用户名不能为空!\n";
            if (UCode == "")
                strError += "密码不能为空!\n";
            if (strError != "")
            {
                MessageBox.Show(
                    this,
                    strError,
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            studentMS.BLL.core core = new studentMS.BLL.core();

            if (core.ExistUIDUCode(UID, UCode))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    this,
                    "用户名或者密码输入错误!",
                    "友情提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.textBoxUID.Select();
        }
    }
}
