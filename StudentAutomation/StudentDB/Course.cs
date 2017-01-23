using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentDB
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string CourseName { get; set; }

        public int Grade { get; set; }

        public virtual ICollection<CoursesInStudent> CoursesInStudents { get; set; }
    }
}
