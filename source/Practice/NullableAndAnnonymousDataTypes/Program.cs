using System;

namespace NullableAndAnnonymousDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable datatype

            //int x = null; ->compile time error

            int? x = null;

            double? y = null;

            bool? t = null;

            string s = String.Empty;
            string? str = null;


            //checking and accessing nullable datatype value
            if (x.HasValue)
                Console.WriteLine(x.Value);



            //Annonymous object

            dynamic obj = new { name = "Rajin", age = 26, money = 100.00, isValid = true };
        }   
    }
}
