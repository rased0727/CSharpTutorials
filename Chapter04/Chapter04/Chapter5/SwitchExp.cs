using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    class SwitchExp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요");
            int input = Convert.ToInt32(Console.ReadLine());
            int score = (int)(Math.Truncate(input / 10.0) * 10);

            Console.WriteLine("재수강인가요? (y/n)");
            string line = Console.ReadLine();

            bool repeated = line == "y" ? true : false;

            string grade = "";
            switch (score)
            {
                case 90:
                    {
                        if (repeated)
                        {
                            grade = "B+";
                        }
                        else
                        {
                            grade = "A";
                        }
                    break;
                    }
                case 80:
                    grade = "B";
                    break;
                case 70:
                    grade = "C";
                    break;
                case 60:
                    grade = "D";
                    break;
                default: 
                    grade = "F";
                    break;
            }
            Console.WriteLine($"학점:{grade}");
        }
    }
}
