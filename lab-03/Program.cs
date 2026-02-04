using lab_03.Models;
using Lab_03.Models;
using System;

namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunPoint3DTasks();
            RunMathTasks();
            RunNICTask();
            RunDurationTask();
        }

        
        // Task 1–6: Point3D
        
        static void RunPoint3DTasks()
        {
            Console.WriteLine("\n===== Point3D Tasks =====");

            Point3D P1 = new Point3D(10, 10, 10);
            Point3D P2 = new Point3D(10, 10, 10);
            Point3D P3 = new Point3D(5, 2, 1);

            Console.WriteLine(P1);

            string s = (string)P1;
            Console.WriteLine($"Cast to string: {s}");

            Console.WriteLine($"P1 == P2 : {P1 == P2}");

            Point3D[] points = { P1, P2, P3 };
            Array.Sort(points);

            Console.WriteLine("Sorted Points:");
            foreach (var p in points)
                Console.WriteLine(p);

            Point3D clone = (Point3D)P1.Clone();
            Console.WriteLine($"Cloned: {clone}");
        }

        
        // Task 7–8: Math Class
        
        static void RunMathTasks()
        {
            Console.WriteLine("\n===== Math Tasks =====");

            Console.WriteLine(lab_03.Models.Math.Add(10, 5));
            Console.WriteLine(lab_03.Models.Math.Subtract(10, 5));
            Console.WriteLine(lab_03.Models.Math.Multiply(10, 5));
            Console.WriteLine(lab_03.Models.Math.Divide(10, 5));
        }

        
        // Task 9: NIC (Singleton)
        
        static void RunNICTask()
        {
            Console.WriteLine("\n===== NIC Task =====");

            NIC nic = NIC.Instance;
            Console.WriteLine(nic);
        }

        
        // Task 10: Duration
        
        static void RunDurationTask()
        {
            Console.WriteLine("\n===== Duration Task =====");

            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(7800);
            Duration D3 = new Duration(666);

            Console.WriteLine(D1);
            Console.WriteLine(D2);
            Console.WriteLine(D3);

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;

            D3 = D1++;
            D3 = --D2;

            if (D1 > D2) { }
            if (D1 <= D2) { }

            if (D1)
                Console.WriteLine("Duration is valid");

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt);
        }
    }
}
