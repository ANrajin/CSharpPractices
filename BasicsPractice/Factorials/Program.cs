using System;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            //the the factors of a number will never be grater then its half
            for(var i = 1; i <= number/2; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //using while loop
            Console.WriteLine("\n");
            Console.WriteLine("while \n");

            int n = 1;
            int num = number / 2;

            while(n <= num)
            {
                if(number%n == 0)
                    Console.WriteLine(n);
                n++;
            }

            //using do while
            Console.WriteLine("\n");
            Console.WriteLine("do while \n");
            n = 1;

            do
            {
                if(number % n == 0)
                    Console.WriteLine(n);

                n++;
            } while (n <= num);


            Console.WriteLine("\n");
            Console.WriteLine("Recursive \n");
            n = 1;
            Recursive(number, n);
        }

        //using recursive function
        public static void Recursive(int num, int i)
        {
            if (i > num / 2)
                return;
            else if(num % i == 0)
                Console.WriteLine(i);

            Recursive(num, i+1);
        }
    }
}
