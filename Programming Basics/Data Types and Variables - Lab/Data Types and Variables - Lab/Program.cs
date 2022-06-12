using System;

namespace ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metars = int.Parse(Console.ReadLine());
            decimal kilometers = (decimal)metars / 1000;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
