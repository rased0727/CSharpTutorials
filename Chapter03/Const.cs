using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class Const
    {
        static void Main(string[] args)
        {
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);


            Test();
        }
        static void Test()
        {
            //const int AA = 3;
            //AA = 4;
        }
    }
}
