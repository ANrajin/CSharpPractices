using System;

namespace CF_112A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-112A: Petya and Strings
            string str1 = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();

            for(var i = 0; i < str1.Length; i++)
            {
                char str1Search = str1[i];
                char str2Search = str2[i];

                string str1New = str1.Remove(i, 1);
                string str2New = str2.Remove(i, 1);

                for(var j = 0; j < str1New.Length; j++)
                {
                    if(str1New[j] == str1Search)
                    {
                        int lastIndex = str1.LastIndexOf(str1Search);
                        str1 = str1.Remove(lastIndex, 1);
                    }

                    if (str2New[j] == str2Search)
                    {
                        int lastIndex = str1.LastIndexOf(str1Search);
                        str2 = str2.Remove(lastIndex, 1);
                    }
                }
            }

            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
