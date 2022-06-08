using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class TypeConversion
    {
        static void Main(string[] args)
        {
            /*
             * 형 변환
             * 작성자 : 정문항
             * 일자 : 2022. 6. 8
             */
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
        }
        static void Test1()
        {
            /*
             * 정수형 사이의 변환
             * 작성자 : 정문항
             * 일자 : 2022. 6. 8
             */
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a; // sbyte 를 int로 변환 (문제없음)
            Console.WriteLine(b);

            int x = 128; // sbyte의 최대값보다 1 큰 수 (int가 크므로 문제 없음)
            Console.WriteLine(x);

            sbyte y = (sbyte)x; // sbyte의 최대치인 127을 넘어버렸음에도 값이 변조되어 128로 잘못 나옴 (조심해야함)
            Console.WriteLine(y);
        }
        static void Test2()
        {
            /*
             * 부동소수점 사이의 변환
             * 작성자 : 정문항
             * 일자 : 2022. 6. 8
             */
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a);

            double b = (double)a;
            Console.WriteLine("b : {0}", b);
            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f; // 그냥 0.1만 넣어서 정밀도가 전혀 없는 상황
            Console.WriteLine("x : {0}", x);

            double y = (double)x; // 내가 의도치 않은 정밀도가 생겨버려서 이상한 정밀도의 값이 들어가져버림.
            Console.WriteLine("y : {0}", y);

            Console.WriteLine("0.1 == y : {0}", 0.1 == y);
        }
        static void Test3()
        {
            /*
             * 부호있는 정수 형식과 부호 없는 정수 형식 사이의 변환
             * 작성자 : 정문항
             * 일자 : 2022. 6. 8
             */
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x; // int를 uint로 바꾸니까 의도치 않은 42억의 수가 나와버림 (조심해야함)
            Console.WriteLine(y); // -30은 대충 비트로 바꾸면 11111111110000 인데
                                    // 이걸 uint로 바꾸는 순간, 최대값(42억)에서 30이 빠진 수가 되버린다.
        }
        static void Test4()
        {
            /*
             * 부동 소수점 형식과 정수 형식 사이의 변환
             * 작성자 : 정문항
             * 일자 : 2022. 6. 8
             */
            float a = 0.9f;
            int b = (int)a; // 소수점이 날라가버리므로 주의하기
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);
        }
        static void Test5()
        {
            /*
             * 문자열을 숫자로, 숫자를 문자열로
             * 작성자 : 정문항
             * 일자 : 2022. 6. 8
             */
            int a = 123;
            string b = a.ToString(); // 숫자를 문자로 바꿀때는 ToString() 함수를 써야함
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString(); // 위에서 int를 변환할때도 똑같은 ToString을 사용하지만, 가상함수이므로 overriding에 의해 다르게 다형성이 적용된다.
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e); // float로 바꾸고자한다면 ToSingle을, double 을 사용하고자한다면 ToInt64로 사용하면 됨

            string g = "1.2345";
            float h = float.Parse(g); // 이런식으로 float.Parse를 사용하면 됨
            Console.WriteLine(h);

        }
    }
}

