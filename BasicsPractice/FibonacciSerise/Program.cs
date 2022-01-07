using System;

namespace FibonacciSerise
{
    class Program
    {
        static void Main(string[] args)
        {
            //FibonacciUsingForLoop();

            int i = 10;
            int n = 0;

            while( n <= i)
            {
                var result = FibonacciUsingRecurrsive(n);
                Console.WriteLine(result);
                n += 1;
            }
        }

        static void FibonacciUsingForLoop()
        {
            int oldValue = default;
            int newValue = default;
            var result = 1;

            for(var i = 0; i <= 10; i++)
            {
                if(i >= 2)
                {
                    oldValue = newValue;
                    newValue = result;
                    result = oldValue + newValue;

                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

        static int FibonacciUsingRecurrsive(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                return (FibonacciUsingRecurrsive(n - 1) + FibonacciUsingRecurrsive(n - 2));
            }
        }
    }
}
