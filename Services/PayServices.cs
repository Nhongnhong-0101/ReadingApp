using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Services
{
    public class PayServices
    {
        static public bool isPaid(int userID, int storyID)
        {
            bool result = false;
            string sqlQuery = "SELECT PAIDID FROM PAID WHERE USERID = @userID AND STORYID = @storyID";

            using (SqlConnection connection = new SqlConnection(DataProvider.con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@storyID", storyID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) { result = true; }
                    }
                }
                connection.Close();
            }
            return result;
        }

        static public bool pay(int userID, int storyID)
        {
            bool result = false;
            string sqlQuery = "INSERT INTO PAID VALUES (@storyID, @userID )";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@storyID", storyID); 
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }
            return result;
        }
        static public void newIndexStart(int userID, int storyID, int chapterID, int index)
        {
            string sqlQuery = "INSERT INTO READINGPROGRESS VALUES (@userID, @storyID, @chapterID, @progress, @index)";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@storyID", storyID);
                        command.Parameters.AddWithValue("@chapterID", chapterID);
                        command.Parameters.AddWithValue("@progress", DateTime.Now);
                        command.Parameters.AddWithValue("@index", index);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch { }
        }

        static public void saveIndexStart(int userID, int storyID, int chapterID, int index)
        {
            string sqlQuery = "UPDATE READINGPROGRESS SET PROGRESS = @progress, INDEXSTART = @index, CHAPTERID = @chapterID WHERE USERID = @userID AND STORYID = @storyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@storyID", storyID);
                        command.Parameters.AddWithValue("@chapterID", chapterID);
                        command.Parameters.AddWithValue("@progress", DateTime.Now);
                        command.Parameters.AddWithValue("@index", index);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch { }
        }

        static public bool isProgress(int userID, int storyID)
        {
            bool result = false;
            string sqlQuery = "SELECT * FROM READINGPROGRESS WHERE USERID = @userID AND STORYID = @storyID ";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@storyID", storyID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) { result = true; }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return result;
        }

        static public int getIndex(int userID, int storyID)
        {
            int result = 0;
            string sqlQuery = "SELECT INDEXSTART FROM READINGPROGRESS WHERE USERID = @userID AND STORYID = @storyID ";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@storyID", storyID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) { result = int.Parse(reader["indexstart"].ToString()); }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return result;
        }

        static public int getChapterID(int userID, int storyID)
        {
            int result = 0;
            string sqlQuery = "SELECT CHAPTERID FROM READINGPROGRESS WHERE USERID = @userID AND STORYID = @storyID ";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@storyID", storyID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) { result = int.Parse(reader["chapterID"].ToString()); }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return result;
        }
    }
}
