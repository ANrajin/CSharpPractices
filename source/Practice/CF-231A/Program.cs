using System;

namespace CF_231A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code Forces : 231A - Team

            int n, Petya, Vasya, Tonya, count;

            n = int.Parse(Console.ReadLine());

            count = 0;

            for(int i = 0; i < n; i++)
            {
                //split the string saparated by whitespace

                string[] x = Console.ReadLine().Split();

                Petya = int.Parse(x[0]);
                Vasya = int.Parse(x[1]);
                Tonya = int.Parse(x[2]);

                if (Petya + Tonya + Vasya >=2)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
