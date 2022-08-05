using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter06
{
    class RefReturn_UsingOut
    {
        class Product
        {
            private int price = 100;

            public ref int GetPrice()
            {
                return ref price;
            }
            public void PrintPrice()
            {
                Console.WriteLine($"Price : {price}");
            }
        }
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        static void Main(string[] args)
        {
            {   // RefReturn
                Product carrot = new Product();
                ref int ref_local_price = ref carrot.GetPrice();
                int normal_local_price = carrot.GetPrice();

                carrot.PrintPrice();
                Console.WriteLine($"Ref Local Price : {ref_local_price}");
                Console.WriteLine($"Normal Local Price : {normal_local_price}");

                ref_local_price = 200;

                carrot.PrintPrice();
                Console.WriteLine($"Ref Local Price : {ref_local_price}");
                Console.WriteLine($"Normal Local Price : {normal_local_price}");
                Console.WriteLine();
            }
            {   // UsingOut
                int a = 20;
                int b = 3;
                // int c; // 밑에 메서드 출력부에서 선언해도 된다. (그래서 보여주려고 주석처리)
                // int d;

                Divide(a, b, out int c, out int d);
                Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");

            }
            
        



        }
    }
}
