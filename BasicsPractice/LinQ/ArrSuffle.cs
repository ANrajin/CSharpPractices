using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class ArrSuffle
    {
        public void Run()
        {
            //Write a query that shuffles sorted array.
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var rnd = new Random();

            var result = array.OrderBy(i => rnd.Next());

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
