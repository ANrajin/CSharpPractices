using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne<ClassOne> n = new TaskOne<ClassOne>(new ClassOne());

            var x = n.Data.CallPrivate("Hello World");

            Console.WriteLine(x);
        }
    }
}
