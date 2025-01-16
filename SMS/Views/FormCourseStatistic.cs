using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormCourseStatistic : SMS.Views.FormBase
    {
        public FormCourseStatistic()
        {
            InitializeComponent();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.dataGridView1.DataSource = bll.GetCourseStatisticList(textBox1.Text.Trim())
                .Tables[0]
                .DefaultView;
        }
    }
}
