using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment_1
{
    class Program9
    {
        static bool AlmostOnlyletters(string str)
        {
            Regex checkstring = new Regex(@"^[a-zA-Z\s]+$");      //if you want to give . at the end of the string
                                                                  //then you have to give \. in the regex
                                                                  //otherwise it will give False result.
            Match matchthestring = checkstring.Match(str);

            return matchthestring.Success;
        }
        public void Solution()
        {
            Console.WriteLine("please enter the string you want to check.");
            string input = Console.ReadLine();
            Console.WriteLine(AlmostOnlyletters(input));
        }
    }
}
