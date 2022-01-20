using DatabaseFirstEfSecond.Data;
using DatabaseFirstEfSecond.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirstEfSecond.Controllers
{
    public class StudentCourseNameController : Controller
    {
        private readonly ExampleDbContext _context;

        public StudentCourseNameController(ExampleDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var obj = (from sc in _context.StudentCourses
                       join s in _context.Students on sc.StudentId equals s.Id
                       join c in _context.Courses on sc.CourseId equals c.Id
                       select new
                       {
                           s.Name,
                           s.Class,
                           c.CourseName
                       }).ToList();

            //.OrderBy(x => new { x.Name, x.Class, x.CourseName })       
            ViewData.Model = obj;
            return View();
        }
    }
}
