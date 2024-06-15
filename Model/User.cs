using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? IsMale { get; set; }
        public DateTime? Dob { get; set; }
        public string Avatar { get; set; }

        public User() 
        {
            Avatar = "C:\\Users\\DELL\\Desktop\\C#\\Avatars\\avatDefault.png";
            //Avatar = @"D:\\Downloads\\UITHoc\\C#\\Hinh\\AnThan.jpg";
        }

        public User(int userID, string fullName, string userName, string password, string email, bool? isMale, DateTime? dob, string avatar)
        {
            UserID = userID;
            FullName = fullName;
            UserName = userName;
            Password = password;
            Email = email;
            IsMale = isMale;
            Dob = dob;
            Avatar = avatar;
        }



    }
}
