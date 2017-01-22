using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    public class Student
    {

        public int StudentID { get; set; }
        [Required,StringLength(50)]
        public string StudentName { get; set; }
        [Required, StringLength(50)]
        public string StudentLastname { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public int CourseID { get; set; }

        public virtual List<Course> Course { get; set; }


    }
}
