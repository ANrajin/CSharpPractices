using System;

namespace CF_122A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 122A : Lucky Division

            bool lucky = false;

            long n = long.Parse(Console.ReadLine());

            if (n % 4 == 0 || n % 7 == 0)
                lucky = true;

            if (!lucky)
            {
                string num = n.ToString();

                for (var i = 0; i < num.Length; i++)
                {
                    var x = num[i] == '4' || num[i] == '7';

                    if (!x)
                    {
                        lucky = false;
                        break;
                    }
                    else
                    { 
                        lucky = true;
                        break;
                    }
                }
            }

            Console.WriteLine(lucky ? "YES" : "NO");
        }
    }
}
