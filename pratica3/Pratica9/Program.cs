using System;
using Pratica9.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Pratica9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));


            List<string> result = list.Select(NameUpper).ToList();
            foreach(string s in result)
            {
                Console.WriteLine(s);
                Console.ReadLine();
            }
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
