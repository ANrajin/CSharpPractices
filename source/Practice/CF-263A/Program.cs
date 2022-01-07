using System;

namespace CF_263A
{
    class Program
    {
        static void Main(string[] args)
        {
            //unsolved
            //CF-263A: Beautiful Matix

            int[,] matrix = new int[5,5];

            int count = 0;

            for(var i = 0; i < matrix.GetLength(0); i++)
            {
                string[] num = Console.ReadLine().Split();

                for(var j = 0; j < num.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(num[j]);
                }
            }
        }
    }
}
