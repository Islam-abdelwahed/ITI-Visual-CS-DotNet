using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProject
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AbsentDays { get; private set; }

        public event Action<Student> StudentFired;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
            AbsentDays = 0;
        }

        public void UpdateStudentAbsentDays()
        {
            AbsentDays++;

            if (AbsentDays > 4)
            {
                StudentFired?.Invoke(this);
            }
        }
    }
}
