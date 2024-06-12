using ReadingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Services
{
    public class StoryService
    {
        public bool SaveNewStory(Story story)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
            {
                connection.Open();

                string query = @"
                INSERT INTO Stories (Image, Title, Description, Type, Category, NumberChapters, FreeChapters, Price, Status, Star, Views, Author, CreatedAt, LastUpdatedAt)
                VALUES (@Image, @Title, @Description, @Type, @Category, @NumberChapters, @FreeChapters, @Price, @Status, @Star, @Views, @Author, @CreatedAt, @LastUpdatedAt)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Image", story.Image ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Title", story.Title ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Description", story.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Type", story.Type ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Category", story.Category ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@NumberChapters", story.NumberChapters);
                    command.Parameters.AddWithValue("@FreeChapters", story.FreeChapters);
                    command.Parameters.AddWithValue("@Price", story.Price);
                    command.Parameters.AddWithValue("@Status", story.Status ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Star", story.Star);
                    command.Parameters.AddWithValue("@Views", story.Views);
                    command.Parameters.AddWithValue("@Author", story.Author ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CreatedAt", story.CreatedAt);
                    command.Parameters.AddWithValue("@LastUpdatedAt", story.LastUpdatedAt);

                    command.ExecuteNonQuery();
                }
            }

            return true;

        }
    }
}
