using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class SupervisorService
    {
        SupervisorDao supervisordb;
        public SupervisorService()
        {
            supervisordb = new SupervisorDao();
        }
        public List<Supervisor> JoinTable(int activityId)
        {
            List<Supervisor> supervisors = supervisordb.JoinTable(activityId);
            return supervisors;
        }

        public void AddSupervisor(Activity activity, Teacher teacher)
        {
            supervisordb.AddSupervisor(activity, teacher);
        }
        public void DeleteSupervisor(Activity activity, Teacher teacher)
        {
            supervisordb.DeleteSupervisor(activity, teacher);
        }

    }
}
