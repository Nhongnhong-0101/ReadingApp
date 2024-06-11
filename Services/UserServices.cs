using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ReadingApp.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ReadingApp.Services
{
    public  class UserServices
    {
        static public bool loginSuccess(string username, string password)
        {
            bool result = false;
            string sqlQuery = "SELECT USERID FROM USERS WHERE USERNAME = @UserName AND PASSWORD = @Password";

            using (SqlConnection connection = new SqlConnection(DataProvider.con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) { result = true; }
                    }
                }
                connection.Close();
            }
            return result;
        }

        static public bool signUpSuccess(string username, string fullname, string email, DateTime dob, bool isMale, string password) 
        {
            bool result = false;
            string sqlQuery = "INSERT INTO USERS VALUES (@fullname, @username, @password, @email, @ismale, @dob, @avatar)";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@fullname", fullname);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@ismale", isMale);
                        command.Parameters.AddWithValue("@dob", dob);
                        command.Parameters.AddWithValue("@avatar", "C:\\Users\\DELL\\Desktop\\C#\\Avatars\\avatDefault.png");
                        command.ExecuteNonQuery();

                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }
            return result;
        }

        static public bool emailExist(string email) 
        {
            bool result = false;
            string sqlQuery = "SELECT * FROM USERS WHERE EMAIL = @email";
            using (SqlConnection connection = new SqlConnection(DataProvider.con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) { result = true; }
                    }
                }
                connection.Close();
            }
            return result;
        }

        static public string getPassword(string email)
        {
            string result = "";
            string sqlQuery = "SELECT PASSWORD FROM USERS WHERE EMAIL = @email";
            using (SqlConnection connection = new SqlConnection(DataProvider.con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows) 
                        {
                            while (reader.Read())
                            {
                                result = reader["password"].ToString();
                            }
                        }
                    }
                }
                connection.Close();
            }
            return result;
        }

        static public User getUser(string email)
        {
            User result = new User();
            string sqlQuery = "SELECT * FROM USERS WHERE EMAIL = @email";
            using (SqlConnection connection = new SqlConnection(DataProvider.con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                result.UserID = int.Parse(reader["userid"].ToString());
                                result.UserName = reader["username"].ToString();
                                result.FullName = reader["fullname"].ToString();
                                result.Password = reader["password"].ToString();
                                result.Email = reader["email"].ToString();
                                result.IsMale = bool.Parse(reader["ismale"].ToString());
                                result.Dob = DateTime.Parse(reader["dob"].ToString());
                                result.Avatar = reader["avatar"].ToString();
                            }
                        }
                    }
                }
                connection.Close();
            }
            return result;
        }

        static public User getUser(string username,  string password)
        {
            User result = new User(); 
            string sqlQuery = "SELECT * FROM USERS WHERE USERNAME = @username AND PASSWORD = @password";
            using (SqlConnection connection = new SqlConnection(DataProvider.con))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                result.UserID = int.Parse(reader["userid"].ToString());
                                result.UserName = reader["username"].ToString();
                                result.FullName = reader["fullname"].ToString();
                                result.Password = reader["password"].ToString();
                                result.Email = reader["email"].ToString();
                                result.IsMale = bool.Parse(reader["ismale"].ToString());
                                result.Dob = DateTime.Parse(reader["dob"].ToString());
                                result.Avatar = reader["avatar"].ToString();
                            }
                        }
                    }
                }
                connection.Close();
            }
            return result;
        }

        static public bool updateUser(int userID, User user)
        {
            bool result = false;
            string sqlQuery = "UPDATE USERS SET USERNAME = @username, " +
                                "FULLNAME = @fullname, " +
                                "EMAIL = @email, " +
                                "DOB = @dob, " +
                                "ISMALE = @ismale, " +
                                "AVATAR = @avatar " +
                                "WHERE USERID = @userid ";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", user.UserName);
                        command.Parameters.AddWithValue("@fullname", user.FullName);
                        command.Parameters.AddWithValue("@email", user.Email);
                        command.Parameters.AddWithValue("@dob", user.Dob);
                        command.Parameters.AddWithValue("@ismale", user.IsMale);
                        command.Parameters.AddWithValue("@avatar", user.Avatar);
                        command.Parameters.AddWithValue("@userid", userID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }

            return result;
        }

        static public bool correctPassword(int userID, string password)
        {
            bool result = false;
            string sqlQuery = "SELECT PASSWORD FROM USERS WHERE USERID = @userid";
            
            try{
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@userid", userID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                string pass = "";
                                while (reader.Read())
                                {
                                    pass = reader["password"].ToString();
                                }
                                if (pass == password) { result = true; }
                            }
                        }
                    }
                    connection.Close();
                }
            }  
            catch { }
            return result;
        }

        static public bool updatePasword(int userID, string password)
        {
            bool result = false;
            string sqlQuery = "UPDATE USERS SET PASSWORD = @password WHERE USERID = @userid ";
            try
            {
                using (SqlConnection connection = new SqlConnection(DataProvider.con))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@userid", userID);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                result = true;
            }
            catch { }

            return result;
        }
    }    
}
