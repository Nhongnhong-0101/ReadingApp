using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class Chapter
    {
        public int ChapterID { get; set; }
        public int ChapterNumber { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        public string Content { get; set; }

        public List<ChapterImages> Images { get; set; }//nếu là truyện tranh thì get hết image ra

        public DateTime CreatedAt { get; set; }

        public Story Story { get; set; }
    }
}
