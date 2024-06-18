using ReadingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingApp.Services
{
    public class NotificationService
    {
        public static bool CreateNotification(String s)
        {
            try
            {
                int idNofi = -1;

                using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Notifications (Message, CreatedAt) VALUES (@Message, GETDATE()); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Message", s);

                        idNofi = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
                return idNofi > 0;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public static List<Notification> GetAllNotifications()
        {
            List<Notification> notifications = new List<Notification>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.conectionString))
                {
                    connection.Open();

                    string query = "SELECT ID, Message, CreatedAt FROM Notifications";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Notification notification = new Notification
                                {
                                    NotiID = reader.GetInt32(0),
                                    Message = reader.GetString(1),
                                    CreatedAt = reader.GetDateTime(2)
                                };

                                notifications.Add(notification);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return notifications;
        }
    }


}
