using System;

namespace Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int centuries = 100;
            const decimal year = 365.2422m;
            const int day = 24;
            const int hour = 60;

            var centurie = int.Parse(Console.ReadLine());

            int years = centurie * centuries;
            double days = (int)(years * year);
            double hours = days * day;
            double minutes = hours * hour;

            Console.WriteLine($"{centurie} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
