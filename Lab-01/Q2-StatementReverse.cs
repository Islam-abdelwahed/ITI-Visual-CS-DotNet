using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01
{
    internal class Q2_StatementReverse
    {
        public static void Run()
        {
            Console.WriteLine("Enter a statement:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                string[] words = input.Split(' ');
                Array.Reverse(words);
                string reversedStatement = string.Join(' ', words);
                Console.WriteLine("Reversed statement:");
                Console.WriteLine(reversedStatement);
            }
            else
            {
                Console.WriteLine("No input provided.");
            }

        }
    }
}
