using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class SelectWords
    {
        public void Run()
        {
            //Write a query that returns words starting with letter 'a' and ending with letter 'm'.

            List<string> words = new List<string> { "alabam", "am", "balalam", "tara", "", "a", "axeliam", "39yo0m", "trol" };

            var result = words.Where(w => w.StartsWith('a') && w.EndsWith('m'));

            foreach(var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
