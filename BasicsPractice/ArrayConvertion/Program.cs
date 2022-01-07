using System;

namespace ArrayConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Array Convertion";

            TwoD2OneD arr = new();

            int[] result = arr.Convert();

            OneD2TwoD arr2 = new();

            int[,] newResult = arr2.Convert();

            for(var i = 0; i < newResult.GetLength(0); i++)
            {
                for(var j = 0; j < newResult.GetLength(1); j++)
                {
                    Console.Write($"{newResult[i, j]}, ");
                    Console.WriteLine("----------------");
                }
            }
        }
    }
}
