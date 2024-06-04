using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class Story
    {
        public int StoryID { get; set; }

        public string Image { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        public string Description { get; set; }

        [MaxLength(100)]
        public string Type { get; set; }

        [MaxLength(50)]
        public string Category { get; set; }

        public int NumberChapters { get; set; } = 0;

        public bool IsPaid { get; set; } = false;

        public int FreeChapters { get; set; } = 0;

        public int Price { get; set; } = 0;

        [MaxLength(100)]
        public string Status { get; set; }

        public double Star { get; set; } = 0;

        public User Author { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set;}

    }
}
