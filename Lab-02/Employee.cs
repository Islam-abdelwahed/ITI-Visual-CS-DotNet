using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_02
{
    /// <summary>
    /// Represents an employee with identifying information, role level, salary, hire date, and gender.
    /// </summary>
    /// <remarks>Use this struct to store and transfer employee-related data within the application. The
    /// struct provides properties for accessing and modifying each aspect of the employee's profile.</remarks>
   public struct Employee
    {
        int id;
        SecurityLevel role;
        double salary;
        HiringDate hireDate;
        Gender gender;

        public Employee(int id, SecurityLevel role, double salary, HiringDate hireDate, Gender gender)
        {
            this.id = id;
            this.role = role;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }
        public int Id { get => id; set => id = value; }
        public SecurityLevel Security { get => role; set => role = value; }
        public double Salary { get => salary; set => salary = value; }
        public HiringDate HireDate { get => hireDate; set => hireDate = value; }
        public Gender Gender { get => gender; set => gender = value; }

        public override string ToString()
        {
            return String.Format(
                "ID: {0}, Gender: {1}, Security: {2}, Hire Date: {3}, Salary: {4:C}",
                id, gender, role, hireDate, salary
            );
        }
    }
}
