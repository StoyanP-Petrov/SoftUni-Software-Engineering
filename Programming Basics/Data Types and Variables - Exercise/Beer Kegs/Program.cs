<<<<<<< HEAD
﻿using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolue = 0;
            string biggestModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeUsing = Math.PI * (radius * radius) * height;
                if (volumeUsing > biggestVolue)
                {
                    biggestModel = model;
                    biggestVolue = volumeUsing;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
=======
﻿using System;

namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double biggestVolue = 0;
            string biggestModel = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeUsing = Math.PI * (radius * radius) * height;
                if (volumeUsing > biggestVolue)
                {
                    biggestModel = model;
                    biggestVolue = volumeUsing;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
>>>>>>> 2ec66682fb48c90532421c6969194d8974e888a4
