using System;

namespace CF_69A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-69A: Young Physicist
            int n, x, y, z, sumX, sumY, sumZ;

            n = int.Parse(Console.ReadLine());

            sumX = 0;
            sumY = 0;
            sumZ = 0;

            for (var i = 0; i < n; i++)
            {
                string[] coordinates = Console.ReadLine().Split();

                x = Convert.ToInt32(coordinates[0]);
                y = Convert.ToInt32(coordinates[1]);
                z = Convert.ToInt32(coordinates[2]);

                sumX += x;
                sumY += y;
                sumZ += z;
            }

            if(sumX == 0 && sumY == 0 && sumZ == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
