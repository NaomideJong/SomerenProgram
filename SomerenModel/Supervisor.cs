using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {
        public int SupervisorId { get; set; } // Unique id for supervisor and event       
        public int TeacherSupervisingId { get; set; } // Teacher supervising ID, e.g. 5, 7
        public int ActivitySupervisedId { get; set; } // Activity supervised ID, e.g. 1, 6

        public Supervisor(int supervisorId, int teacherSupervisingId, int activitySupervisedId)
        {
            SupervisorId = supervisorId;
            TeacherSupervisingId = teacherSupervisingId;
            ActivitySupervisedId = activitySupervisedId;
        }
    }
}
