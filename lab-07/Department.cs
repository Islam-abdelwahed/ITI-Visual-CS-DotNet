using System;
using System.Collections.Generic;
using System.Text;

namespace lab_07
{
    public class Department
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
            e.EmpFired += RemoveEmployee;
        }

        public void RemoveEmployee(Employee e)
        {
            Employees.Remove(e);
            Console.WriteLine($"{e.Name} removed from Department");
        }
    }
}
