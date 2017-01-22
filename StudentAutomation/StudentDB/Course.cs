using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    public class Course
    {
        public int CourseID { get; set; }

        [Required, StringLength(50)]
        public string CourseName { get; set; }

        public int Grade { get; set; }

        public int StudentID { get; set; }

        public virtual List<Student> Student { get; set; }


    }
}
