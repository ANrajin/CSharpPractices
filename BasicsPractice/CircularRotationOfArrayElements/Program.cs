using System;

namespace CircularRotationOfArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter total number of element");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the elements by space separate");
            int[] arr = new int[length];

            for (var i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            LeftCircularRotation.Rotate(arr);

            Console.WriteLine("=================================");

            RightCircularRotation.Rotate(arr);
        }
    }
}
