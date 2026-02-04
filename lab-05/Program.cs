namespace lab_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 15;
            //float f1 = 14.2f, f2 = 10.5f;
            //Task1.Swap<int>(ref a, ref b);
            //Task1.Swap<float>(ref f1, ref f2);

            //Console.WriteLine($"a: {a} - b: {b}");
            //Console.WriteLine($"f1:{f1} - f2:{f2} ");


            MyList<int> l1 = new MyList<int>();

            l1.add(1);
            l1.add(2);
            l1.add(3);
            l1.add(4);
        }
    }
}
