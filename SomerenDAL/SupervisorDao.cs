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
        

        public void JoinTable()
        {
            string query = "SELECT A.*, T.*" +
                    "FROM Supervisors as ACS " +
                    "JOIN Activities as A on ACS.activityId = A.activityId " +
                    "JOIN Teachers as T on ACS.teacherId = T.teacherId " +
                    "WHERE A.activityId = @activityId";
        }
    }
}
