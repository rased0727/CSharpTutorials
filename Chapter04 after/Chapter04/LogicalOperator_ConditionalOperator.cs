using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter04
{
    class LogicalOperator_ConditionalOperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing && ...");
            Console.WriteLine($"1>0 && 4<5 : {1 > 0 && 4 < 5}");
            Console.WriteLine($"1>0 && 4>5 : {1 > 0 && 4 > 5}");
            Console.WriteLine($"1==0 && 4>5 : {1 == 0 && 4 > 5}");
            Console.WriteLine($"1==0 && 4<5 : {1 == 0 && 4 < 5}");

            Console.WriteLine("\nTesting || ...");
            Console.WriteLine($"1>0 || 4<5 : {1 > 0 || 4 < 5}");
            Console.WriteLine($"1>0 || 4>5 : {1 > 0 || 4 > 5}");
            Console.WriteLine($"1==0 || 4>5 : {1 == 0 || 4 > 5}");
            Console.WriteLine($"1==0 || 4<5 : {1 == 0 || 4 < 5}");

            Console.WriteLine("\nTesting ! ...");
            Console.WriteLine($"!True : {!true}");
            Console.WriteLine($"!False : {!false}");


            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
        }
    }
}
