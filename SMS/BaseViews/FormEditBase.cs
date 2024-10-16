using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.BaseViews
{
    public partial class FormEditBase : Form
    {
        public FormEditBase()
        {
            InitializeComponent();
        }

        protected virtual void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("父类Ok");
        }

        protected virtual void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("父类Cancel");
        }
    }
}
