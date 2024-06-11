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
        public String StoryName { get; set; }

        public int ChapterID { get; set; }

        public string Message { get; set; }

        public bool IsRead { get; set; } = false;

        public DateTime CreatedAt {  get; set; }
        
    }
}
