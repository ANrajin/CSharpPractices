using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicateCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            //Remove all duplicate char
            SolutionOne(str);
            SolutionTwo(str);
            SolutionThree(str);

            //Remove duplicate characters, except (' ') char
            ExceptSpaceChar(str);
        }

        static void SolutionOne(string str)
        {
            string _result = String.Empty;

            for(var i = 0; i < str.Length; i++)
            {
                if (!_result.Contains(str[i]))
                    _result += str[i];
            }

            Console.WriteLine(_result);
        }

        //Using Hashset<T> to remove duplicate character
        static void SolutionTwo(string str)
        {
            HashSet<char> unique = new(str);
            string _result = String.Empty;

            foreach(var c in unique)
            {
                _result += c;
            }
            Console.WriteLine(_result);
        }

        //using LINQ query
        static void SolutionThree(string str)
        {
            char[] _char = str.ToCharArray().Distinct().ToArray();


            string _result = new String(_char);

            Console.WriteLine(_result);
        }

        static void ExceptSpaceChar(string str)
        {
            string _result = String.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                if (_result.Contains(str[i]))
                {
                    //check whether result string's last character is not char
                    if (str[i] == ' ' && _result[_result.Length - 1] != ' ')
                        _result += str[i];
                    else
                    {
                        continue;
                    }
                }
                else
                    _result += str[i];
            }

            Console.WriteLine(_result);
        }
    }
}
