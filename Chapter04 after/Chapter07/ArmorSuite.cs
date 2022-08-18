using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter07
{
    class ArmorSuite
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }
    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");  
        }
    }
    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Lunchers Armed");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("Creating IronMan...");
            ArmorSuite ironMan = new IronMan();
            ironMan.Initialize();

            Console.WriteLine("Creating WarMachine...");
            ArmorSuite warMachine = new WarMachine();
            warMachine.Initialize();
        }
    }
}
