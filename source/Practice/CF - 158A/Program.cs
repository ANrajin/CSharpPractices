using System;

namespace CF___158A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 158A : Next Round

            string[] x = Console.ReadLine().Split();
            string[] a = Console.ReadLine().Split();

            int n = int.Parse(x[0]);
            int k = int.Parse(x[1]) - 1;

            int result = 0;

            if(n == a.Length)
            {
                for (var i = 0; i < a.Length; i++)
                {
                    if (int.Parse(a[i]) > 0)
                    {
                        if (int.Parse(a[i]) >= int.Parse(a[k]))
                            result += 1;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
