using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter04
{
    class ShiftOperator_BitwiseOperator
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Testing <<...");

                int a = 1;
                Console.WriteLine("a      : {0:D5} (0x{0:X8})", a);
                Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);
                Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 2);
                Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 5);


                Console.WriteLine("Testing >>...");

                int b = 255;
                Console.WriteLine("b      : {0:D5} (0x{0:X8})", b);
                Console.WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 1);
                Console.WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 2);
                Console.WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 5);

                Console.WriteLine("Testing >> 2...");
                int c = -255;
                Console.WriteLine("c      : {0:D5} (0x{0:X8})", c);
                Console.WriteLine("c >> 1 : {0:D5} (0x{0:X8})", c >> 1);
                Console.WriteLine("c >> 2 : {0:D5} (0x{0:X8})", c >> 2);
                Console.WriteLine("c >> 5 : {0:D5} (0x{0:X8})", c >> 5);

            }
            {
                Console.WriteLine();
                Console.WriteLine();

                int a = 9;
                int b = 10;

                Console.WriteLine($"{a} & {b} : {a & b}");
                Console.WriteLine($"{a} | {b} : {a | b}");
                Console.WriteLine($"{a} ^ {b} : {a ^ b}");

                int c = 255;
                Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, -c);
            }
        }
    }
}
