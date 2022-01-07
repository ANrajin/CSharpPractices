using System;

namespace CF_791A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-791A : Bear and Big Brother

            string[] inp = Console.ReadLine().Split();

            int a = Convert.ToInt32(inp[0]);
            int b = Convert.ToInt32(inp[1]);

            var result = 1;

            for (; ; )
            {
                a = a * 3;
                b = b * 2;

                if (a > b)
                    break;
                result += 1;
            }

            Console.WriteLine(result);
        }
    }
}