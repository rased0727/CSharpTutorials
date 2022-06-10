using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    enum DialogResult2
    {
        YES,
        NO,
        CANCEL,
        CONFIRM,
        OK
    }
    class Enum2
    {
        static void Main(string[] args)
        {
            DialogResult2 result = DialogResult2.YES;

            Console.WriteLine(result);
            Console.WriteLine(result == DialogResult2.YES);
            Console.WriteLine(result == DialogResult2.NO);
            Console.WriteLine(result == DialogResult2.CANCEL);
            Console.WriteLine(result == DialogResult2.CONFIRM);
            Console.WriteLine(result == DialogResult2.OK);

        }
    }
}
