using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    class Break_Continue
    {
        static void Main(string[] args)
        {
            {
                while (true)
                {
                    Console.Write("계속할까요? (예/아니오) : ");
                    string answer = Console.ReadLine();
                    
                    if (answer == "아니오")
                    {
                        break;
                    }
                }
            }
            {
                for(int i=0; i<10; i++)
                {
                    if (i % 2 == 0)
                        continue;
                    Console.WriteLine($"{i} : 홀수");
                }
            }
        }
    }
}
