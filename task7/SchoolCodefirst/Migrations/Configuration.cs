namespace SchoolCodefirst.Migrations
{
    using SchoolCodefirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SchoolCodefirst.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SchoolCodefirst.Models.SchoolContext context)
        {
            //Add default students
                context.Students.AddOrUpdate(
                    s => s.Name,
                    new Student { Name = "John Doe", Assignments = "25" },
                    new Student { Name = "Jane Smith", Assignments = "976543210" }
                );

            // Add default student details
            context.StudentDetails.AddOrUpdate(
            sd => sd.Id,
                new StudentDetails { Id = 1, Address = "123 Elm Street", Email = "john.doe@example.com" },
                new StudentDetails { Id = 2, Address = "456 Oak Avenue", Email = "jane.smith@example.com" }
            );

            // Add default courses
            context.courses.AddOrUpdate(
            c => c.Name,
                new Courses { Name = "Mathematics", TeacherID = 1 },
                new Courses { Name = "Science", TeacherID = 2 }
            );
        }
        
    }
}
