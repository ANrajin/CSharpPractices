using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class DecryptNumberTask
    {
        public void Run()
        {
            //Given a non-empty string consisting only of special chars (!, @, # etc.),
            //return a number (as a string) where each digit corresponds to given special
            //char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).

            var chars = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };

            var encryptedNumber = "#(@*%)$(&$*#&";

            var result = string.Join("", encryptedNumber.Select(e => Array.IndexOf(chars, e)));

            Console.WriteLine(result);
        }
    }
}
