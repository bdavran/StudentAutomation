using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StudentDB;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAutomation.Repository
{
    public class StudentAutomationRepository
    {
        public StudentDBContext StudentDBContext { get; set; }

        public StudentAutomationRepository()
        {
            StudentDBContext = new StudentDBContext();
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }
        public List<Course> GetAllCourses()
        {
            sqlCommand = dbConnection.GetSqlCommand();
            sqlCommand.CommandText = "SELECT * FROM Course";


            var courses = new List<Course>();
            var sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var course = new Course()
                {
                    CourseName = sqlDataReader["StudentName"].ToString(),
                    Grade = Convert.ToInt32(sqlDataReader["Grade"]),
                    StudentID = Convert.ToInt32(sqlDataReader["StudentID"]),


                };

                courses.Add(course);
            }
            return courses;
        }

        public void AddNewStudent(Student student)
        {
            var sqlCommand = dbConnection.GetSqlCommand();
            sqlCommand.CommandText = String.Format("INSERT INTO Students (StudentName, StudentLastName, Age, Gender) VALUES('{0}', '{1}', {2}, '{3}')", student.StudentName, student.StudentLastname, student.Age, student.Gender);

            sqlCommand.ExecuteNonQuery();
        }

        public void AddNewCourse(Course course)
        {
            var sqlCommand = dbConnection.GetSqlCommand();
            sqlCommand.CommandText = String.Format("INSERT INTO Courses (CourseName, Grade, StudentID) VALUES('{0}', {1}, {2})", course.CourseName, course.Grade, course.StudentID);

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteStudentById(Student student)
        {
            var sqlCommand = dbConnection.GetSqlCommand();
            sqlCommand.CommandText = String.Format("DELETE FROM Students WHERE StudentID = {0}", student.StudentID);
            sqlCommand.ExecuteNonQuery();

        }
        public void DeleteCourseByID(Course course)
        {
            var sqlCommand = dbConnection.GetSqlCommand();
            sqlCommand.CommandText = String.Format("DELETE FROM Courses WHERE CourseID = {0}", course.CourseID);
            sqlCommand.ExecuteNonQuery();

        }

        public void UpdateStudent(Student student)
        {
            var sqlCommand = dbConnection.GetSqlCommand();
            sqlCommand.CommandText = String.Format("UPDATE Students SET StudentName = '{0}', StudentLastName = '{1}', Age = {2}, Gender = '{3}' WHERE StudentID = {4}", student.StudentName, student.StudentLastname, student.Age, student.Gender, student.StudentID);
            sqlCommand.ExecuteNonQuery();

        }
    }
}
