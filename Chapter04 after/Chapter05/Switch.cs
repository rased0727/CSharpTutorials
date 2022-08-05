using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.Write("요일을 입력하세요. (일,월,화,수,목,금,토) : ");
            string day = Console.ReadLine();

            switch (day)
            {
                case "sun":
                    Console.WriteLine("Sunday");
                    break;
                case "mon":
                    Console.WriteLine("Monday");
                    break;
                case "tue":
                    Console.WriteLine("Tuesday");
                    break;
                case "wed":
                    Console.WriteLine("Wednesday");
                    break;
                case "thu":
                    Console.WriteLine("Thursday");
                    break;
                case "fri":
                    Console.WriteLine("Friday");
                    break;
                case "sat":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine($"{day}은(는) 요일이 아닙니다.");
                    break;



            }


        }
    }
}
