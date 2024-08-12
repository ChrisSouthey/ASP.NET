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
        private double price;
        private int strings;

        protected string feedback;


        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                value = brand;
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
                value = model;
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
                value = color;
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
                value = price;
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
                    strings = value;
               }
                else
                {
                    feedback += "ERROR: Incorrect number of strings entered";
                }
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