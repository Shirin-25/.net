using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
using System.Collections.Generic;

namespace StudentMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Shirin", Marks = 85 },
                new Student { Id = 2, Name = "Prarthana", Marks = 78 },
                new Student { Id = 3, Name = "Sinchana", Marks = 92 },
                new Student { Id = 4, Name = "Vaishnami", Marks = 68 }
            };

            return View(students);
        }
    }
}