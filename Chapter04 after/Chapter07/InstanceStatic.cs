using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class Global
    {
        public static int Count = 0;
    }
    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }
    internal class InstanceStatic
    {
        static void Main()
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();


            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
