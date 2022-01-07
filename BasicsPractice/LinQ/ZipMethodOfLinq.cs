using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class ZipMethodOfLinq
    {
        //Write a query that returns dot product of two arrays.
        public void Run()
        {
            int[] array1 = new int[] { 5, 8, 2, 9 };
            int[] array2 = new int[] { 1, 7, 2, 4 };

            //The Linq Zip Method in C# is used to apply a specified function to the corresponding
            //elements of two sequences and producing a sequence of the results.
            int result = array1.Zip(array2, (a, b) => a * b).Sum();

            Console.WriteLine(result);
        }
    }
}
