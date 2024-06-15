using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class ReadingList
    {
        public int ListID {  get; set; }
        public int UserID { get; set; }
        public String ListName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
