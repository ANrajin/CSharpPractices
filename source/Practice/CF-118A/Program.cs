using System;

namespace CF_118A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code Forces 118A - String Task

            string str = Console.ReadLine();

            str = str.ToUpper();

            char[] vowels = new char[] { 'A', 'O', 'Y', 'E', 'U', 'I' };

            //split the string by the vowels and than concate again
            str = String.Concat(str.Split(vowels)).ToLower();

            string result = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                result += "." + str[i];
            }

            Console.WriteLine(result);
        }
    }
}
