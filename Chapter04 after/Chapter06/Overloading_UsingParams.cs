using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter06
{
    class Overloading_UsingParams
    {
        static int Plus(int a, int b)
        {
            Console.WriteLine("Calling int Plus(int, int)...");
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int, int, int)...");
            return a + b + c;
        }
        static double Plus(double a, double b)
        {
            Console.WriteLine("Calling Double Plus(double, double)...");
            return a + b;
        }
        static double Plus(int a, double b)
        {
            Console.WriteLine("Calling Double Plus(int, double)...");
            return a + b;
        }
        static int Sum(params int[] args)
        {
            Console.Write("Summing...");
            int sum = 0;
            for(int i = 0; i <args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }
        static void Main(string[] args)
        {
            { // overloading
                Console.WriteLine(Plus(1, 2));
                Console.WriteLine(Plus(1, 2, 3));
                Console.WriteLine(Plus(1.0, 2.4));
                Console.WriteLine(Plus(1, 2.4));
            }
            { // using Params
                int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
                Console.WriteLine($"Sum : {sum}");
            }
        }
    }
}
