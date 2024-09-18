using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolCodefirst.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
    }
}