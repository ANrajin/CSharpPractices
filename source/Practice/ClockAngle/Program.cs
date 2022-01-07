using System;

namespace ClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find Out The Angle Between Hour Hand And Minute Hand of 1.20 PM


            //formula: 5(6H - 1.1M)
            //total formula description can found in my raf note

            //Reference
            //https://www.c-sharpcorner.com/article/find-out-the-angle-between-hour-hand-and-minute-hand-in-c-sharp/

            Console.WriteLine("Please insert hour");
            int hour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please insert minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());

            var result = Math.Abs(5 * (6 * hour - 1.1 * minutes));

            Console.WriteLine($"Angle covered by hour hand and minutes hand in {hour}.{minutes} min is {result} deg");
        }
    }
}
