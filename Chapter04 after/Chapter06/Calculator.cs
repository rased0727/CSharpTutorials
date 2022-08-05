using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter06
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(3, 4);
            Console.WriteLine(result);
        }
    }
}
