using System;
using System.Linq;

namespace Pratica10
{
    class Program
    {
        static void Main(string[] args)
        {
            //specify the date source
            int[] numbers = new int[] { 2, 3, 4, 5, 6 };

            //define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //execute the query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
