using System;

namespace multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] t = new int[10, 10];

            int ind1 = 0;

            for(var i = 1; i <=10; i++)
            {
                int ind2 = 0;
                for (var j = 1; j <=10; j++)
                {
                    t[ind1, ind2] = j * i;

                    Console.Write(t[ind1, ind2++].ToString().PadRight(5, ' '));
                }

                ind1++;
                Console.WriteLine();
            }
        }
    }
}
