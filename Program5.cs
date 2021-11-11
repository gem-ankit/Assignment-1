using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Program5
    {
        public void Solution()
        {
            Console.Write("Enter the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                int c = 3 * (a + b);
                Console.WriteLine(c);
            }
            else
            {
                int c = a + b;
                Console.WriteLine(c);
            }
        }
    }
}
