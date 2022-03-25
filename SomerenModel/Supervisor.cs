using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisor
    {
        Teacher teacher = new Teacher();

        public Supervisor(int teacherId, int activityId)
        {
            teacher.TeacherId = teacherSupervisingId;
            ActivityId = activitySupervisedId;
        }
    }
}
