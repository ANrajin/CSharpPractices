using System;

namespace FactorialOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the factorial of a number

            int num = Convert.ToInt32(Console.ReadLine());

            //using non recursive way
            var factorial = NonRecursiveMethod(num);

            var factorial2 = UsingRecursiveMethod(num);

            Console.WriteLine($"The factorial of {num} is : {factorial}");

            Console.WriteLine($"The factorial of {num} is : {factorial2}");
        }


        //A static method can call only a static method
        public static int NonRecursiveMethod(int num)
        {
            var factorial = 1;

            if (num < 1)
                return 1;

            for (var i = num; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }


        //Using a recursive function
        //A recursive function is a function that call it self
        public static int UsingRecursiveMethod(int num)
        {
            if (num < 1)
                return 1;

            return num * UsingRecursiveMethod(num - 1);
        }
    }
}
