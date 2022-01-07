using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();

            SolutionOne(sentence);
            SolutionTwo(sentence);
            SolutionThree(sentence);
            SolutionFour(sentence);
        }

        static void SolutionOne(string sentence)
        {
            string[] str = sentence.Split(" ");

            StringBuilder result = new();//equivalent to --> new StringBuilder();

            foreach(string s in str)
            {
                int length = s.Length - 1;

                for(var i = length; i >= 0; i--)
                {
                    result.Append(s[i]);

                    if (i == 0)
                        result.Append(" ");
                }
            }

            Console.WriteLine(result);
        }

        //Using Stack to Reverse Each Word in C#
        static void SolutionTwo(string sentence)
        {
            Stack<char> characterStack = new();

            for(var i = 0; i < sentence.Length; i++)
            {
                //push each character to stack untill there is any space character
                if(sentence[i] != ' ')
                    characterStack.Push(sentence[i]);
                else
                {
                    //stack follow LIFO
                    //if there any space, pop all char
                    while(characterStack.Count > 0)
                    {
                        Console.Write(characterStack.Pop());
                    }
                    Console.Write(" ");
                }
            }

            //print the last world
            while(characterStack.Count > 0)
            {
                Console.Write(characterStack.Pop());
            }

            Console.WriteLine();
        }

        //Using linq
        static void SolutionThree(string sentence)
        {
            string reverse = String.Join(" ", sentence.Split(' ')
            .Select(s => new String(s.Reverse().ToArray())));

            Console.WriteLine(reverse);
        }

        //Using built in methods
        static void SolutionFour(string sentence)
        {
            string[] str = sentence.Split();

            foreach(string s in str)
            {
                foreach(var result in s.Reverse())
                {
                    Console.Write(result);
                }
                Console.Write(" ");
            }
        }
    }
}
