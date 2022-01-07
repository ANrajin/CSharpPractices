using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    static class Fibonacci
    {
        public static int oldValue;
        public static int newValue;
        public static int result;

        static Fibonacci()
        {
            oldValue = 0;
            newValue = 0;
            result = 1;
        }


        public static void UsingRecursive(int num)
        {
            Console.WriteLine(result);

            oldValue = newValue;
            newValue = result;

            result = oldValue + newValue;

            if (result <= num)
            {
                UsingRecursive(num - 1);
            }
        }
    }
}
