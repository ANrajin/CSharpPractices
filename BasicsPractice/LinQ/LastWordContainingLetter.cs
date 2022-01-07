using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class LastWordContainingLetter
    {
        public void Run()
        {
            //Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'
            var words = new List<string> { "cow", "dog", "elephant", "cat", "rat", "squirrel", "snake", "stork" };

            var result = from w in words orderby w ascending where w.Contains('e') select w;

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("\n");

            var result2 = words.OrderBy(w => w).Where(w => w.Contains('e')).LastOrDefault();
            Console.WriteLine(result2);
        }
    }
}
