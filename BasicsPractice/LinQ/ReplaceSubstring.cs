using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class ReplaceSubstring
    {
        public void Run()
        {
            //Write a query that replaces 'ea' substring with astersik (*) in given list of words.

            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var result = from w in words select w.Replace("ea", "*");

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
