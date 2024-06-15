using ReadingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ReadingApp.Services
{
    public class ChapterService
    {
        public bool SaveNewImageChapter(int StoryID, Chapter chapter, Dictionary<int, string> imagesPath)
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

            public bool SaveNewWordChapter(int StoryID, Chapter chapter)
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

            public bool UpdateImageChapter(Chapter chapter, Dictionary<int, string> updatedImagesPath)
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
                        command.Parameters.AddWithValue("@StoryID", chapter.ChapterID);
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
            public bool UpdateWordChapter(Chapter chapter)
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

                        count = (int)command.ExecuteScalar();
                    }

                    if (count != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }


    }
}
