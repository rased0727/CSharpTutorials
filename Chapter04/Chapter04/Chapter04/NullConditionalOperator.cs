using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter04
{
    class NullConditionalOperator
    {
        static void Main(string[] args)
        {
            List<string> a = null;
            a?.Add("야구");
            a?.Add("축구");
            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a = new List<string>();

            a?.Add("야구");
            a?.Add("축구");

            Console.WriteLine($"Count : {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

        }
    }
}
