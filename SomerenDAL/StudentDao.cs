using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {      
        public List<Student> GetAllStudents()
        {
            // select the query from the Students database
            string query = "SELECT studentId, studentName, studentLanguage, studentDateOfBirth, studentRoomId FROM [Students]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            // check each row of the DataTable
            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentId = (int)dr["studentId"],
                    StudentName = (string)dr["studentName"],
                    StudentLanguage = (string)dr["studentLanguage"],
                    StudentDateOfBirth = (DateTime)dr["studentDateOfBirth"],
                    StudentRoomId = (int)(dr["studentRoomId"])
                };
                // add the student to the list
                students.Add(student);
            }
            return students;
        }
    }
}
