using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ReadingApp.Services
{
    public class StoriesServices
    {
        static public List<Story> get24Stories()
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT TOP 24 * FROM STORIES";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());
                                    
                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }            
            return stories;
        }

        static public List<Story> getAllStories()
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT * FROM STORIES";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());

                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return stories;
        }

        static public List<Story> getAllStoriesOutRL(int listID)
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT * FROM STORIES WHERE StoryID NOT IN ( SELECT STORYID FROM ReadingListItems WHERE ListID = @listID) ";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@listID", listID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());

                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return stories;
        }

        static public List<Story> getLastedStories()
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT TOP 4 * FROM STORIES ORDER BY LastUpdateAt DESC";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());
                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return stories;
        }

        static public List<Story> getOutsStories()
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT TOP 4 * FROM STORIES ORDER BY Views DESC";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());
                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return stories;
        }

        static public List<Story> getStarStories()
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT TOP 4 * FROM STORIES ORDER BY Stars DESC";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());
                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return stories;
        }

        static public List<Story> getSearchStories(string type, string arrange, bool isStory, bool isComic, bool isFull, bool isUpdating, bool isFree, bool isFee)
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT * FROM STORIES WHERE TYPE = @type";

            if (isStory && !isComic) { sqlQuery += " AND CATEGORY = 'truyện chữ'"; }
            if (!isStory && isComic) { sqlQuery += " AND CATEGORY = 'truyện tranh'"; }
            if (isFull && !isUpdating) { sqlQuery += " AND STATUS = 'Full'"; }
            if (!isFull && isUpdating) { sqlQuery += " AND STATUS = 'Đang cập nhật'"; }
            if (isFree && !isFee) { sqlQuery += " AND PRICE = 0"; }
            if (!isFree && isFee) { sqlQuery += " AND PRICE > 0"; }
            switch (arrange)
            {
                case "Đánh giá cao": { sqlQuery += " ORDER BY STARS DESC"; break; }
                case "Mới nhất": { sqlQuery += " ORDER BY LASTUPDATEAT DESC"; break; }
                case "Nổi bật": { sqlQuery += " ORDER BY VIEWS DESC"; break; }
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@type", type);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());
                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return stories;
        }

        static public List<Story> getStoriesRL(int ListID)
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT * FROM STORIES AS STR JOIN ReadingListItems AS RLT ON STR.StoryID = RLT.StoryID WHERE ListID = @listID";

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
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Story story = new Story();
                                    story.Title = reader["title"].ToString();
                                    story.Image = reader["image"].ToString();
                                    story.Description = reader["description"].ToString();
                                    story.Type = reader["type"].ToString();
                                    story.Category = reader["category"].ToString();
                                    story.Author = reader["author"].ToString();
                                    story.NumberChapters = int.Parse(reader["ChapterNumber"].ToString());
                                    story.StoryID = int.Parse(reader["StoryID"].ToString());
                                    story.Star = float.Parse(reader["stars"].ToString());
                                    story.Status = reader["status"].ToString();
                                    story.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    story.LastUpdatedAt = DateTime.Parse(reader["LastUpdateAt"].ToString());
                                    story.IsPaid = bool.Parse(reader["ispaid"].ToString());
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());
                                    stories.Add(story);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return stories;
        }
    }
}
