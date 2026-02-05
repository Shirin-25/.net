namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string USN { get; set; } = string.Empty;
        public int Age { get; set; }
        public int Marks { get; set; }
    }
}