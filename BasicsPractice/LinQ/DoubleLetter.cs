using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class DoubleLetter
    {
        //Write a query that returns double letters sequence in format: AA AB AC ... ZX ZY ZZ
        public void Run()
        {
            var dblLetters = Enumerable.Range((char)65, 26)
                .SelectMany(x => Enumerable.Range((char)65, 26).Select(y => (char) x + "" + (char) y));

            foreach(string d in dblLetters)
            {
                Console.WriteLine(d);
            }
        }
    }
}
