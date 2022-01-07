using System;

namespace ReverseANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseNumber();
            //ReverseString();
            //ReverseForeach();
            ReverseUsingArray();
        }

        static void ReverseNumber()
        {
            int number = int.Parse(Console.ReadLine());

            int reverse = default;

            while (number != 0)
            {
                int lastDigit = number % 10;

                reverse = (reverse * 10) + lastDigit;

                number /= 10;
            }

            Console.WriteLine(reverse);
        }

        static void ReverseString()
        {
            var str = Console.ReadLine();

            string reverse = default;

            for(var i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }

            Console.WriteLine(reverse);
        }

        static void ReverseForeach()
        {
            var str = Console.ReadLine();

            string reverse = default;

            foreach(var s in str)
            {
                reverse = s + reverse;
            }

            Console.WriteLine(reverse);
        }

        static void ReverseUsingArray()
        {
            char[] str = Console.ReadLine().ToCharArray();
            Array.Reverse(str);
            Console.WriteLine(new String(str));
        }
    }
}
