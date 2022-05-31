using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class SignedUnsigned
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");

        }
    }
}
