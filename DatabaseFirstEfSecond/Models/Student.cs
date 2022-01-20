using System;
using System.Collections.Generic;

namespace DatabaseFirstEfSecond.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Class { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
