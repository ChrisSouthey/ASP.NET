using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson1_WebCalc_CS
{
    public partial class _Default : Page
    {
        public int intNum1;



        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void NumButtons_Click(object sender, EventArgs e)
        {
            Button temp = (Button)sender;

            textLCD.Text += temp.Text;


        }

        protected void btnEquals_Click(object sender, EventArgs e)
        {
            //Equals

            Double Num2 = Double.Parse(textLCD.Text);
            Double Num1 = Double.Parse(Session["Num1"].ToString());
            String Operand = Session["Operand"].ToString();
            Double Result = 0;

            //Decide what operand to use:
            if (Operand == "+")
            {
                Result = Num1 + Num2;
            }
            else if (Operand == "-")
            {
                Result = Num1 - Num2;
            }
            else if (Operand == "*")
            {
                Result = Num1 * Num2;
            }
            else if (Operand == "/")
            {
                Result = Num1 / Num2;
            }

            textLCD.Text = Result.ToString();


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Add

            //intNum1 = Int32.Parse(textLCD.Text);

            Session["Num1"] = textLCD.Text;
            Session["Operand"] = "+";

            textLCD.Text = "";

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            //Subtract


            Session["Num1"] = textLCD.Text;
            Session["Operand"] = "-";

            textLCD.Text = "";

        }

        protected void btnMult_Click(object sender, EventArgs e)
        {
            //Multiply


            Session["Num1"] = textLCD.Text;
            Session["Operand"] = "*";

            textLCD.Text = "";

        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            //Divide


            Session["Num1"] = textLCD.Text;
            Session["Operand"] = "/";

            textLCD.Text = "";

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //Clear

            Session["Num1"] = "";
            Session["Num2"] = "";
            Session["Operand"] = "";
            Session["Result"] = "";

            textLCD.Text = "";

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            //Store

            Session["Memory"] = Double.Parse(textLCD.Text);
             

            textLCD.Text = "";

        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            //Restore

            Session["Num1"] = Session["Memory"];

            textLCD.Text = Convert.ToString(Session["Memory"]);

        }
    }
}