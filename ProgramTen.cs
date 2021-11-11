using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class ProgramTen
    {
        static bool IsResultTheSame(double a, double b)  // we take double data type beacuse
                                                         // we don't know the size of value
        {
            return a == b;
        }
        public void Solution()
        {
            int number1, number2, number3, number4;
            Console.Write("Enter the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third Number : ");
            number3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Fourth Number : ");
            number4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsResultTheSame(number1 + number2, number3 * number4));
        }
    }
}
