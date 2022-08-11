using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class Bird
    {
        protected string Name;
        public Bird(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Bird()");
        }

        public void Fly()
        {
            Console.WriteLine($"{Name}.Fly()");
        }

        

    }
    class Duck : Bird
    {
        public Duck(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Duck()");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name}.MakeSound()");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Bird a = new Bird("a");
            a.Fly();

            Duck b = new Duck("b");
            b.Fly();
            b.MakeSound();


        }
    }
}
