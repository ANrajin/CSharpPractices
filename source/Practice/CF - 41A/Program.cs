using System;

namespace CF___41A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF : 41A : Translation

            string s = Console.ReadLine();
            string t = Console.ReadLine();

            int len = t.Length - 1;

            string str = String.Empty;

            if (s.Length == t.Length)
            {
                for (var i = len; i >= 0; i--)
                {
                    str += s[i];
                }

                if (t == str)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
