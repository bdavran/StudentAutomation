using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public virtual ICollection<CoursesInStudent> CoursesInStudents { get; set; }
    }
}
