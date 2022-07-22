<<<<<<< HEAD
﻿using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yeild = int.Parse(Console.ReadLine());

            int days = 0;
            int drops = 10;
            int totalLeaving = 0;
            int finalTake = 0;

            if (yeild >= 100)
            {
                for (int i = yeild; i >= 100;)
                {
                    days++;
                    int leaving = i - 26;
                    totalLeaving += leaving;
                    i = i - drops;
                }
                finalTake = totalLeaving - 26;
                Console.WriteLine(days);
                Console.WriteLine(finalTake);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(finalTake);
            }
        }
    }
}
=======
﻿using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yeild = int.Parse(Console.ReadLine());

            int days = 0;
            int drops = 10;
            int totalLeaving = 0;
            int finalTake = 0;

            if (yeild >= 100)
            {
                for (int i = yeild; i >= 100;)
                {
                    days++;
                    int leaving = i - 26;
                    totalLeaving += leaving;
                    i = i - drops;
                }
                finalTake = totalLeaving - 26;
                Console.WriteLine(days);
                Console.WriteLine(finalTake);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(finalTake);
            }
        }
    }
}
>>>>>>> 2ec66682fb48c90532421c6969194d8974e888a4
