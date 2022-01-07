using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurrsiveFunction
{
    public class Fibonacci
    {
        //Formula: F(n-1) + F(n - 2);
        public void Run()
        {
            var x = int.Parse(Console.ReadLine());
            var n = 0;

            while(n < x)
            {
                int result = Fib(n);
                Console.WriteLine(result);
                n += 1;
            }
        }

        public int Fib(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                return (Fib(n - 1) + Fib(n - 2));
            }

        }
    }
}
