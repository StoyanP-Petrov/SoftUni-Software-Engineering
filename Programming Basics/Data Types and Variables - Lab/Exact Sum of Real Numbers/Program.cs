using System;

namespace Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 1; i <= n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());

            }
            Console.WriteLine(sum);
        }
    }
}
