using System;

namespace RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            for (int number = 1; number <= lastNumber; number++)
            {
                int currentNum = number;
                int sum = 0;

                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
            }
        }
    }
}
