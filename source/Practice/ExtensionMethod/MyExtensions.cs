using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class MyExtensions
    {
        public static bool IsGreaterThen(this int i, int value)
        {
            return i > value;
        }

        public static string Ucfirst(this string word) => word.Replace(word[0], word.ToUpper()[0]);

        public static string Ucwords(this string word)
        {
            string[] w = word.Split();

            string str = string.Empty;

            foreach(var s in w)
            {
                str += $"\t{s.Ucfirst()}";
            }

            return str;
        }
    }
}
