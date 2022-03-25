using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            // select the query from the Teachers database
            string query = "SELECT teacherId, teacherName, teacherCourse FROM [Teachers]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    TeacherId = (int)dr["teacherId"],
                    TeacherName = (string)(dr["teacherName"]),
                    TeacherCourse = (string)(dr["teacherCourse"])
                };
                // add the teacher to the list
                teachers.Add(teacher);
            }
            return teachers;
        }
        public Teacher NameToTeacherId(string name)
        {
            string query = $"SELECT teacherId FROM [Teachers] " +
                $"WHERE teacherName = @teacherName";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@teacherName", name)
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
    }
}