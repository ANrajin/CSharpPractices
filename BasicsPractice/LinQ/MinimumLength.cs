using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class MinimumLength
    {
        public void Run()
        {
            //Write a query that returns words at least 5 characters long and make them uppercase.

            List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat" };

            var result = animals.Where(a => a.Length >= 5).Select(a => a.ToUpper());

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
