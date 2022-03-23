using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            // select the query from the Students database
            string query = "SELECT activityId, activityDescription, activityStartTime, activityEndTime FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Activity GetById(int activityId)
        {
            string query = $"SELECT activityId, activityDescription, activityStartTime, activityEndTime FROM [Activity]" +
                $"WHERE activityId=@activityId";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@activityId", activityId)
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public void UpdateActivity(Activity activity)
        {
            string query = "UPDATE Activity SET activityDescription=@activityDescription, " +
                "activityStartTime=@activityStartTime, activityEndTime=@activityEndTime " +
                "WHERE activityId = @activityId";
            SqlParameter[] sqlParameters = new SqlParameter[4]
           {
                new SqlParameter("@activityId", activity.ActivityId),
                new SqlParameter("@activityDescription", activity.ActivityDescription),
                new SqlParameter("@activityStartTime", activity.ActivityStartTime),
                new SqlParameter("@activityEndTime", activity.ActivityEndTime)
           };
            //change activity decription, start time and end time
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["activityId"],
                    ActivityDescription = (string)dr["activityDescription"],
                    ActivityStartTime = (DateTime)dr["activityStartTime"],
                    ActivityEndTime = (DateTime)dr["activityEndTime"]
                };
                // add the student to the list
                activities.Add(activity);
            }
            return activities;
        }
    }
}
