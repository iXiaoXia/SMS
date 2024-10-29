using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormCS : Form
    {
        public FormCS()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core(); //实例化BLL层的对象
            this.dataGridView1.DataSource = bll.GetStudentList(
                    this.textBoxSNO.Text.Trim(),
                    this.textBoxSName.Text.Trim()
                )
                .Tables[0]
                .DefaultView;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string sno = this.dataGridView1.SelectedRows[0].Cells["SNO"].Value.ToString();

            string cno = this.dataGridView3.SelectedRows[0].Cells["CNO2"].Value.ToString();

            studentMS.BLL.s_c bll = new studentMS.BLL.s_c();

            studentMS.Model.s_c model = new studentMS.Model.s_c();
            model.SNO = sno;
            model.CNO = cno;
            try
            {
                bll.Add(model);
                this.dataGridView1_SelectionChanged(this.dataGridView1, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "选课出错！\n" + ex.Message,
                    "出错啦",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= 0)
                return;

            string sno = this.dataGridView1.SelectedRows[0].Cells["SNO"].Value.ToString();

            studentMS.BLL.core bll = new studentMS.BLL.core();

            this.dataGridView2.DataSource = bll.GetSelectedCourseList(sno).Tables[0].DefaultView;

            this.dataGridView3.DataSource = bll.GetUnSelectedCourseList(sno).Tables[0].DefaultView;

            //这里要设置选课按钮和退课按钮的可用状态，不然就会出错
            //（这种方式确实好，比提示错误好多了）
            this.buttonCancalSelect.Enabled = this.dataGridView2.SelectedRows.Count > 0;
            this.buttonSelect.Enabled = this.dataGridView3.SelectedRows.Count > 0;
        }

        private void buttonCancalSelect_Click(object sender, EventArgs e)
        {
            string sno = this.dataGridView1.SelectedRows[0].Cells["SNO"].Value.ToString();

            string cno = this.dataGridView2.SelectedRows[0].Cells["CNO"].Value.ToString();

            studentMS.BLL.s_c bll = new studentMS.BLL.s_c();

            try
            {
                bll.Delete(sno, cno);
                this.dataGridView1_SelectionChanged(this.dataGridView1, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    "退课出错！\n" + ex.Message,
                    "出错啦",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
