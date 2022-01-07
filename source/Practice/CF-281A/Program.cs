using System;

namespace CF_281A
{
    class Program
    {
        static void Main(string[] args)
        {
            //CF-281A: Word capitalization

            string word = Console.ReadLine();

            string first = word[0].ToString();

            word = word.Remove(0, 1);

            word = word.Insert(0, first.ToUpper());

            Console.WriteLine(word);
        }
    }
}
