using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentDB;
using System.Threading.Tasks;
using System.Data.SqlClient;
using StudentAutomation.Repository;

namespace StudentAutomation.DAL
{
    public class StudentAutomationDAL
    {
        private StudentAutomationRepository studentAutomationRepository;
        
        public StudentAutomationDAL()
        {
            studentAutomationRepository = new StudentAutomationRepository();
        }

        public List<Student> GetAllStudents()
        {
            return studentAutomationRepository.GetAllStudents();
        }
        public List<Course> GetAllCourses()
        {
            return studentAutomationRepository.GetAllCourses();
        }

        public void AddNewStudent(Student student)
        {
            studentAutomationRepository.AddNewStudent(student);
        }

        public void AddNewCourse(Course course)
        {
            studentAutomationRepository.AddNewCourse(course);
        }

        public void DeleteStudentById(Student student)
        {
            studentAutomationRepository.DeleteStudentById(student);
        
        }
        public void DeleteCourseByID(Course course)
        {
            studentAutomationRepository.DeleteCourseByID(course);

        }

        public void UpdateStudent(Student student)
        {
            studentAutomationRepository.UpdateStudent(student);                
        }

    }
}
