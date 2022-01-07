using System;

namespace CF_1030A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 1030A: In Search of an Easy Problem

            int n = int.Parse(Console.ReadLine());

            char[] i = new char[n];

            i = Console.ReadLine().ToCharArray();

            var result = "EASY";

            for(var k = 0; k < i.Length; k++)
            {
                if (i[k] == '1')
                {
                    result = "HARD";
                }
            }

            Console.WriteLine(result);
        }
    }
}
