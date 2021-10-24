using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    class Authentication
    {
        static void Main(string[] args)
        {
            string login = "johnsilver";
            string pass = "qwerty";
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter login:");
                string userlogin = Console.ReadLine();
                Console.WriteLine("Enter pass:");
                string userpass = Console.ReadLine();
                if (userlogin == login && userpass == pass)
                {
                    Console.WriteLine("Enter the System");
                    break;
                }
                else
                {
                    if(i < 2)
                    {
                        Console.WriteLine("Mistake. Try again");
                        continue;
                    }
                    else
                      Console.WriteLine("The number of available tries have been exceeded");
                }
            }
        }
    }
}
