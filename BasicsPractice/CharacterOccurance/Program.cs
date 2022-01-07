using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Character Occurrence in a String in C#

            string str = Console.ReadLine();

            //SolutionOne(str);
            //SolutionTwo(str);
            SolutionThree(str);
        }

        //using loop
        static void SolutionOne(string str)
        {
            string newStr = String.Concat(str.Split());

            while (newStr.Length > 0)
            {
                int count = default;

                for (var j = 0; j < newStr.Length; j++)
                {
                    if (newStr[0].ToString() == newStr[j].ToString())
                    {
                        count += 1;
                    }
                }

                Console.WriteLine($"Character {newStr[0].ToString()} occurs: {count} times");
                //Replace all occurance of specified character into empty
                newStr = newStr.Replace(newStr[0].ToString(), string.Empty);
            }
        }

        //Using Dictionary to Count the Number of n character Occurrences
        static void SolutionTwo(string str)
        {
            //Dictionary<Character, OccurenceTime>
            Dictionary<char, int> dictonary = new Dictionary<char, int>();

            str = String.Concat(str.Split());

            foreach(char c in str)
            {
                //If the character already exist in the dictionary then we will increase it's value by 1
                //It not exist then add it in the dictionary
                if (dictonary.ContainsKey(c))
                    dictonary[c] += 1;
                else
                    dictonary.Add(c, 1);
            }

            foreach(char item in dictonary.Keys)
            {
                Console.WriteLine($"{item} Occurs: {dictonary[item]} times");
            }
        }


        //Using linq query
        static void SolutionThree(string str)
        {
            str = string.Concat(str.Split());

            //group each character, then count occurence
            var result = str.GroupBy(s => s).Select(s => (Item: s.Key, Count: s.Count()));

            foreach(var r in result)
            {
                Console.WriteLine($"{r.Item} Occurs: {r.Count} Times");
            }
        }
    }
}
