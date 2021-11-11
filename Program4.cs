using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Program4
    {
        public void Solution()
        {
            Console.Write("Enter the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a > -10 && a < 10) || (b > -10 && b < 10))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");
        }
    }
}
