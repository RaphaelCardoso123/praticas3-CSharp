using System;

namespace pratica3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintServiceString printService = new PrintServiceString();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = (Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.Write("First: " + printService.First());

            Console.ReadLine();
        }
    }
}
