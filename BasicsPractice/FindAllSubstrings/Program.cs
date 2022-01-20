using System;
using System.Text;

namespace FindAllSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            //SolutionOne(str);
            Console.WriteLine();
            SolutionTwo(str);
        }

        static void SolutionOne(string str)
        {
            for(var i = 0; i < str.Length; i++)
            {
                StringBuilder _result = new StringBuilder(str.Length);

                for(var j = i; j < str.Length; j++)
                {
                    _result.Append(str[j]);

                    Console.Write($"{_result} ");
                }
            }
        }

        static void SolutionTwo(string str)
        {
            for(var i = 0; i < str.Length; i++)
            {
                for(var j = 0; j < str.Length - i; j++)
                {
                    Console.Write($"{str.Substring(i, j + 1)} ");
                }
            }
        }
    }
}
