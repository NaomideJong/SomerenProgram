using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityId { get; set; } // ActivityId, e.g. 6
        public string ActivityDescription { get; set; } // ActivityDescription, e.g. Football
        public DateTime ActivityStartTime { get; set; } // ActivityStartTime, e.g. 03-12-2022 10:00:00 
        public DateTime ActivityEndTime { get; set; } // ActivityEndTime, e.g. 03-12-2022 12:00:00 
    }
}
