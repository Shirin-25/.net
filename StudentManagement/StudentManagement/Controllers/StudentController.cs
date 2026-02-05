using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {

        private static List<Student> students = new List<Student>
        {
            new Student { Name = "Anvesha", USN = "CS001", Age = 20, Marks = 85 },
            new Student { Name = "Rahul", USN = "CS002", Age = 21, Marks = 78 }
        };

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return Ok(students);
        }
    }
}
