using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW();

            Console.WriteLine(bmw.Speed());
        }
    }
}
