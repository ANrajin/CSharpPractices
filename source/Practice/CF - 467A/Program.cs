using System;

namespace CF___467A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 467A : George and Accommodation

            int n = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for(var i = 0; i < n; i++)
            {
                string[] x = Console.ReadLine().Split();

                int p = Convert.ToInt32(x[0]);
                int q = Convert.ToInt32(x[1]);

                int a = q - p;

                //as there need to have 2 places in the room, for both of them
                if(a >= 2 )
                {
                    result += 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}
