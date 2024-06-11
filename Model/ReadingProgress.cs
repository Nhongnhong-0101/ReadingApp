using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Model
{
    public class ReadingProgress
    {
        User User { get; set; }
        Story Story { get; set; }
        Chapter Chapter { get; set; }

        DateTime Progress { get; set; } //thời gian lưu tiến độ này

    }


}
