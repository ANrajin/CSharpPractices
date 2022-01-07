using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class NumberFromRange
    {
        public void Run()
        {
            int[] arr = new int[] { 67, 92, 153, 15 };

            //var result = from a in arr where a > 30 && a < 100 select a;
            //var result = arr.Where(a => a > 30 && a < 100).ToList();
            var result = arr.Where(a => a > 30).Where(a => a < 100).ToList();

            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
