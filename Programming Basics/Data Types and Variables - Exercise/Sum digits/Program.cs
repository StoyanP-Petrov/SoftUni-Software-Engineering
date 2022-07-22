<<<<<<< HEAD
﻿using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {
                int lastNumber = number % 10;
                sum += lastNumber;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
=======
﻿using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number != 0)
            {
                int lastNumber = number % 10;
                sum += lastNumber;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
>>>>>>> 2ec66682fb48c90532421c6969194d8974e888a4
}