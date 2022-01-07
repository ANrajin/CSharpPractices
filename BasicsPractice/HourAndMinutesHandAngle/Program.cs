using System;

namespace HourAndMinutesHandAngle
{
    class Program
    {
        //The logic that we need to implement is to find the difference in the angle of an hour and minute hand from the position of 12 O Clock
        //when the angle between them is zero. Each hour on the clock represents an angle of 30 degrees (360 divided by 12). Similarly,
        //each minute on the clock will represent an angle of 6 degrees (360 divided by 60) and the angle for an hour will increase as the minutes
        //for that hour increases.
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter hour and minutes in hh.mm format");

            string[] str = Console.ReadLine().Split(".");

            //1 hour = 30 degree; hours*30 + (minutes*30)/60
            double hourHandDegree = int.Parse(str[0]) * 30 + ((int.Parse(str[1]) * 30) / 60);

            //1 min = 6 degree; minutes*6
            double minutesHandDegree = int.Parse(str[1]) * 6;

            double diff = Math.Abs(hourHandDegree - minutesHandDegree);

            if (diff > 180)
                diff = 360 - diff;

            Console.WriteLine(diff);
        }
    }
}
