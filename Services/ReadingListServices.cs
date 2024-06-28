using Microsoft.VisualBasic.ApplicationServices;
using ReadingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReadingApp.Services
{
    public class ReadingListServices
    {
        static public bool addNewReadlingList(int userID ,string name)
        {
            bool result = false;
            string sqlQuery = "INSERT INTO READINGLISTS VALUES (@userID, @name, @createat, @updateat)";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@createat", DateTime.Now);
                        command.Parameters.AddWithValue("@updateat", DateTime.Now);
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
                result = true;
            }
                catch { }
            return result;
        }

        static public List<ReadingList> getRL(int userID)
        {
            List<ReadingList> readingLists = new List<ReadingList>();
            string sqlQuery = "SELECT * FROM READINGLISTS WHERE USERID = @userID ORDER BY LISTID DESC";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ReadingList readingList = new ReadingList();
                                    readingList.ListID = int.Parse(reader["ListID"].ToString());
                                    readingList.UserID = userID;
                                    readingList.ListName = reader["ListName"].ToString();
                                    readingList.CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString());
                                    readingList.UpdatedAt = DateTime.Parse(reader["UpdatedAt"].ToString());
                                    readingLists.Add(readingList);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return readingLists;
        }

        static public bool renameRL(int listID, string name)
        {
            bool result = false;
            string sqlQuery = "UPDATE READINGLISTS SET LISTNAME = @name WHERE LISTID = @listID";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@listID", listID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }
            return result;
        }

        static public string count(int ListID)
        {
            string result = "0";
            string sqlQuery = "SELECT COUNT(*) count FROM STORIES AS STR JOIN ReadingListItems AS RLT ON STR.StoryID = RLT.StoryID WHERE ListID = @listID";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@listID", ListID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            { 
                                result = reader["count"].ToString(); 
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return result;
        }

        static public bool deleteStoryOutRL(int storyID, int listID)
        {
            bool result = false;
            string sqlQuery = "DELETE FROM READINGLISTITEMS WHERE LISTID = @listID AND STORYID = @storyID";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@listID", listID);
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

        static public bool deleteAll(int listID)
        {
            bool result = false;
            string sqlQuery = "DELETE FROM READINGLISTITEMS WHERE LISTID = @listID";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@listID", listID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }
            return result;
        }

        static public bool deleteRL(int listID)
        {
            bool result = false;
            string sqlQuery = "DELETE FROM READINGLISTS WHERE LISTID = @listID";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@listID", listID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }
            return result;
        }

        static public bool addStoryIntoRL(int storyID, int listID)
        {
            bool result = false;
            string sqlQuery = "INSERT INTO READINGLISTITEMS VALUES (@listID, @storyID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@storyID", storyID);
                        command.Parameters.AddWithValue("@listID", listID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }
            return result;
        }

        static public List<ReadingList> getRLNotContainStory(int storyID)
        {
            List<ReadingList> result = new List<ReadingList>();
            string sqlQuery = "SELECT * FROM READINGLISTS WHERE LISTID NOT IN ( SELECT  LISTID FROM READINGLISTITEMS WHERE STORYID = @storyID)";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@storyID", storyID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ReadingList readingList = new ReadingList();
                                    readingList.ListID = int.Parse(reader["ListID"].ToString());
                                    readingList.UserID = int.Parse(reader["userID"].ToString());
                                    readingList.ListName = reader["ListName"].ToString();
                                    readingList.CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString());
                                    readingList.UpdatedAt = DateTime.Parse(reader["UpdatedAt"].ToString());
                                    result.Add(readingList);
                                }
                            }
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
