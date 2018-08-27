﻿using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Give me a number: ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Recursion(n));
            Console.ReadKey();
        }

        public static int Recursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                Console.WriteLine(n);
                return Recursion(n - 1);
            }
        }
    }
}
