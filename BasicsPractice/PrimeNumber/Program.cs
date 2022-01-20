using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //NthPrimeNumbers();
            PrimeOrNot();
        }

        static void NthPrimeNumbers()
        {
            int n = int.Parse(Console.ReadLine());

            for (var i = 2; i <= n; i++)
            {
                int flag = 0;

                for (var j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                    Console.WriteLine(i);
            }
        }

        static void PrimeOrNot()
        {
            int n = int.Parse(Console.ReadLine());

            var isPrime = true;

            for(var i = 2; i <= n/2; i++)
            {
                if (n%i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(isPrime)
                Console.WriteLine("Prime number");
            else
                Console.WriteLine("Not prime number");
        }
    }
}
