using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Program8
    {
        static bool IfConsistsOfUppercaseLetters(string str)
        {
            if ((str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Solution()
        {
            string str1 = "xyz";
            string str2 = "DOG";
            string str3 = "L9#";
            Console.WriteLine(IfConsistsOfUppercaseLetters(str1));
            Console.WriteLine(IfConsistsOfUppercaseLetters(str2));
            Console.WriteLine(IfConsistsOfUppercaseLetters(str3));
        }
    }
}
