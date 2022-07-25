using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter06
{
    class NamedParameter_OptionalParameter
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void PrintProfile2(string name, string phone = "")
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            {
                PrintProfile(name: "박찬호", phone: "010-123-1234");
                PrintProfile(phone: "010-987-9876", name: "박지성");
                PrintProfile(name: "박세리", phone: "010-222-2222");
                PrintProfile(name: "박상현", phone: "010-567-5678");
            }
            {
                PrintProfile2("중근");
                PrintProfile2("관순", "010-123-1234");
                PrintProfile2("봉길");
                PrintProfile2("동주", "010-789-7890");
            }
            
        }

    }
}
