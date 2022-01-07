using System;

namespace Record_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new();
            p1.X = 10;
            p1.Y = 20;

            Point p2 = p1;

            Console.WriteLine(p2.X);
            Console.WriteLine(p2.Y);
        }
    }
}
