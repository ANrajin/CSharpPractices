using System;

namespace RecurrsiveFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = int.Parse(Console.ReadLine());
            //PrintFun(i);

            //Fibonacci f = new Fibonacci();
            //f.Run();

            Factorial fc = new Factorial();
            fc.Run();
        }

        static void PrintFun(int test)
        {
            if (test < 1)
                return;
            else
            {
                PrintFun(test - 1);
                Console.WriteLine($"{test} ");
                return;
            }
        }
    }
}
