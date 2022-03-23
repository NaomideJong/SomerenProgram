using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            // return the list of activities
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }

        public Activity GetById(int activityId)
        {
            // get one activity by id number
            return activitydb.GetById(activityId);
        }

        public void UpdateActivity(Activity activity)
        {
            activitydb.UpdateActivity(activity);
        }
    }
}
