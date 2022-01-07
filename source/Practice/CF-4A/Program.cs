using System;

namespace CF_4A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem: 4A - Watermelon
            int w = int.Parse(Console.ReadLine());

            if (w % 2 == 0 && w > 2)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
