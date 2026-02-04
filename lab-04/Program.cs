namespace lab_04
{
    internal class Program
    {
  

        static void Main(string[] args)
        {
            OddSeries o1 = new OddSeries();
            Console.WriteLine(o1.GetNextNumber());
            Console.WriteLine(o1.GetNextNumber());
            Console.WriteLine(o1.GetNextNumber());
            Console.WriteLine(o1.GetNextNumber());

            EvenSeries o2 = new EvenSeries();
            Console.WriteLine(o2.GetNextNumber());
            Console.WriteLine(o2.GetNextNumber());

            PowerSeries s3 = new PowerSeries();
            Console.WriteLine(s3.GetNextNumber());
            Console.WriteLine(s3.GetNextNumber());
            Console.WriteLine(s3.GetNextNumber());
            Console.WriteLine(s3.GetNextNumber());
        }
    }
}