using System;

namespace CF_617A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 617A : Elephant

            int x = Convert.ToInt32(Console.ReadLine());
            int steps = 5;

            int move = x / steps;

            if (x % 5 > 0)
                move++;

            Console.WriteLine(move);
        }
    }
}