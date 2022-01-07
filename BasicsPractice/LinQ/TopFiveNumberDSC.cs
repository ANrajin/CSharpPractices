using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class TopFiveNumberDSC
    {
        public void Run()
        {
            List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };

            var result = numbers.OrderByDescending(n => n).Take(5);

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
