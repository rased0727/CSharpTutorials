using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace Chapter03
{
    class StringModify
    {
        static void Main(string[] args)
        {
            WriteLine("ToLower() : {0}", "ABC".ToLower()); // abc
            WriteLine("ToUpper() : {0}", "abc".ToUpper()); // ABC

            WriteLine("Insert() : {0}", "Happy Firday!".Insert(5, "Sunny")); // Happy Sunny Friday!
            WriteLine("Remove() : {0}", "I Don't Love you".Remove(2, 6)); // I Love you

            WriteLine("Trim() : {0}", " No Spaces ".Trim()); // "No Spaces"
            WriteLine("TrimStart() : {0}", " No Spaces ".TrimStart()); // "No Spaces "
            WriteLine("TrimEnd() : {0}", " No Spaces ".TrimEnd()); // " No Spaces"



            // 문자열 분리
            string greeting = "Good,Morning.";

            WriteLine(greeting.Substring(0, 5)); // good
            WriteLine(greeting.Substring(5)); // morning

            char separator = ',';
            //string[] separator = new string[] { " " }; // 조금 복잡한 방식
            string[] arr = greeting.Split(separator, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
            {
                WriteLine("{0}", element);
            }


        }
    }
}
