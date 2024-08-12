using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SE256_Activity1_CSouthey.Backend
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "CSouthey" && txtPassword.Text == "NEIT")
            {
                //Login Works
                Session["Username"] = txtUsername.Text;
                Session["LoggedIn"] = "TRUE";
                lblFeedback.Text = "Login Successful...";
                Response.Redirect("~/Backend/ControlPanel.aspx");
            }
            else
            {
                //Login No Works
                Session["Username"] = "";
                Session["LoggedIn"] = "FALSE";
                lblFeedback.Text = "Login Failed...";
            }
        }
    }
}