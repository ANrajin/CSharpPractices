using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class DayNames
    {
        //Write a query that returns names of days
        public void Run()
        {
            //enum System.DaysOfWeeks
            IEnumerable<DayOfWeek> daynames = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

            foreach(var d in daynames)
            {
                Console.WriteLine(d);
            }
        }
    }
}
