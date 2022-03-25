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
        public void JoinTable()
        {
            string query = "SELECT Activity.*, Teacher.*" +
                    "FROM Supervisors as ACS " +
                    "JOIN Activities as Activity on ACS.activityId = Activity.activityId " +
                    "JOIN Teachers as Teacher on ACS.teacherId = Teacher.teacherId " +
                    "WHERE Activity.activityId = @activityId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
