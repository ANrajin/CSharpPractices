using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 200;

            //the IsGreaterThen is a custom made method, that will
            //only be available for int data type

            var result = i.IsGreaterThen(100);

            Console.WriteLine(result);

            var word = "computer";

            Console.WriteLine(word.Ucfirst());

            word = "hello world";

            Console.WriteLine(word.Ucwords());
        }
    }
}
