using System;
using Pratica5.Entities;

namespace Pratica5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gemail" };
            Client b = new Client { Name = "José", Email = "jose@gmail" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.ReadLine();
        }
    }
}
