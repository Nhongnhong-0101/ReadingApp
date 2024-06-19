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
    public class CommentServices
    {
        static public bool addCmt(int userID, int storyID, int star, string cmt)
        {
            bool result = false;
            double sum = 0;
            int count = 0; 
            string sqlQuery = "INSERT INTO RATINGS VALUES (@userID, @storyID, @star, @cmt, @createdat)";
            try
            { 
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userID", userID);
                        command.Parameters.AddWithValue("@storyID", storyID);
                        command.Parameters.AddWithValue("@star", star);
                        command.Parameters.AddWithValue("@cmt", cmt);
                        command.Parameters.AddWithValue("@createdat", DateTime.Now);
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            
                sqlQuery = "SELECT SUM(RATING) AS SUM, COUNT(RATING) AS COUNT FROM RATINGS WHERE STORYID = @storyID";
            
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@storyID", storyID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sum = double.Parse(reader["sum"].ToString());
                                count = int.Parse(reader["count"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }

                sum /= (double)count;

                sqlQuery = "UPDATE STORIES SET STARS = @stars WHERE STORYID = @storyid ";
            
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@stars", sum);
                        command.Parameters.AddWithValue("@storyid", storyID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }

            return result;
        }

        static public List<Rating> getCmt(int userID, int storyID)
        {
            List<Rating> ratings = new List<Rating>();
            string sqlQuery = "SELECT * FROM RATINGS WHERE STORYID = @storyID ORDER BY CREATEDAT DESC";
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
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Rating rating = new Rating();
                                    rating.RatingID = int.Parse(reader["ratingid"].ToString());
                                    rating.UserID = int.Parse(reader["userid"].ToString());
                                    rating.StoryID = int.Parse(reader["storyid"].ToString());
                                    rating.Star = int.Parse(reader["rating"].ToString());
                                    rating.Comment = reader["comment"].ToString();
                                    rating.CreatedAt = DateTime.Parse(reader["createdat"].ToString());

                                    ratings.Add(rating);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return ratings;
        }
    }
}
