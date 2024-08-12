using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Week4_Class1;


namespace SE256_Lab1_CSouthey.App_Code
{
    public class GuitarV2 : Guitar
    {

        private string newUsed;
        private DateTime manu;


        private int guitar_ID;


        public string NewUsed
        {
            get 
            { 
                return newUsed; 
            }
            set 
            { 
                newUsed = value; 
            }
        }

        public DateTime Manu
        {
            get 
            { 
                return manu; 
            }
            set
            {
                if (ValidationLibrary.IsAFutureDate(value) == false)
                {
                    manu = value;
                }
                else
                {
                    feedback += "ERROR: Cannot enter a future date";
                }
            }

        }

        public Int32 Guitar_ID
        {
            get
            {
                return guitar_ID;
            }
            set
            {
                if (value >= 0)
                {
                    guitar_ID = value;
                }
                else
                {
                    feedback += "ERROR: Incorrect Guitar ID entered";
                }
                
            }
        }

        public GuitarV2() : base()
        {
            NewUsed = "";
            Manu = DateTime.Now;
        }




        /*FUNCTIONS*/

        private string GetConnected()
        {
            return @"Server=sql.neit.edu\studentsqlserver,4500;Database=Dev_202430_CSouthey;User Id=Dev_202430_CSouthey;Password=008022228";
        }

        public string AddAGuitar()
        {
            string strResult = "";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = GetConnected();


            string strSQL = "INSERT INTO Guitars2 (Brand, Model, Color, Price, Strings, NewUsed, Manu) VALUES (@Brand, @Model, @Color, @Strings, @Price, @NewUsed, @Manu)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = conn;

            comm.Parameters.AddWithValue("@Brand", Brand);
            comm.Parameters.AddWithValue("@Model", Model);
            comm.Parameters.AddWithValue("@Color", Color);
            comm.Parameters.AddWithValue("@Strings", Strings);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@NewUsed", NewUsed);
            comm.Parameters.AddWithValue("@Manu", Manu);



            try
            {
                conn.Open();

                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";

                conn.Close();
            }
            catch (Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }

            return strResult;
        }
    }
}