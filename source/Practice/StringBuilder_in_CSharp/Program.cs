using System;
using System.Text;

namespace StringBuilder_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //String builder helps us to modify an existing string, for memory allocation

            //StringBuilder str = new StringBuilder();

            //Class1.AppendString();

            //Console.WriteLine();

            //Class2.GetExecutionTimeUsingString();
            //Class2.GetExcutionTimeUsingStringBuilder();

            StringBuilder str = new StringBuilder("Hello World");

            //remove
            Console.WriteLine(str.Remove(2, 3));

            //insert
            Console.WriteLine(str.Insert(2,"lp"));

            //replace
            Console.WriteLine(str.Replace('l', 'a'));
            Console.WriteLine(str.Replace("ap", "ll"));

            //
            Console.WriteLine(str.MaxCapacity);

            //Removes all characters from current StringBuilder
            Console.WriteLine(str.Clear());


        }
    }
}
