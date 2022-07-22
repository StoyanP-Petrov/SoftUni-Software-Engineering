using System;

namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTanks = 255;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int pourWater = int.Parse(Console.ReadLine());
                if (pourWater > waterTanks)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterTanks -= pourWater;
                    sum += pourWater;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
