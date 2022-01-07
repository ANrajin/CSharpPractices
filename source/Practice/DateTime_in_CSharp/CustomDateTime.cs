using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_in_CSharp
{
    public static class CustomDateTime
    {
        public static void GetDateOnly(string DateTimeString)
        {
            DateTime dt = DateTime.Parse(DateTimeString, System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine(dt);
        }
    }
}
