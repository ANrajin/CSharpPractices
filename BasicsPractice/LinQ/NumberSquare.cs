using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class NumberSquare
    {
        public void Run()
        {
            //Write a query that returns list of numbers and their squares only if square is greater than 20
            List<int> Numbers = new List<int> { 3, 9, 2, 4, 6, 5, 7 };

            var result = from n in Numbers where n * n > 20 select n;

            foreach(var r in result)
            {
                Console.WriteLine($"{r} -> {r*r}");
            }
        }
    }
}
