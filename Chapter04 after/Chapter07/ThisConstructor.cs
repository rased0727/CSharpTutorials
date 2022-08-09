using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class ThisConstructor
    {
        int a, b, c;

        public ThisConstructor()
        {
            this.a = 5425;
            Console.WriteLine("ThisConstructor()");
        }
        public ThisConstructor(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"ThisConstructor({b})");
        }
        public ThisConstructor(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"ThisConstructor({b}, {c})");
        }
        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            ThisConstructor a = new ThisConstructor();
            a.PrintFields();
            Console.WriteLine();

            ThisConstructor b = new ThisConstructor(1);
            b.PrintFields();
            Console.WriteLine();

            ThisConstructor c = new ThisConstructor(10, 20);
            c.PrintFields();
            Console.WriteLine();

            // 이것보다 더 좋은 방식은 아래처럼 Init 함수를 두어서 초기화 함수를 주고 생성자로 호출 하는 방식이 더 명확하고 간결함
            /*
            public MyClass(int b, int c)
            {
                Init(b, c);


                this.c = c;
                Console.WriteLine($"MyClass({b}. {c})");
            }


            // 초기화 함수
            void Init(int b, int c)
            {
                this.b = b;
                this.c = c;
            }
            */

        }
    }
}
