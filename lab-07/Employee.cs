using System;
using System.Collections.Generic;
using System.Text;

namespace lab_07
{
    public class Employee
    {
        public string Name { get; set; }
        public int AbsentDays { get; private set; }

        // Event
        public event Action<Employee> EmpFired;

        public Employee(string name)
        {
            Name = name;
            AbsentDays = 0;
        }

        public void UpdateAbsentDays()
        {
            AbsentDays++;

            if (AbsentDays > 5)
            {
                EmpFired?.Invoke(this);
            }
        }
    }
}
