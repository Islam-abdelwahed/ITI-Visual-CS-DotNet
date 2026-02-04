namespace Lab_02
{
    class Program
    {
        static void Main()
        {
            Employee[] EmpArr = new Employee[3];

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine($"\nEnter data for Employee {i + 1}");

                int id = ReadPositiveInt("ID: ");

                Gender gender;
                while (true)
                {
                    Console.Write("Gender (Male/Female): ");
                    if (Enum.TryParse(Console.ReadLine(), true, out gender))
                        break;
                    Console.WriteLine("Invalid gender.");
                }

                Console.WriteLine("Security Levels:");
                Console.WriteLine("1- Guest  2- Developer  4- Secretary  8- DBA  15- Full");
                SecurityLevel security;
                while (true)
                {
                    Console.Write("Security: ");
                    if (Enum.TryParse(Console.ReadLine(), out security) && Enum.IsDefined(typeof(SecurityLevel), security))
                        break;
                    Console.WriteLine("Invalid security level.");
                }

                double salary = ReadPositiveDouble("Salary: ");

                int day = ReadIntInRange("Hire Day: ", 1, 31);
                int month = ReadIntInRange("Hire Month: ", 1, 12);
                int year = ReadIntInRange("Hire Year: ", 1900, DateTime.Now.Year);

                HiringDate hd = new HiringDate(day, month, year);

                EmpArr[i] = new Employee(id, security, salary, hd, gender);
            }

            Array.Sort(EmpArr, (e1, e2) => HiringDate.CompareDates(e1.HireDate, e2.HireDate));

            Console.WriteLine("\nSorted Employees:");
            foreach (Employee e in EmpArr)
            {
                Console.WriteLine(e);
            }
        }

        static int ReadPositiveInt(string msg)
        {
            int value;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;
                Console.WriteLine("Invalid input. Must be a positive number.");
            }
        }

        static int ReadIntInRange(string msg, int min, int max)
        {
            int value;
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                    return value;
                Console.WriteLine($"Invalid input. Must be between {min} and {max}.");
            }
        }

        static double ReadPositiveDouble(string msg)
        {
            double value;
            while (true)
            {
                Console.Write(msg);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;
                Console.WriteLine("Invalid input. Must be a positive number.");
            }
        }
    }

}
