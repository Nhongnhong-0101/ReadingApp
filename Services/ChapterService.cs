using Microsoft.VisualBasic.ApplicationServices;
using ReadingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.Xml;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ReadingApp.Services
{
    public class ChapterService
    {
        static public bool SaveNewImageChapter(int StoryID, Chapter chapter, Dictionary<int, string> imagesPath)
        {
            int chapterID;
            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Chapters (StoryID, ChapterNumber, Title, CreatedAt)
                VALUES (@StoryID, @ChapterNumber, @Title, @CreatedAt);
                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StoryID", StoryID);
                        command.Parameters.AddWithValue("@ChapterNumber", chapter.ChapterNumber);
                        command.Parameters.AddWithValue("@Title", chapter.Title);
                        command.Parameters.AddWithValue("@CreatedAt", chapter.CreatedAt);


                        chapterID = Convert.ToInt32(command.ExecuteScalar());
                    }

                    if (chapterID > 0)
                    {

                        //lưu hinh
                        string insertImageQuery = @"
                        INSERT INTO ChapterImages (ChapterID, ImageURL, ImageOrder)
                        VALUES (@ChapterID, @ImageURL, @ImageOrder);";

                        foreach (var row in imagesPath)
                        {
                            string imagePath = row.Value.ToString();
                            int orderOfImage = row.Key;

                            SqlCommand insertImageCommand = new SqlCommand(insertImageQuery, connection);
                            insertImageCommand.Parameters.AddWithValue("@ChapterID", chapterID);
                            insertImageCommand.Parameters.AddWithValue("@ImageURL", imagePath);
                            insertImageCommand.Parameters.AddWithValue("@ImageOrder", orderOfImage);

                            if (insertImageCommand.ExecuteNonQuery() <= 0)
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    return false;
                }

            }
        }

        static public bool SaveNewWordChapter(int StoryID, Chapter chapter)
        {
            int chapterID;
            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO Chapters (StoryID, ChapterNumber, Title, Content, CreatedAt)
            VALUES (@StoryID, @ChapterNumber, @Title, @Content, @CreatedAt);
            SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StoryID", StoryID);
                    command.Parameters.AddWithValue("@ChapterNumber", chapter.ChapterNumber);
                    command.Parameters.AddWithValue("@Title", chapter.Title);
                    command.Parameters.AddWithValue("@Content", chapter.Content);
                    command.Parameters.AddWithValue("@CreatedAt", chapter.CreatedAt);


                    chapterID = Convert.ToInt32(command.ExecuteScalar());

                }

                if (chapterID != 0)
                {
                    return true;
                }
                return false;
            }
        }

        static public bool UpdateImageChapter(Chapter chapter, Dictionary<int, string> updatedImagesPath)
        {
            int chapterID;
            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                connection.Open();

                string query = @"
                        UPDATE Chapters
                        SET ChapterNumber = @ChapterNumber,
                        Title = @Title,
                        CreatedAt = @CreatedAt
                        WHERE ChapterID = @ChapterID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChapterID", chapter.ChapterID);
                    command.Parameters.AddWithValue("@ChapterNumber", chapter.ChapterNumber);
                    command.Parameters.AddWithValue("@Title", chapter.Title);
                    command.Parameters.AddWithValue("@CreatedAt", chapter.CreatedAt);


                    chapterID = (int)command.ExecuteScalar();
                }

                if (chapterID > 0)
                {
                    //xóa hết các hình cũ
                    string deleteImagesQuery = "DELETE FROM ChapterImages WHERE ChapterID = @ChapterID";

                    using (SqlCommand deleteImagesCommand = new SqlCommand(deleteImagesQuery, connection))
                    {
                        deleteImagesCommand.Parameters.AddWithValue("@ChapterID", chapterID);
                        deleteImagesCommand.ExecuteNonQuery();
                    }

                    //lưu hinh mới
                    string insertImageQuery = @"
                    INSERT INTO ChapterImages (ChapterID, ImageURL, ImageOrder)
                    VALUES (@ChapterID, @ImageURL, @ImageOrder);";

                    foreach (var row in updatedImagesPath)
                    {
                        string imagePath = row.Value.ToString();
                        int orderOfImage = row.Key;

                        using (SqlCommand insertImageCommand = new SqlCommand(insertImageQuery, connection))
                        {
                            insertImageCommand.Parameters.AddWithValue("@ChapterID", chapterID);
                            insertImageCommand.Parameters.AddWithValue("@ImageURL", imagePath);
                            insertImageCommand.Parameters.AddWithValue("@ImageOrder", orderOfImage);

                            if (insertImageCommand.ExecuteNonQuery() <= 0)
                            {
                                return false;
                            }
                        }
                    }
                    return true;
                }
                return false;
            }

        }
        static public bool UpdateWordChapter(Chapter chapter)
        {
            int count;
            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                connection.Open();

                string query = @"
                                UPDATE Chapters
                                SET ChapterNumber = @ChapterNumber,
                                    Title = @Title,
                                    Content = @Content,
                                    CreatedAt = @CreatedAt
                                WHERE ChapterID = @ChapterID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChapterID", chapter.ChapterID);
                    command.Parameters.AddWithValue("@ChapterNumber", chapter.ChapterNumber);
                    command.Parameters.AddWithValue("@Title", chapter.Title);
                    command.Parameters.AddWithValue("@Content", chapter.Content);
                    command.Parameters.AddWithValue("@CreatedAt", chapter.CreatedAt);

                    count = (int)command.ExecuteNonQuery();
                }

            if (count != 0)
            {
                return true;
            }
            return false;
        }
    }

        static  public List<Chapter> getChapters(int storyID) 
        {
            List<Chapter> chapters = new List<Chapter>();
            string sqlQuery = "SELECT * FROM CHAPTERS WHERE STORYID = @storyID";

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
                                    Chapter chapter = new Chapter();
                                    chapter.Title = reader["title"].ToString();
                                    chapter.ChapterID = int.Parse(reader["ChapterID"].ToString());
                                    chapter.Story = StoriesServices.getStory(int.Parse(reader["StoryID"].ToString()));
                                    chapter.Content = reader["content"].ToString();
                                    chapter.ChapterNumber = int.Parse(reader["ChapterNumber"].ToString());
                                    chapter.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    chapters.Add(chapter);
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch { }
            return chapters;
        }

        static public List<Chapter> getImageChapters(int storyID)
        {
            List<Chapter> chapters = new List<Chapter>();
            string sqlQuery = "SELECT * FROM CHAPTERS WHERE STORYID = @storyID";

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
                                    Chapter chapter = new Chapter();
                                    chapter.Title = reader["title"].ToString();
                                    chapter.ChapterID = int.Parse(reader["ChapterID"].ToString());
                                    chapter.Story = StoriesServices.getStory(int.Parse(reader["StoryID"].ToString()));
                                    chapter.Images = new List<ChapterImages>();
                                    chapter.ChapterNumber = int.Parse(reader["ChapterNumber"].ToString());
                                    chapter.CreatedAt = DateTime.Parse(reader["createdat"].ToString());
                                    chapters.Add(chapter);
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                foreach (Chapter chapter in chapters)
                {
                    sqlQuery = "SELECT * FROM CHAPTERIMAGES WHERE CHAPTERID = @chapterID";

                    using (SqlConnection connection = new SqlConnection(DataProvider.con))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                        {
                            command.Parameters.AddWithValue("@chapterID", chapter.ChapterID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        ChapterImages chapterimage = new ChapterImages();
                                        chapterimage.ImageURL = reader["ImageURL"].ToString();
                                        chapterimage.ImageID = int.Parse(reader["ImageID"].ToString());
                                        chapterimage.ImageOrder = int.Parse(reader["ImageOrder"].ToString());
                                        chapterimage.ChapterID = chapter.ChapterID;
                                        chapter.Images.Add(chapterimage);
                                    }
                                }
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch { }
            return chapters;
        }

        static public bool DeleteWordChapter(int ChapterID)
        {
            int rowsAffected = -1;
            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                connection.Open();

                string query = @"DELETE FROM Chapters WHERE ChapterID = @ChapterID;";



                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChapterID", ChapterID);
                     rowsAffected = command.ExecuteNonQuery();

                }
            }

            if(rowsAffected > 0)
            {
                return true;
            }
            return false;

        }
    }
}
