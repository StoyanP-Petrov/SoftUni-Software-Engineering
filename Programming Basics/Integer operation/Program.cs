using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourNum = int.Parse(Console.ReadLine());

            int firstNumber = firstNum + secondNum;
            int secondNumber = firstNumber / thirdNum;
            int thirdNumber = secondNumber * fourNum;

            Console.WriteLine(thirdNumber);
        }
    }
}

