using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class FrequencyOfLetters
    {
        //Write a query that returns letters and their frequencies in the string.
        public void Run()
        {
            string word = "abracadabra";

            IEnumerable<IGrouping<char, char>> result = word.GroupBy(w => w);

            foreach(IGrouping<char, char> r in result)
            {
                Console.WriteLine($"Letter {r.Key} occurs {r.Count()}");
            }
        }
    }
}
