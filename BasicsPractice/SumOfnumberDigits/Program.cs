using System;
using System.Linq;

namespace SumOfnumberDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //SumOfNumbers(n);

            //SumOfDigitsUsingWhileLoop(n);

            //int sum = SumOfDigitsUsingRecursion(n);
            //Console.WriteLine(sum);

            //SumOfDigitsUsingLinq(n);
        }

        static void SumOfNumbers(int n)
        {
            char[] num = n.ToString().ToCharArray();

            int result = default;

            for(var i = 0; i < num.Length; i++)
            {
                result += int.Parse(num[i].ToString());
            }

            Console.WriteLine(result);
        }

        static void SumOfDigitsUsingWhileLoop(int n)
        {
            int result = default;

            while(n > 0)
            {
                int lastDigits = n % 10;
                result += lastDigits;
                n /= 10;
            }

            Console.WriteLine(result);
        }

        static int SumOfDigitsUsingRecursion(int n)
        {
            if (n != 0)
                return n % 10 + SumOfDigitsUsingRecursion(n / 10);
            else
                return 0;
        }

        static void SumOfDigitsUsingLinq(int number)
        {
            var result = number.ToString().Select(n => int.Parse(n.ToString())).ToArray().Sum();

            Console.WriteLine(result);
        }
    }
}
