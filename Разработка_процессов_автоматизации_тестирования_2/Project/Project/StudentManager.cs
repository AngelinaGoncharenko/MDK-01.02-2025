using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class StudentManager
    {
        private readonly List<Student> _students = [];

        public void AddStudent(string name, List<int> grades)
        {
            _students.Add(new Student { Name = name, Grades = grades });
        }

        public IEnumerable<string> GetStudents()
        {
            return _students.Select(s => $"{s.Name} - Средний балл: {s.Grades.Average()}");
        }

        public bool UpdateStudent(string name, List<int> newGrades)
        {
            var student = _students.FirstOrDefault(s => s.Name == name);
            if (student == null) return false;
            student.Grades = newGrades;
            return true;
        }

        public bool RemoveStudent(string name)
        {
            var student = _students.FirstOrDefault(s => s.Name == name);
            if (student == null)
            {
                return false;
            }

            _students.Remove(student);
            return true;
        }
    }
}
