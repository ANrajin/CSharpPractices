using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class UppercaseOnly
    {
        //Write a query that returns only uppercase words from string.
        public void Run()
        {
            string word = "THIS is UPPERCASE string LOL";

            //first split the sentence and match each words with their uppercase version
            IEnumerable<string> result = word.Split().Where(w => String.Equals(w, w.ToUpper()));

            foreach(string r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
