using System;

namespace KeywordsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2147483647;
            int b = 2147483647;

            int c = a + b; //will print -2
            int d = checked(a + b); //checked() will throw an overflow exception
            int e = unchecked(a + b); //unchecked() will not throw an exception and doesnot print any thing

            Console.WriteLine(c);
            //Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
