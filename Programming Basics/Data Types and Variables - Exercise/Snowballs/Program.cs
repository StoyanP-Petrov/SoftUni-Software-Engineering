using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            BigInteger bestValue = BigInteger.Zero;

            for (int i = 0; i < count; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                int divide = snow / time;
                BigInteger value = BigInteger.Pow(divide, quality);

                if (value >= bestValue)
                {
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                    bestValue = value;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
