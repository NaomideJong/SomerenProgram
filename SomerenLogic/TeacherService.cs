using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class TeacherService
    {
        TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }

        public List<Teacher> GetTeachers()
        {
            // return the list of teacher
            List<Teacher> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }
        public Teacher NameToTeacherId(string Name)
        {
            teacherdb.NameToTeacherId(Name);
        }
    }
}