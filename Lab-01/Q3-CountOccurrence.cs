using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab_01
{
    internal class Q3_CountOccurrence
    {
        public static void RunCase1()
        {
            const int max = 99999999;
            long count = 0;


            for (int i = 1; i <= max; i++)
            {
                string s = i.ToString();
                foreach (char c in s)
                {
                    if (c == '1')
                        count++;
                }
            }

            Console.WriteLine($"[String Method]");
            Console.WriteLine($"Count of '1' = {count}");
        }

        void RunCase2()
        {
            const int max = 99999999;
            long count = 0;

            for (int i = 1; i <= max; i++)
            {
                int n = i;
                while (n > 0)
                {
                    if (n % 10 == 1)
                        count++;
                    n /= 10;
                }
            }

            Console.WriteLine($"[Math Method]");
            Console.WriteLine($"Count of '1' = {count}");
        }
    }
}
