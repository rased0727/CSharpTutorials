using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter06
{
    class SwapByValRef
    {
        public static void Swap1(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static void Swap2(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            {
                int x = 3;
                int y = 4;

                Console.WriteLine($"x:{x}, y:{y}");

                Swap1(x, y);

                Console.WriteLine($"x:{x}, y:{y}");
                Console.WriteLine();
            }

            {
                int x = 3;
                int y = 4;

                Console.WriteLine($"x:{x}, y:{y}");

                Swap2(ref x, ref y);

                Console.WriteLine($"x:{x}, y:{y}");
            }
        }
    }
}
