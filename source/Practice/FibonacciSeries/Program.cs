using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the nth number of the Fibonacci Series: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.Write("{0} ", UsingRecursiveMethod(i));
            }

            Console.WriteLine(NthFibonacciNumber(number));
            Console.ReadKey();
        }


        public static int UsingNonRecursive(int num)
        {
            var oldVal = 0;
            var newVal = 0;

            var result = 1;

            while (result < num)
            {
                Console.WriteLine(result);

                oldVal = newVal;
                newVal = result;
                result = oldVal + newVal;
            }

            return result;
        }


        public static int UsingRecursiveMethod(int n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            return UsingRecursiveMethod(n - 1) + UsingRecursiveMethod(n - 2);
        }


        public static void UsingRecursiveMethodTwo(int firstnumber, int secondnumber, int counter, int length)
        {
            if (counter <= length)
            {
                Console.Write("{0} ", firstnumber);
                UsingRecursiveMethodTwo(secondnumber, firstnumber + secondnumber, counter + 1, length);
            }
        }


        //Find nth Fibonacci Number
        public static int NthFibonacciNumber(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (NthFibonacciNumber(n - 1) + NthFibonacciNumber(n - 2));
            }
        }
    }
}
