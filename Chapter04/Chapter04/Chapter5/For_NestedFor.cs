using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    class For_NestedFor
    {
        static void Main(string[] args)
        {
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
