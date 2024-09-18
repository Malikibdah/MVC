using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolCodefirst.Models
{
    public class StudentDetails
    {
        [Key, ForeignKey("Student")]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }

        public virtual Student Student { get; set; }
    }
}