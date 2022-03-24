using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class SupervisorDao : BaseDao
    {
        public List<Supervisor> GetAllSupervisors()
        {
            string query = "SELECT supervisorId, teacherId, activityId FROM [Supervisors]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                //Supervisor sv = new Supervisor()
               // {
                //    SupervisorId = (int)sv["supervisorId"],
               //    TeacherSupervisingId = (int)sv["teacherId"],


                //};
                // add the order to the list
               // supervisors.Add(sv);
            }
            return supervisors;
        }
    }
}
