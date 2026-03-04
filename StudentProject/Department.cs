using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();

        public void AddStudent(Student s)
        {
            Students.Add(s);
            s.StudentFired += RemoveStudent;
        }

        public void RemoveStudent(Student s)
        {
            Students.Remove(s);
            Console.WriteLine($"Student {s.Name} removed from Department");
        }
    }
}
