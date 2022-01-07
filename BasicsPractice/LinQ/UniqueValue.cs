using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class UniqueValue
    {
        public void Run()
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var result = from v in values group v by v into g where g.Count() == 1 select g;

            foreach(var r in result)
            {
                foreach(var g in r)
                {
                    Console.WriteLine(g);
                }
            }
        }
    }
}
