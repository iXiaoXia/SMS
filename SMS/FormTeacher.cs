using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMS
{
    public partial class FormTeacher : SMS.Views.FormBase
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("重写代码");
        }
    }
}
