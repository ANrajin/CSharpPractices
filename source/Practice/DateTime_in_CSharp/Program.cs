using System;

namespace DateTime_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(); 
            
            
            
            Console.WriteLine(dt); // 1/1/0001 12:00:00 AM
            Console.WriteLine();
            Console.WriteLine(dt.ToString(System.Globalization.CultureInfo.InvariantCulture)); // 01/01/0001 00:00:00
            Console.WriteLine();
            Console.WriteLine(dt.Equals(DateTime.MinValue));
            Console.WriteLine();

            //get current date time
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1); // 8/31/2021 8:56:22 AM

            Console.WriteLine();

            //current Coordinated Universal Time (UTC) date and time
            DateTime dt2 = DateTime.UtcNow;
            Console.WriteLine(dt2); // 8/31/2021 2:57:49 AM

            Console.WriteLine();

            //the current date only
            DateTime dt3 = DateTime.Today;
            Console.WriteLine(dt3); // 8/31/2021 12:00:00 AM

            Console.WriteLine();

            DateTime dt4 = new DateTime(2021, 08, 31);
            Console.WriteLine(dt4); // 8/31/2021 12:00:00 AM


            Console.WriteLine();

            /*
                *The TryParse and TryParseExact methods indicate whether a string is a valid
                *representation of a DateTime value and, if it is, performs the conversion.
            */

            var dateString = "08/31/2021 09:20 AM";
            DateTime dt5 = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture); // 8/31/2021 9:20:30 AM

            Console.WriteLine(dt5);

            Console.WriteLine();

            DateTime dt6 = DateTime.ParseExact(dateString, "MM/dd/yyyy hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dt6);

            Console.WriteLine();

            Console.WriteLine("===================================================================================================");

            Console.WriteLine();

            CustomDateTime.GetDateOnly(dateString);

            Console.ReadKey();
        }
    }
}
