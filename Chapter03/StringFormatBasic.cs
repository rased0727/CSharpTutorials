using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class StringFormatBasic
    {
        static void Main(string[] args)
        {
            string fmt = "{0, -20}{1, -15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Irom Man");
            WriteLine(fmt, "Hanbit", "SangHyun Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");

        }
    }
}
