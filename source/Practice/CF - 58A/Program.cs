using System;

namespace CF___58A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF - 58A : Chat room
            //Wrong on test 5

            string s = Console.ReadLine().ToLower();

            string word = "hello";

            string search = word;

            string result = String.Empty;

            for(var i = 0; i < s.Length; i++)
            {
                if(!String.IsNullOrEmpty(s) && !String.IsNullOrEmpty(word))
                {
                    for (var j = 0; j < search.Length; j++)
                    {
                        if (s[i] == search[j])
                        {
                            result += s[i];
                            search = search.Remove(j, 1);
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if(result == word)
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
