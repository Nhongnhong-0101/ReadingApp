using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class Rating
    {
        int RatingID { get; set; }
        User User { get; set; }
        Story Story { get; set; }

        [Range(1,5)]
        int Star {  get; set; }

        String Comment { get; set; }

        DateTime CreatedAt { get; set; }


    }
}
