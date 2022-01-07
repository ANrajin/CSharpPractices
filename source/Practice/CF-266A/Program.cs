using System;

namespace CF_266A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-266A: Stones on the Table

            int n = Convert.ToInt32(Console.ReadLine());
            string stones = Console.ReadLine();

            var count = 0;

            for(var i = 0; i < n; i++)
            {
                if((i+1 != n) && stones[i] == stones[i + 1])
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
