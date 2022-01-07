using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();


            //Euclidean Approch
            int a = int.Parse(n[0]);
            int b = int.Parse(n[1]);

            if (a > b)
                PrintGCD(a, b);
            else
                PrintGCD(b, a);
        }

        public static void PrintGCD(int a, int b)
        {
            int remainder = a % b;

            int result = default;

            while (remainder != 0)
            {
                result = remainder;
                remainder = b % remainder;
            }

            Console.WriteLine(result);
        }
    }
}
