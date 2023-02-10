using System;

namespace Pratica7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 11, 15, 8, 10, 40);
            Console.WriteLine(dt.ElapsedTime());

            Console.ReadLine();
        }
    }
}
