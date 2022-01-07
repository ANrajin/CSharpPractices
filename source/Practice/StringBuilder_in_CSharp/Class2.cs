using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_in_CSharp
{
    public static class Class2
    {
        // Create a string and concatenate 10 strings  
        // Using + operator
        public static void GetExecutionTimeUsingString()
        {
            string str = String.Empty;

            DateTime startTime = DateTime.Now;

            for(var i = 0; i <1000; i++)
            {
                str += i.ToString();
            }

            TimeSpan ts = DateTime.Now - startTime;

            Console.WriteLine($"Execution time (1000) using + operator: {ts.TotalMilliseconds}");

            Console.WriteLine();

            startTime = DateTime.Now;

            for (var i = 0; i < 1000; i++)
            {
                string.Concat(str, i.ToString());
            }

            ts = DateTime.Now - startTime;

            Console.WriteLine($"Execution time (1000) using String.Concat(): {ts.TotalMilliseconds}");
        }


        public static void GetExcutionTimeUsingStringBuilder()
        {
            StringBuilder str2 = new StringBuilder();

            DateTime startTime = DateTime.Now;

            for(var i =0; i < 1000; i++)
            {
                str2.Append(i.ToString());
            }

            TimeSpan ts = DateTime.Now - startTime;

            Console.WriteLine();

            Console.WriteLine($"Execution time (10) using StringBuilder: {ts.TotalMilliseconds}");
        }

    }
}
