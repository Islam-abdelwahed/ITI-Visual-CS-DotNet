namespace Lab_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose question:");
            Console.WriteLine("1 - Max Distance");
            Console.WriteLine("2 - Statement Reverse");
            Console.WriteLine("3 - Count Occurrence");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Q1_MaxDistance.Run();
                    break;
                case 2:
                    Q2_StatementReverse.Run();
                    break;
                case 3:
                    Q3_CountOccurrence.RunCase1();
                    break;
            }
        }
    }
}
