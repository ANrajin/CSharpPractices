using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(var i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("While loop \n");

            int n = 1;
            while(n <= 10)
            {
                int result = n * number;
                Console.WriteLine($"{number} x {n} = {result}");
                n++;
            }


            Console.WriteLine("\n");
            Console.WriteLine("Do While loop \n");

            n = 1;

            do
            {
                int result = n * number;
                Console.WriteLine($"{number} x {n} = {result}");
                n++;
            } while (n <= 10);


            Console.WriteLine("\n");
            Console.WriteLine("Recursive \n");

            n = 1;

            Recursive(number, n);
        }

        public static void Recursive(int number, int i)
        {
            if (i > 10)
                return;

            int result = number * i;

            Console.WriteLine($"{number} x {i} = {result}");

            Recursive(number, i + 1);
        }
    }
}
