using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolCodefirst.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolContext")
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Assignments> Assignments { get; set; }
        public DbSet<Courses> courses { get; set; }

        public System.Data.Entity.DbSet<SchoolCodefirst.Models.StudentDetails> StudentDetails { get; set; }
    }
}