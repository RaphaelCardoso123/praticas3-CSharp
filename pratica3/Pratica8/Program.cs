using System;
using Pratica8.Entities;
using System.Collections.Generic;

namespace Pratica8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));

            list.RemoveAll(p => p.Price >= 100.00);
            foreach(Product p in list)
            {
                Console.WriteLine(p);

                Console.ReadLine();
            }
        }
    }
}
