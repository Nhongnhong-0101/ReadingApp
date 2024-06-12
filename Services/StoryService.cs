using ReadingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Services
{
    public class StoryService
    {
        public bool SaveNewStory(Story story)
        {
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
                VALUES (@Image, @Title, @Description, @Type, @Category, @ChapterNumber, @FreeChapters, @Price, @Status, @Stars, @Views, @Author, @CreatedAt, @LastUpdateAt)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Image", story.Image ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Title", story.Title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Description", story.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Type", story.Type ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Category", story.Category );
                    command.Parameters.AddWithValue("@ChapterNumber", story.NumberChapters);
                    command.Parameters.AddWithValue("@FreeChapters", story.FreeChapters);
                    command.Parameters.AddWithValue("@Price", story.Price);
                    command.Parameters.AddWithValue("@Status", story.Status ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Stars", story.Star);
                    command.Parameters.AddWithValue("@Views", story.Views);
                    command.Parameters.AddWithValue("@Author", story.Author ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedAt", story.CreatedAt);
                    command.Parameters.AddWithValue("@LastUpdateAt", story.LastUpdatedAt);

                    foreach (SqlParameter parameter in command.Parameters)
                    {
                        Console.WriteLine($"Parameter Name: {parameter.ParameterName}, Value: {parameter.Value}");
                    }
                
                command.ExecuteNonQuery();
                }
            }

            return true;

        }
    }
}
