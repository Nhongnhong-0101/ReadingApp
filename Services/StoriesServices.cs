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
            string sqlQuery = "SELECT TOP 4 * FROM STORIES ORDER BY LastUpdateAt ASC";
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

            if (isStory && !isComic) { sqlQuery += " AND CATEGORY = N'truyện chữ'"; }
            if (!isStory && isComic) { sqlQuery += " AND CATEGORY = N'truyện tranh'"; }
            if (isFull && !isUpdating) { sqlQuery += " AND STATUS = 'Full'"; }
            if (!isFull && isUpdating) { sqlQuery += " AND STATUS = N'Đang cập nhật'"; }
            if (isFree && !isFee) { sqlQuery += " AND PRICE = 0"; }
            if (!isFree && isFee) { sqlQuery += " AND PRICE > 0"; }
            switch (arrange)
            {
                case "Đánh giá cao": { sqlQuery += " ORDER BY STARS DESC"; break; }
                case "Mới nhất": { sqlQuery += " ORDER BY LASTUPDATEAT DESC"; break; }
                case "Nổi bật": { sqlQuery += " ORDER BY VIEWS DESC"; break; }
            }

            //try
            //{
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
            //}
            //catch { }
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

        static public List<Story> getHistoryStoriesRL(int userID)
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
                        command.Parameters.AddWithValue("@userID", userID);
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

        static public string getStarsStory(int storyID)
        {
            string result="";
            string sqlQuery = "SELECT STARS FROM STORIES WHERE STORYID = @storyID";

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
                            if (reader.Read())
                            {
                                result = reader["stars"].ToString();
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return result;
        }

        static public Story getStory(int storyID)
        {
            Story story = new Story();
            string sqlQuery = "SELECT * FROM STORIES WHERE StoryID = @storyID";

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
                                    story.FreeChapters = int.Parse(reader["freechapters"].ToString());
                                    story.Price = int.Parse(reader["price"].ToString());
                                    story.Views = int.Parse(reader["views"].ToString());
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return story;
        }
        
        static public void viewStory(int storyID)
        {
            string sqlQuery = "UPDATE STORIES SET VIEWS = VIEWS + 1 WHERE STORYID = @storyID";

            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@storyID", storyID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch { }
        }


        static public List<Story> getHistoryStories(int userID)
        {
            List<Story> stories = new List<Story>();
            string sqlQuery = "SELECT TOP 20 * FROM STORIES STR JOIN ReadingProgress PRO ON STR.STORYID = PRO.STORYID WHERE PRO.USERID = @userID ORDER BY PRO.PROGRESS DESC";
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
        static public int SaveNewStory(Story story)
        {
            int idStory = -1;
            var validCategories = new List<string> { "truyện tranh", "truyện chữ" };
            var validStatuses = new List<string> { "Đang cập nhật", "Full" };

            if (!validCategories.Contains(story.Category))
            {
                throw new ArgumentException("Invalid Category value. Must be 'truyện tranh' or 'truyện chữ'.");
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                connection.Open();

                string query = @"
                INSERT INTO Stories (Image, Title, Description, Type, Category, ChapterNumber, FreeChapters, Price, Status, Stars, Views, Author, CreatedAt, LastUpdateAt)
                VALUES (@Image, @Title, @Description, @Type, @Category, @ChapterNumber, @FreeChapters, @Price, @Status, @Stars, @Views, @Author, @CreatedAt, @LastUpdateAt);
                SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Image", story.Image ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Title", story.Title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Description", story.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Type", story.Type ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Category", story.Category);
                    command.Parameters.AddWithValue("@ChapterNumber", story.NumberChapters);
                    command.Parameters.AddWithValue("@FreeChapters", story.FreeChapters);
                    command.Parameters.AddWithValue("@Price", story.Price);
                    command.Parameters.AddWithValue("@Status", story.Status ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Stars", story.Star);
                    command.Parameters.AddWithValue("@Views", story.Views);
                    command.Parameters.AddWithValue("@Author", story.Author ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedAt", story.CreatedAt);
                    command.Parameters.AddWithValue("@LastUpdateAt", story.LastUpdatedAt);

                    idStory = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return idStory;

        }

        static public int ModifyStory(Story story)
        {
            int idStory = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                connection.Open();

                string query = @"
                        UPDATE Stories
                        SET Image = @Image,
                            Title = @Title,
                            Description = @Description,
                            Type = @Type,
                            ChapterNumber = @ChapterNumber,
                            FreeChapters = @FreeChapters,
                            Price = @Price,
                            Status = @Status,
                            Stars = @Stars,
                            Views = @Views,
                            Author = @Author,
                            LastUpdateAt = @LastUpdateAt
                        WHERE StoryID = @Id;
                        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", story.StoryID );
                    command.Parameters.AddWithValue("@Image", story.Image ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Title", story.Title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Description", story.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Type", story.Type ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ChapterNumber", story.NumberChapters);
                    command.Parameters.AddWithValue("@FreeChapters", story.FreeChapters);
                    command.Parameters.AddWithValue("@Price", story.Price);
                    command.Parameters.AddWithValue("@Status", story.Status ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Stars", story.Star);
                    command.Parameters.AddWithValue("@Views", story.Views);
                    command.Parameters.AddWithValue("@Author", story.Author ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@LastUpdateAt", story.LastUpdatedAt);

                    idStory = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return idStory;
        }
    }
}
