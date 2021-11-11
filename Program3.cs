using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Program3
    {
        public void Solution()
        {
            Console.Write("Enter the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Swapped Numbers is a = {0} and b = {1}", a, b);
        }
    }
}
