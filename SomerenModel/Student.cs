using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Student
    { 
        public int StudentId { get; set; } // StudentId, e.g. 6
        public string StudentName  { get; set; } // StudentName, e.g. Jan
        public string StudentLanguage { get; set; } // StudentLanguage, e.g. English/Dutch
        public DateTime StudentDateOfBirth{ get; set; } // DateOfBirth, e.g. 03-12-2000
        public int StudentRoomId { get; set; } // StudentRoomId, e.g. 201-225
    }
}
