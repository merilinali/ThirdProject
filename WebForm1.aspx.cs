using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace $safeprojectname$
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.ForeColor= System.Drawing.Color.Purple;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.ForeColor = System.Drawing.Color.Blue;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label1.ForeColor = System.Drawing.Color.Pink;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label1.ForeColor = System.Drawing.Color.Green;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label1.ForeColor = System.Drawing.Color.Red;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Label1.ForeColor = System.Drawing.Color.Yellow;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Label1.ForeColor = System.Drawing.Color.Black;
        }
    }
}