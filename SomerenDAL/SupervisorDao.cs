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
        public List<Supervisor> JoinTable(int activityId)
        {
            string query = "SELECT Teac.teacherName" +
                " FROM Supervisors as ACS" +
                " JOIN Activity as Act on ACS.activityId = Act.activityId" +
                " JOIN Teachers as Teac on ACS.teacherId = Teac.teacherId" +
                " WHERE Act.activityId = @activityId";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@activityId", activityId)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Supervisor> ReadTables(DataTable dataTable)
        {
            List<Supervisor> supervisors = new List<Supervisor>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisor supervisor = new Supervisor()
                {
                    TeacherName = (string)dr["teacherName"]
                };
                // add the supervisor to the list
                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        public void AddSupervisor(Activity a, Teacher t)
        {
            string query = "INSERT INTO Supervisor (activityId, teacherId) " +
                "VALUES (@activityId, @teacherId);" +
                "SELECT SCOPE_IDENTITY();";
            SqlParameter[] sqlParameters = new SqlParameter[2]
           {
                new SqlParameter("@activityId", a.ActivityId),
                new SqlParameter("@teacherId", t.TeacherId)
           };
            //add teacher as a supervisor
            ExecuteSelectQuery(query, sqlParameters);
        }
        public void DeleteSupervisor(Activity a, Teacher t)
        {
            string query = "DELETE FROM Supervisors WHERE teacherId = @teacherId AND activityId = @activityId";
            SqlParameter[] sqlParameters = new SqlParameter[2]
           {
                new SqlParameter("@teacherId", t.TeacherId),
                new SqlParameter("@activityId", a.ActivityId)
           };
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
