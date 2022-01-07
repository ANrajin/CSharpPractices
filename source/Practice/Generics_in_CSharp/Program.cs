using System;

namespace Generics_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            NewGeneric<string> str = new NewGeneric<string>();

            str.Field = "Rajin";

            Console.WriteLine(str.Field);

            NewGeneric<int> num = new NewGeneric<int>();

            num.Field = 100;

            Console.WriteLine(num.Field);
        }
    }
}
