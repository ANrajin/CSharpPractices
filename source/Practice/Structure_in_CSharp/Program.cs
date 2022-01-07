using System;

namespace Structure_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //an object of the Coordinate structure is created using the new keyword.
            //It calls the default parameterless constructor of the struct,
            //which initializes all the members to their default value of the specified data type.

            Point p1 = new Point();

            p1.X = 2;
            p1.Y = 3;

            //Structure is value type dataType... 
            Point p2 = new Point();

            p2.X = 5;
            p2.Y = 6;

            Console.WriteLine($"X: {p1.X}, Y: {p1.Y}");

            Console.WriteLine($"X: {p2.X}, Y: {p2.Y}");



            /**
              * If you declare a variable of struct type without using new keyword, it does not call any constructor, so all the members remain unassigned. 
              * Therefore, you must assign values to each member before accessing them, otherwise, it will give a compile-time error.
             */
            Coordinates point;

            //Console.WriteLine(point.x); -> Compile time error

            point.x = 10;
            point.y = 20;

            Console.WriteLine($"X: {point.x}, Y: {point.y}");


            //struct can include static method
            NewPoint nw = NewPoint.GetOrigin();

            Console.WriteLine(nw.x); //0
            Console.WriteLine(nw.y); //0




            //Class is a Refernence type data type..
            PointClass p3 = new PointClass();

            p3.X = 10;
            p3.Y = 20;

            PointClass p4 = new PointClass();

            p4.X = 30;
            p4.Y = 60;

            Console.WriteLine($"X : {p3.X}, Y: {p3.Y}");

            Console.WriteLine($"X : {p4.X}, Y: {p4.Y}");
        }
    }
}
