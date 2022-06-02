using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class FloatingPoint
    {
        static void Main(string[] args)
        {
            float a = 3.14159265358979323846f;
            Console.WriteLine(a);

            double b = 3.14159265358979323846;
            Console.WriteLine(b);

            decimal c = 3.141592653589793238462643383279m;
            Console.WriteLine(c);
        }
    }
}
