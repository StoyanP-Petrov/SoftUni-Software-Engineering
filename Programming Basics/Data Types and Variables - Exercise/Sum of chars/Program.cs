using System;
using System.Text;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                string s = Console.ReadLine();

                foreach (char c in s)
                {
                    sum += ((int)c);
                }
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}