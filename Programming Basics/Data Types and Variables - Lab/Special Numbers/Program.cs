<<<<<<< HEAD
﻿using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;
                int Sum = 0;

                while (currentNum != 0)
                {
                    Sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool special = Sum == 5 || Sum == 7 || Sum == 11;

                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
=======
﻿using System;

namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int currentNum = i;
                int Sum = 0;

                while (currentNum != 0)
                {
                    Sum += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool special = Sum == 5 || Sum == 7 || Sum == 11;

                Console.WriteLine($"{i} -> {special}");
            }
        }
    }
}
>>>>>>> 2ec66682fb48c90532421c6969194d8974e888a4
