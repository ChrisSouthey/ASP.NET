using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week4_Class1;

namespace SE256_Lab1_CSouthey.App_Code
{
    public class Guitar
    {

        private string brand;
        private string model;
        private string color;
        private int strings;
        private double price;
       

        protected string feedback;


        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }

        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }

        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }

        }


        public int Strings
        {
            get
            {
                return strings;
            }
            set
            {
                if(ValidationLibrary.CorrectNumStrings(value) == false)
                {
                    feedback += "ERROR: Incorrect number of strings entered";
                }
                else
                {
                    strings = value;
                }
            }

        }

        public double Price
                {
                    get
                    {
                        return price;
                    }
                    set
                    {
                        price = value;
                    }

                }

        public string Feedback
        {
            get
            {
                return feedback;
            }
        }


        public Guitar()
        {
            brand = "";
            model = "";
            color = "";
            price = 0.0;
            strings = 0;

            feedback = "";
        }
    }
}