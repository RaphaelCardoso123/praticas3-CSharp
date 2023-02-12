using System;
using System.Linq;
using Pratica11.Entities;
using System.Collections.Generic;

namespace Pratica11
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "SmartPhone", Price = 90.0, Category = c2 },
                new Product() { Id = 3, Name = "Hammer", Price = 70.0, Category = c1 },
                new Product() { Id = 4, Name = "Glove", Price = 30.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Tier 1 and Price < 900.00", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Tools", r2);

            Console.ReadLine();
        }
    }
}
