using System;
using System.Collections.Generic;

namespace Pratica6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Flávia";
            cookies["email"] = "flagia@gmail";
            cookies["phone"] = "991352372";

            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key!");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.ReadLine();
        }
    }
    
}
