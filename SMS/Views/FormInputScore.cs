using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentMS.BLL;

namespace SMS.Views
{
    public partial class FormInputScore : Form
    {
        private List<string> oringinalScore;

        public List<string> OringinalScore
        {
            get { return oringinalScore; }
            set { oringinalScore = value; }
        }

        public FormInputScore()
        {
            InitializeComponent();
        }

        private void FormInputScore_Load(object sender, EventArgs e)
        {
            studentMS.BLL.course bll = new studentMS.BLL.course();
            this.comboBox1.DataSource = bll.GetAllList().Tables[0];
            this.comboBox1.DisplayMember = "CName";
            this.comboBox1.ValueMember = "CNO";
            comboBox1_SelectedIndexChanged(this.dataGridView1, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Items.Count <= 0 || this.comboBox1.SelectedValue.ToString() == "")
                return;

            string cno = this.comboBox1.SelectedValue.ToString();
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridView1.DataSource = bll.GetOneCourseStudentList(cno).Tables[0].DefaultView;
            GetScoreFromDataSet(cno);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    this,
                    "确定要保提交成绩吗？",
                    "提交确认",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            )
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string sno = dataGridView1.Rows[i].Cells["SNO"].Value.ToString();
                    string cno = comboBox1.SelectedValue.ToString();
                    string score = dataGridView1.Rows[i].Cells["Score"].Value.ToString();
                    if (OringinalScore[i] != score)
                    {
                        studentMS.Model.s_c model = new studentMS.Model.s_c();
                        studentMS.BLL.s_c bll = new studentMS.BLL.s_c();
                        model.SNO = sno;
                        model.CNO = cno;
                        try
                        {
                            model.Score = Decimal.Parse(score);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                this,
                                "分数请输入数字！\n" + ex.Message,
                                "错误",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return;
                        }
                        bll.Update(model);
                    }
                    else
                    {
                        continue;
                    }
                }
                MessageBox.Show(
                    this,
                    "更新完成！\n",
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            return;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="cno"></param>
        public void GetScoreFromDataSet(string cno)
        {
            OringinalScore = new List<string>();

            studentMS.BLL.core bll = new studentMS.BLL.core();

            // 获取DataSet
            DataSet dataSet = bll.GetOneCourseStudentList(cno);

            // 确保DataSet有数据表
            if (dataSet.Tables.Count > 0)
            {
                // 获取第一个DataTable
                DataTable table = dataSet.Tables[0];

                // 遍历DataTable的每一行
                foreach (DataRow row in table.Rows)
                {
                    // 获取指定列的值，比如"SName"和"Score"
                    string score = row["Score"].ToString();
                    //添加到分数列表
                    OringinalScore.Add(score);
                }
            }
        }
    }
}
