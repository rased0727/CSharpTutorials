using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class Overflow
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);
            a = a + 1;
            Console.WriteLine(a);
        }
    }
}
