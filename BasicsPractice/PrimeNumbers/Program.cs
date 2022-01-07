using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i <= x/2; i++)
            {
                if(x%i == 0)
                {
                    Console.WriteLine("Prime Number");
                }
                else
                {
                    Console.WriteLine("Composite Number");
                }
            }
        }
    }
}
