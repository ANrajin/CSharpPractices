using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_in_CSharp
{
    public static class Class1
    {
        public static void AppendString()
        {
            StringBuilder str = new StringBuilder();

            while (true)
            {
                var word = Console.ReadLine();

                if (word == "exit")
                    break;
                else
                    //Append() will append string only
                    //AppendLine() append string with a new line
                    str.Append("<p>").Append(word).AppendLine("</p>");
            }

            Console.WriteLine(str.ToString());
        }
    }
}
