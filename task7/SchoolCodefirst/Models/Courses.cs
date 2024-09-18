using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolCodefirst.Models
{
    public class Courses
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        //one to many relation between teacher and courses 
        // تعريف الفورن كي يكون من خلال وضع كلمة
        // [ForeignKey("Teacher")] وداخله اسم الكلاس اللي ماخذه منه واضافة public virtual Teacher Teacher { get; set; } 
        // ليكون حلقة الوصل بين الجدولين وسيكون نفسه موجود بالجدول الاخر باسم الكلاس courses

    }
}