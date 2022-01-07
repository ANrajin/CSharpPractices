using System;

namespace CF_546A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-546A: Soldier and Bananas
            string[] x = Console.ReadLine().Split();

            int k = Convert.ToInt32(x[0]);
            int n = Convert.ToInt32(x[1]);
            int w = Convert.ToInt32(x[2]);

            int total = 0;

            for (var i = 1; i <= w; i++)
            {
                total += k * i;
            }

            //Math.Max(0, -5) : will convert the negetive int to zero
            //bcz maximum return number is 0,

            var borrow = Math.Max(0, total - n);

            Console.WriteLine(borrow);
        }
    }
}