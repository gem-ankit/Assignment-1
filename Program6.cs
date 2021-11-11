using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Program6
    {
        public void Solution()
        {
            string username, password;
            //default username and password is userid and password.
            int counter = 0, authorizedUser = 0;
            do
            {

                Console.WriteLine("Enter the username");
                username = Console.ReadLine();
                Console.WriteLine("Enter the password");
                password = Console.ReadLine();

                if (username == "userid" && password == "password")
                {
                    counter = 3;
                    authorizedUser = 1;
                }
                else
                {
                    counter++;
                    authorizedUser = 0;
                }

            } while ((username != "userid" || password != "password") && counter != 3);
            if (authorizedUser == 0)
            {
                Console.WriteLine("3 attempts done ! ");
            }
            else
            {
                Console.WriteLine("Welcome! you've come along the way.");
            }
        }
    }
}
