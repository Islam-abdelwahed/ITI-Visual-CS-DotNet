namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Ali");
            Student s2 = new Student(2, "Mona");
            Student s3 = new Student(3, "Omar");

            Department pd = new Department
            {
                Id = 10,
                Name = "Computer Science"
            };

            pd.AddStudent(s1);
            pd.AddStudent(s2);

            
            for (int i = 0; i < 5; i++)
            {
                s1.UpdateStudentAbsentDays();
            }

            Console.ReadLine();

        }
    }
}
