using System;
using System.Windows.Forms;
using SMS.Tools;

namespace SMS.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region 验证码
        private const int ValidCodeLength = 4; //验证码长度
        private String strValidCode = ""; //验证码

        //调用自定义函数,更新验证码
        private void UpdateValidCode()
        {
            strValidCode = ValidCode.CreateRandomCode(ValidCodeLength); //生成随机验证码
            if (strValidCode == "")
                return;
            ValidCode.CreateImage(strValidCode, pictureBox2); //创建验证码图片
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (!VerifyIgnoreCase())
            {
                WhichSelect();
                return;
            }
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
                //获取当前登录用户的所有权限
                new studentMS.BLL.core().GetRightByUser(this.textBoxUID.Text.Trim());
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

        private void WhichSelect()
        {
            if (string.IsNullOrEmpty(textBoxUID.Text))
            {
                this.textBoxUID.Select();
            }
            else if (string.IsNullOrEmpty(textBoxUCode.Text))
            {
                this.textBoxUCode.Select();
            }
            else
            {
                this.textBox1.Select();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            WhichSelect();
            UpdateValidCode();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateValidCode();
        }

        /// <summary>
        ///  验证（区分大小写）
        /// </summary>
        private bool VerifyNotIgnoreCase()
        {
            string validcode = textBox1.Text.Trim();

            char[] ch1 = validcode.ToCharArray();
            char[] ch2 = strValidCode.ToCharArray();
            int Count1 = 0; //字母个数
            int Count2 = 0; //数字个数

            if (String.IsNullOrEmpty(validcode) != true) //验证码不为空
            {
                for (int i = 0; i < strValidCode.Length; i++)
                {
                    if ((ch1[i] >= 'a' && ch1[i] <= 'z') || (ch1[i] >= 'A' && ch1[i] <= 'Z')) //字母
                    {
                        if (ch1[i] == ch2[i])
                        {
                            Count1++;
                        }
                    }
                    else //数字
                    {
                        if (ch1[i] == ch2[i])
                        {
                            Count2++;
                        }
                    }
                }

                int CountSum = Count1 + Count2;
                if (CountSum == strValidCode.Length)
                {
                    MessageBox.Show("验证通过", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateValidCode();
                    textBox1.Text = "";
                    textBox1.Focus();
                    return true;
                }
                else
                {
                    MessageBox.Show("验证失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UpdateValidCode(); //更新验证码
                    textBox1.Text = "";
                    textBox1.Focus();
                    return false;
                }
            }
            else //验证码为空
            {
                MessageBox.Show("请输入验证码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateValidCode(); //更新验证码
                textBox1.Text = "";
                textBox1.Focus();
                return false;
            }
        }

        /// <summary>
        ///  验证（不区分大小写）
        /// </summary>
        private bool VerifyIgnoreCase()
        {
            string validcode = textBox1.Text.Trim();

            if (String.IsNullOrEmpty(validcode) != true) //验证码不为空
            {
                if (validcode.ToLower() == strValidCode.ToLower())
                {
                    //MessageBox.Show("验证通过", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //UpdateValidCode();
                    //textBox1.Text = "";
                    //textBox1.Focus();
                    return true;
                }
                else
                {
                    MessageBox.Show("验证失败", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UpdateValidCode(); //更新验证码
                    textBox1.Text = "";
                    textBox1.Focus();
                    return false;
                }
            }
            else //验证码为空
            {
                MessageBox.Show("请输入验证码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateValidCode(); //更新验证码
                textBox1.Text = "";
                textBox1.Focus();
                return false;
            }
            return true;
        }
    }
}
