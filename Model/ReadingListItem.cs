using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class ReadingListItem
    {
        int ItemID { get; set; }    
        int ListID { get; set; }
        Story Story { get; set; }

    }
}
