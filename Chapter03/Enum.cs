using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    enum CharacterType
    {
        SWORDMAN,
        GUARD,
        ARCHER,
        WIZARD,

        SWORDMAN_U = 100,
        GUARD_U,
        ARCHER_U,
        WIZARD_U
    }
    enum DialogResult
    {
        Yes,
        No,
        Cancel,
        Confirm,
        OK
    }
    enum Team
    {
        BLUE,
        RED
    }
    class Enum
    {
        
        static void Main(string[] args)
        {
            const int BLUE = 0;
            const int RED = 0;

            
            Console.WriteLine((int)DialogResult.Yes);
            Console.WriteLine((int)DialogResult.No);
            Console.WriteLine((int)DialogResult.Cancel);
            Console.WriteLine((int)DialogResult.Confirm);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}
