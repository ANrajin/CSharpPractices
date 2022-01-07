using System;

namespace CF___110A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 110A : Nearly Lucky Number

            char[] luckyDigits = new char[] { '4', '7' };

            string n = Console.ReadLine();

            int count = 0;

            for(var i = 0; i < n.Length; i++)
            {
                for(var j = 0; j < luckyDigits.Length; j++)
                {
                    if(n[i] == luckyDigits[j])
                    {
                        count += 1;
                    }
                }
            }

            if(count == 4 || count == 7)
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
