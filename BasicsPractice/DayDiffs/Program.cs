using System;

namespace DayDiffs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Difference between two date
            DateTime pastDate = new DateTime(2021, 11, 10);
            DateTime today = DateTime.Now;

            int difference = (today - pastDate).Days;

            Console.WriteLine(difference);
        }
    }
}
