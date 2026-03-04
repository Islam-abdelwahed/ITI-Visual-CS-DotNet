namespace lab_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Ahmed");
            Employee e2 = new Employee("Sara");

            Department it = new Department();
            Club c1 = new Club();

            it.AddEmployee(e1);
            it.AddEmployee(e2);

            c1.Add(e1);
            c1.Add(e2);

            
            for (int i = 0; i < 6; i++)
            {
                e1.UpdateAbsentDays();
            }

            Console.ReadLine();
        }
    }
}
