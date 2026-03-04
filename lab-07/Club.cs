using System;
using System.Collections.Generic;
using System.Text;

namespace lab_07
{
    public class Club
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public void Add(Employee e)
        {
            Employees.Add(e);
            e.EmpFired += Remove;
        }

        public void Remove(Employee e)
        {
            Employees.Remove(e);
            Console.WriteLine($"{e.Name} removed from Club");
        }
    }
}
