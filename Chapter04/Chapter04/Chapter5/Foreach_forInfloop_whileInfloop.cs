using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    class Foreach_forInfloop_whileInfloop
    {
        static void Main(string[] args)
        {
            {
                //int[] arr = new int[] { 0, 1, 2, 3, 4 };
                List<int> arr = new List<int>();
                arr.Add(0);
                arr.Add(1);
                arr.Add(2);
                arr.Add(3);
                arr.Add(4);

                foreach (int a in arr)
                {
                    Console.Write(a);
                }
            }
            {
                int i = 0;
                for(; ; )
                {
                    Console.WriteLine(i++);
                }
            }
            {
                int i = 0;
                while (true)
                {
                    Console.WriteLine(i++);
                }
            }
        }
    }
}
