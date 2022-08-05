using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat()
        {
            Name = "";
            Color = "";
        }
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Cat()
        {
            Console.WriteLine($"{Name} : 잘가");
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    class Constructor
    {
        static void Main(string[] args)
        {
            Test();
            GC.Collect();

            Cat cat = new Cat();
            cat.Meow();
            Console.WriteLine($"{cat.Name} : {cat.Color}");

            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검정색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }

        static void Test()
        {
            Cat c = new Cat();
            c.Meow();
        }
    }
}
