using System;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "saturday",
                "sunday",
                "monday",
                "tuesday",
                "wednesday",
                "thursday",
                "friday"
            };


            /*
             * For loop
             */
            Console.WriteLine("======================================");
            Console.WriteLine("for loop");
            Console.WriteLine("======================================");
            for (var i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }


            /*
             * While loop
             */

            Console.WriteLine("======================================");
            Console.WriteLine("while loop");
            Console.WriteLine("======================================");
            int number = 100;
            int pointer = 0;
            int[] odd = new int[100];

            while (pointer < number)
            {
                if (number % 2 != 0)
                {
                    odd[pointer] = number;
                    pointer++;
                }
                number--;
            }

            Console.WriteLine(odd);


            /*
             *do-while loop
             */

            Console.WriteLine("======================================");
            Console.WriteLine("do-while loop");
            Console.WriteLine("======================================");
            var num = 2335;

            do
            {
                Console.WriteLine(num);

                num /= 2;
            } while (num > 100);


            /*
             *foreach 
             */
            Console.WriteLine("======================================");
            Console.WriteLine("foreach loop");
            Console.WriteLine("======================================");
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}
