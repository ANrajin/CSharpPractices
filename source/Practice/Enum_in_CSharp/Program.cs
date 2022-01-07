using System;

namespace Enum_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Days.Sunday);//Sunday
            //Console.WriteLine((int)Days.Sunday);//1

            //Console.WriteLine(Days.Tuesday);//Tuesday
            //Console.WriteLine((int)Days.Tuesday);//10


            //Program showing enum type having same values
            string[] values = Enum.GetNames(typeof(DaysofWeek));

            foreach (string s in values)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            int[] n = (int[])Enum.GetValues(typeof(DaysofWeek));

            foreach (int x in n)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            //Program to find out the number of values in enum
            string[] vals = Enum.GetNames(typeof(Days));
            int total = 0;

            foreach (string s in vals)
            {
                Console.WriteLine(s);
                total++;
            }

            Console.WriteLine("Total values in enum type is : {0}", total);

            Console.WriteLine();

            int[] m = (int[])Enum.GetValues(typeof(Days));
            foreach (int x in m)
            {
                Console.WriteLine(x);
            }
        }


        public enum Days
        {
            Saturday,
            Sunday,
            Monday,
            Tuesday = 10,
            Wednesday,
            Thursday,
            Friday
        }

        public enum DaysofWeek
        {
            Sunday = 1,
            Monday,
            Tuesday = 1,
            Wednesday,
            Thursday = 2,
            Friday,
            Saturday
        }
    }
}
