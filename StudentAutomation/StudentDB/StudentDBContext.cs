using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;

namespace StudentDB
{
    public class StudentDBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public StudentDBContext()
            : base(ConfigurationManager.ConnectionStrings["StudentApp.ConnectionString"].ConnectionString)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CoursesInStudent> CoursesInStudents { get; set; }
    }
}

