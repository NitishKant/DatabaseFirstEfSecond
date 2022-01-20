using System;
using System.Collections.Generic;

namespace DatabaseFirstEfSecond.Models
{
    public partial class Course
    {
        public Course()
        {
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string? CourseName { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
