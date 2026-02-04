using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_01
{
    internal class Q1_MaxDistance
    {
        public static void Run()
        {
            Console.WriteLine("Enter the array size");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Pleas enter valid numbers");
            }
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Pleas enter valid numbers");
                }
                arr[i] = x;
            }

            int maxDistance = -1;
            for (int i = 0; i < size - 1; i++)
            {
                int distance = 0;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        distance = j - i - 1;
                    }
                }
                if (distance > maxDistance)
                    maxDistance = distance;
            }

            Console.WriteLine(maxDistance);

        }
    }
}
