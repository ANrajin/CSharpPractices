using System;

namespace CF___677A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 677A : Vanya and Fence

            string[] x = Console.ReadLine().Split();

            int n = Convert.ToInt32(x[0]);
            int h = Convert.ToInt32(x[1]);

            string[] a = Console.ReadLine().Split();

            int result = 0;

            for(var i = 0; i < n; i++)
            {
                if (Convert.ToInt32(a[i]) > h)
                {
                    result += 2;
                }
                else
                {
                    result += 1;
                }
            }


            Console.WriteLine(result);
        }
    }
}
