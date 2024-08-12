using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SE256_Lab1_CSouthey.App_Code;

namespace SE256_Lab1_CSouthey.Backend
{
    public partial class GuitarStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //Log in
            }
            else
            {
                Response.Redirect("~/Backend");
            }



        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Guitar temp = new Guitar();

            temp.Brand = txtBrand.Text;
            temp.Model = txtModel.Text;
            temp.Color = txtColor.Text;

            Double dblPrice = 0;
            if (Double.TryParse(txtPrice.Text, out dblPrice))
            {
                temp.Price = dblPrice;
            }

            Int32 intStrings = 0;
            if (Int32.TryParse(txtStrings.Text, out intStrings))
            {
                temp.Price = dblPrice;
            }

            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.Color + " " + temp.Brand + " " + temp.Model + " " + temp.Strings + " " + temp.Price;
            }
        }
    }
}