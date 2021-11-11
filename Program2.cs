using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Program2
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        public void Solution()
        {
            Console.Write("Enter the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Sum(a, b);
            Console.WriteLine("The sum of {0} and {1} is = {2}", a, b, c);
        }
    }
}
