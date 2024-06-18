using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class Notification
    {
        public int NotiID { get; set; }

        public string Message { get; set; }

        public int StoryID { get; set; }    

        public DateTime CreatedAt {  get; set; }
        
    }
}
