using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ButtonQuery_Click(this.ButtonQuery, e);
        }

        protected void ButtonQuery_Click(object sender, EventArgs e)
        {
            string sno = this.TextBoxSNO.Text.Trim();
            string sname = this.TextBoxSName.Text.Trim();

            studentMS.BLL.core bll = new studentMS.BLL.core();
            this.GridView1.DataSource = bll.GetStudentList(sno, sname).Tables[0];
            this.GridView1.DataBind();
        }
    }
}
