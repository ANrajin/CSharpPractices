using System;

namespace CF___734A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF -734A: Anton and Danik

            int n = Convert.ToInt32(Console.ReadLine());
            char[] s = Console.ReadLine().ToUpper().ToCharArray();

            int anton = 0;
            int danik = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if(s[i] == 'A')
                {
                    anton += 1;
                }
                else  if(s[i] == 'D')
                {
                    danik += 1;
                }
            }

            if(anton > danik)
            {
                Console.WriteLine("Anton");
            }else if(danik > anton)
            {
                Console.WriteLine("Danik");
            }else if (anton == danik)
            {
                Console.WriteLine("Friendship");
            }
        }
    }
}
