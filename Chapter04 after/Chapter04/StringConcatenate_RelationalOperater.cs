using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter04
{
    class StringConcatenate_RelationalOperater
    {
        static void Main(string[] args)
        {
            string result = "123" + "456";
            Console.WriteLine(result);

            result = "Hello" + " " + "World";
            Console.WriteLine(result);

            Console.WriteLine();


            Console.WriteLine($"3>4 : { 3 > 4}");
            Console.WriteLine($"3>=4 : {3 >= 4}");
            Console.WriteLine($"3<4 : {3 < 4}");
            Console.WriteLine($"3<=4 : {3 <= 4}");
            Console.WriteLine($"3==4: {3 == 4}");
            Console.WriteLine($"3!=4: {3 != 4}");


        }
    }
}
