using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Example01
    {
        //Most frequent character
        public void Run()
        {
            //Write a query that returns most frequent character in string. Assume that there is only one such character.

            string str = "49fjs492jfJs94KfoedK0iejksKdsj3";

            var result = str.GroupBy(s => s).OrderByDescending(s => s.Count()).First().Key;

            Console.WriteLine(result);
        }
    }
}
