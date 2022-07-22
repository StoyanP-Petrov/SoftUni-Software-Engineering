<<<<<<< HEAD
﻿using System;

namespace Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                char character = (char)i;
                string text = character.ToString();
                Console.Write($"{text} ");
            }
        }
    }
}
=======
﻿using System;

namespace Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                char character = (char)i;
                string text = character.ToString();
                Console.Write($"{text} ");
            }
        }
    }
}
>>>>>>> 2ec66682fb48c90532421c6969194d8974e888a4
