using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SE256_Activity1_CSouthey.App_Code;



namespace SE256_Activity1_CSouthey.Backend
{
    public partial class EbookMgr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "TRUE")
            {
                //Let them stay
            }
            else
            {
                Response.Redirect("~/Backend");
            }


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            Ebook temp = new Ebook();

            temp.Title = txtTitle.Text;
            temp.AuthorFirst = txtAuthorFirst.Text;
            temp.AuthorLast = txtAuthorLast.Text;
            temp.Email = txtEmail.Text;
            temp.DatePublished = calDatePublished.SelectedDate;
            temp.DateRentalExpires = calDateRentalExpires.SelectedDate;

            Int32 intPages = 0;
            if(Int32.TryParse(txtPages.Text, out intPages))
            {
                temp.Pages = intPages;
            }

            Double dblPrice = 0;
            if(Double.TryParse(txtPrice.Text, out dblPrice))
            {
                temp.Price = dblPrice;
            }

            Int32 intBookmarkPage = 0;
            if (Int32.TryParse(txtBookmarkPage.Text, out intBookmarkPage))
            {
                temp.BookmarkPage = intBookmarkPage;
            }



            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.AddARecord();
            }


            
        }
    }
}