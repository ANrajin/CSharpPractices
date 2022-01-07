using System;

namespace CF___1A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 1A: Theatre Square

            string[] x = Console.ReadLine().Split();

            double n = (double) long.Parse(x[0]);
            double m = (double)long.Parse(x[1]);
            int a = int.Parse(x[2]);

            double p = n / a;
            double q = m / a;
            double r = Math.Ceiling(p) * Math.Ceiling(q);

            long result = (long) r;

            Console.WriteLine(result);
        }
    }
}
