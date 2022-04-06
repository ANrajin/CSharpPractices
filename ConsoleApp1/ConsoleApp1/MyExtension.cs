using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MyExtension
    {
        public static string Ucfirst(this string str) => str.Replace(str[0], str.ToUpper()[0]);

        public static string UcWord(this string str, string value)
        {
            string[] strr = value.Split();
            var result = string.Empty;

            for(var i = 0; i < strr.Length; i++)
            {
                result += strr[i].ToUpper();
            }

            return result;
        }
    }
}
