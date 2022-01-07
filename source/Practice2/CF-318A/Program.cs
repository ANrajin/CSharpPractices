using System;

namespace CF_318A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF: 318A - Even Odds

            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            int[] x = new int[n];

            int index = 0;

            for(var i = 1; i <= n; i++)
            {
                if(i % 2 == 1)
                {
                    x[index++] = i;
                }
            }

            for (var i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    x[index++] = i;
                }
            }

            Console.WriteLine(x[--k]);
        }
    }
}
