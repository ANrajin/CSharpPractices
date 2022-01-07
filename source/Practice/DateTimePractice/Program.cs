using System;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime();

            Console.WriteLine(myDate);//1/1/0001 12:00:00 AM


            DateTime myDateTwo = new DateTime(2005, 10, 5);

            Console.WriteLine(myDateTwo);//10/5/2005 12:00:00 AM

            /*
             * Current Date n Time
             */
            DateTime myDt = DateTime.Today;
            Console.WriteLine(myDt); // 7/16/2021 12:00:00 AM

            DateTime myDt2 = DateTime.Now;

            Console.WriteLine(myDt2); //7/16/2021 10:09:40 PM

            //Display only current Date
            Console.WriteLine(myDt2.ToShortDateString());//7/16/2021

            //Display the current time only
            Console.WriteLine(myDt2.ToShortTimeString()); //10:13 PM

            Console.WriteLine(myDt2.ToLocalTime()); //7/16/2021 10:13:57 PM

            //Display current day of week
            Console.WriteLine(myDt2.DayOfWeek); //Friday

            //Display current Day of the year
            Console.WriteLine(myDt2.DayOfYear); //197

            //Display current month number
            Console.WriteLine(myDt2.Month); //7

            //Display Current year
            Console.WriteLine(myDt2.Year); //2021
        }
    }
}
