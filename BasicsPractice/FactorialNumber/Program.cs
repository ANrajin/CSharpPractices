using System;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //FactorialNumber(n);
            //FactorialNumberUsingWhile(n);

            long result = UsingRecursive(n);
            Console.WriteLine(result);
        }

        static void FactorialNumber(int n)
        {
            long result = 1;

            for(var i = 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }

        static void FactorialNumberUsingWhile(int i)
        {
            long result = 1;
            int x = 1;
            while (x <= i)
            {
                result *= x;
                x++;
            }

            Console.WriteLine(result);
        }

        static int UsingRecursive(int i)
        {
            if (i == 1)
                return i;
            else
                return i * UsingRecursive(i - 1);
        }
    }
}
