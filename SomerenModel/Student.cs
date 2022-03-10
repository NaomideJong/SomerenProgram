using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Student
    { 
        public int StudentId { get; set; }
        public string StudentName  { get; set; } // StudentNumber, e.g. 474791
        public string StudentLanguage { get; set; }
        public DateTime StudentDateOfBirth{ get; set; }
        public int StudentRoomId { get; set; }
    }
}
