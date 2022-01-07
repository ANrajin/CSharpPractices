using System;

namespace CF_344A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-344A: Magnets

            int n = Convert.ToInt32(Console.ReadLine());

            string[] i = new string[n];

            int group = 1;

            for(var j = 0; j < n; j++)
            {
                i[j] = Console.ReadLine();
            }

            for(var k = 1; k < i.Length; k++)
            {
                var prev = i[k - 1];

                if(prev != i[k])
                {
                    group++;
                }
            }

            Console.WriteLine(group);
        }
    }
}
