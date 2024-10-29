using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS.Views
{
    public partial class FormScoreQuery : SMS.Views.FormBase
    {
        public FormScoreQuery()
        {
            InitializeComponent();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            dataGridView1.DataSource = bll.GetScoreList(
                    textBox1.Text.Trim(),
                    textBox2.Text.Trim(),
                    textBox3.Text.Trim()
                )
                .Tables[0]
                .DefaultView;
        }
    }
}
