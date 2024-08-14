using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SE256_Activity1_CSouthey.App_Code;


namespace SE256_Activity1_CSouthey.App_Code
{
    public class Ebook : Book
    {

        private DateTime dateRentalExpires;
        private int bookmarkPage;

        private int eBook_Id;


        public DateTime DateRentalExpires
        {
            get
            {
                return dateRentalExpires;
            }
            set
            {
                if (ValidationLibrary.IsAFutureDate(value))
                {
                    dateRentalExpires = value;
                }
                else
                {
                    feedback += "\nERROR: Must enter a future date.";
                }
            }
        }

        public int BookmarkPage
        {
            get
            {
                return bookmarkPage;
            }
            set
            {
                if(value >= 0 && value <= Pages)
                {
                    bookmarkPage = value;
                }
                else
                {
                    feedback += "\nERROR: Not a valid page number";
                }
            }
        }



        private string GetConnected()
        {
            return @"Server=sql.neit.edu\studentsqlserver,4500;Database=Dev_202430_CSouthey;User Id=Dev_202430_CSouthey;Password=008022228";
        }

        public Ebook() : base()
        {
            BookmarkPage = 0;
            DateRentalExpires = DateTime.Now.AddDays(14);
        }




        public string AddARecord()
        {
            string strResult = "";

            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = GetConnected();

            string strSQL = "INSERT INTO EBooks (Title, AuthorFirst, AuthorLast, Email, Pages, DatePublished, DateRentalExpires, Price, BookmarkPage) VALUES (@Title, @AuthorFirst, @AuthorLast, @Email, @Pages, @DatePublished, @DateRentalExpires, @Price, @BookmarkPage)";

            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;
            comm.Connection = Conn;

            comm.Parameters.AddWithValue("@Title", Title);
            comm.Parameters.AddWithValue("@AuthorFirst", AuthorFirst);
            comm.Parameters.AddWithValue("@AuthorLast", AuthorLast);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Pages", Pages);
            comm.Parameters.AddWithValue("@DatePublished", DatePublished);
            comm.Parameters.AddWithValue("@DateRentalExpires", DateRentalExpires);
            comm.Parameters.AddWithValue("@Price", Price);
            comm.Parameters.AddWithValue("@BookmarkPage", BookmarkPage);


            try
            {
                Conn.Open();

                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";

                Conn.Close();
            }
            catch(Exception err)
            {
                strResult = "ERROR: " + err.Message;
            }

            return strResult;




        }

    }
}