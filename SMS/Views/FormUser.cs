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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UID = this.textBoxUID.Text.Trim().ToString();
            this.dataGridView1.DataSource = new studentMS.BLL.core()
                .GetUserList(UID)
                .Tables[0]
                .DefaultView;
        }
    }
}
