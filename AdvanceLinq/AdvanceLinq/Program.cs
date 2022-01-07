using System;
using System.Linq;
using AdvanceLinq.CustomQuery;

namespace AdvanceLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 6, 3, 4, 9, 8, 2, 7, 1};

            //the query will not execute immidiatly
            //var result = from n in numbers where n > 5 orderby n ascending select n;
            //var result = numbers.Where(n => n > 5);
            var result = numbers.NewWhere(n => n > 5);

            //the query only executes when it is being iterate
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        
        }
    }
}
