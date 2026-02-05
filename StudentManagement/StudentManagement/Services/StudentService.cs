using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "Anvesha", USN = "1AB23CS001", Age = 20, Marks = 85 },
            new Student { Id = 2, Name = "Rahul",   USN = "1AB23CS002", Age = 21, Marks = 90 }
        };

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student? GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Student student)
        {
            student.Id = _students.Max(s => s.Id) + 1;
            _students.Add(student);
        }

        public bool Update(int id, Student student)
        {
            var existing = GetById(id);
            if (existing == null) return false;

            existing.Name = student.Name;
            existing.USN = student.USN;
            existing.Age = student.Age;
            existing.Marks = student.Marks;

            return true;
        }

        public bool Delete(int id)
        {
            var student = GetById(id);
            if (student == null) return false;

            _students.Remove(student);
            return true;
        }
    }
}