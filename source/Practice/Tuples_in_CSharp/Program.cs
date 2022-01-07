using System;

namespace Tuples_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] results = new int[100, 100];
            int count = 0;

            //using struct
            //Point[] points = new Point[100];

            //using tuple
            (int x, int y)[] points = new (int x, int y)[100];

            for(var i = 0; i < 100; i++)
            {
                for(var j = 0; j < 100; j++)
                {
                    //points[count++] = new Point() { x = i, y = j };
                }
            }

            int result = 0;

            for(var i = 0; i <count; i++)
            {
                result += (points[i].x * points[i].y) + (points[i].x / points[i].y);
            }



            //GetData()

            //using tuple datatype
            (string[] data, int count) abc = GetData();

            //using var
            var xyz = GetData();

            Console.WriteLine(xyz.count);

            foreach(var item in xyz.data)
            {
                Console.WriteLine(item);
            }
        }


        //use tuple as method's return type
        public static (string[] data, int count) GetData()
        {
            string[] data = new string[] { "Hello", "Dhaka" };
            int count = 20;

            return (data, count);
        }
    }
}
