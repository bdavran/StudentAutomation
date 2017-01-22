using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAutomation.DAL;
using StudentDB;

namespace StudentAutomation.BLL
{
    public class StudentAutomationBLL
    {
        private StudentAutomationDAL studentAutomationDAL;
        public StudentAutomationBLL()
        {
            studentAutomationDAL = new StudentAutomationDAL();
        }

        public List<Student> GetAllStudents()
        {
            return studentAutomationDAL.GetAllStudents();
        }
        public List<Course> GetAllCourses()
        {
            return studentAutomationDAL.GetAllCourses();
        }

        public void AddNewStudent(Student student)
        {
            studentAutomationDAL.AddNewStudent(student);
        }

        public void AddNewCourse(Course course)
        {
            studentAutomationDAL.AddNewCourse(course);
        }

        public void DeleteStudentById(Student student)
        {
            studentAutomationDAL.DeleteStudentById(student);

        }
        public void DeleteCourseByID(Course course)
        {
            studentAutomationDAL.DeleteCourseByID(course);

        }

        public void UpdateStudent(Student student)
        {
            studentAutomationDAL.UpdateStudent(student);
        }


    }
}
