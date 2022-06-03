using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class Bool
    {
        static void Main(string[] args)
        {
            // 수식 (Expression, 수식 또는 문장/표현) = 변수 혹은 리터럴들과 연산자가 조합된 문장(=식)
 



            bool a = true;
            bool b = false;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(2 < 4);

            if ( 2 < 4)
            {
                Console.WriteLine("Test");
            }

            bool c = (2 < 4);

            Console.WriteLine(c);


            bool d = Test();

            bool Test()
            {
                Console.WriteLine("Hello World!");
                int a = 3;
                float b = 3.0f;

                return (a == b);
            }
            
            Console.WriteLine(d);


        }
    }
}
