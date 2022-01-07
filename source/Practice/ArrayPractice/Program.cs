using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * References
             * https://www.geeksforgeeks.org/c-sharp-arrays/?ref=lbp
             * 
             */



            //Single dimension
            //array contains only one row for storing the values.
            int[] intArr = new int[5];
            intArr[0] = 10;
            intArr[1] = 20;
            intArr[2] = 30;
            intArr[3] = 40;
            intArr[4] = 50;

            string[] strArr = new string[5] { "sat", "sun", "mon", "tues", "wed" };

            //We can declare an array without initializing its size
            float[] floatArr = { 2.3F, 0.36F, 3.65F };

            Console.WriteLine(intArr[1]);
            Console.WriteLine(strArr[3]);

            //length of the array
            int arrLength = intArr.Length;
            Console.WriteLine("the lenght of the array is: {0}", arrLength);

            //Size of array
            int arrSize = strArr.Rank;
            Console.WriteLine("total array size {0}", arrSize);

            //Multi dimension array. 2D, 3D, 4D
            //int[,] intArr2D = new int[number of arrays, size of each array];
            // in multi dimension array each array size sould be same
            int[,] intArr2D = new int[2, 4];
            intArr2D[0, 0] = 10;
            intArr2D[0, 1] = 20;
            intArr2D[0, 2] = 30;
            intArr2D[0, 3] = 40;

            intArr2D[1, 0] = 50;
            intArr2D[1, 1] = 60;
            intArr2D[1, 2] = 70;
            intArr2D[1, 3] = 90;

            //string[,,] strArr3D = new string[2, 3, 3]
            string[,,] strArr3D = new string[,,]
            {
                {
                    {"one", "two", "three" },
                    {"one", "three", "four" },
                    {"one", "four", "five"}
                },
                {
                    {"two", "six","eight" },
                    {"two", "seven", "nine" },
                    {"two", "ten", "eleven" }
                }
            };

            //Array.GetLength(Int32) Method is used to find the total number of elements present in the specified dimension of the Array.
            int getArrLength = strArr3D.GetLength(1);
            Console.WriteLine("Get Length: " + getArrLength);

            //int[,,,] intArr4D = new int[,,,];
            int[,,,] intArr4D = new int[4, 3, 2, 2]
            {
                //1st dimension. Size 4
                {
                    //2nd dimension. size 3
                    {
                        //third dimension size 2 and each array wil contain 2 integer
                        { 10, 20},
                        { 30, 40 }
                    },
                    {
                        {50, 60 },
                        { 80, 90}
                    },
                    {
                        {100, 110 },
                        { 120, 130}
                    }
                },
                {
                    {
                        { 140, 150},
                        {160, 170 }
                    },
                    {
                        { 180, 190},
                        { 300, 220}
                    },
                    {
                        {500, 269 },
                        { 263, 750}
                    }
                },
                {
                    {
                        {540, 890 },
                        { 530, 870}
                    },
                    {
                        {640, 260 },
                        { 170, 280}
                    },
                    {
                        {660, 770 },
                        {880, 990 }
                    }
                },
                {
                    {
                        { 950, 850 },
                        { 650, 550}
                    },
                    {
                        {440, 880 },
                        {780, 980 }
                    },
                    {
                        {365, 465 },
                        {775, 995 }
                    }
                }
            };


            /*
             * Jagged Array
             * 
             * An array whose elements are arrays is known as Jagged arrays it means “array of arrays“.
             * The jagged array elements may be of different dimensions and sizes
             */

            int[][] intJaggedArr = new int[3][];
            intJaggedArr[0] = new int[2] { 10, 20 };
            intJaggedArr[1] = new int[3] { 50, 20, 30 };
            intJaggedArr[2] = new int[4] { 60, 20, 30, 80 };

            Console.WriteLine(intJaggedArr[0][1]);
            Console.WriteLine(intJaggedArr[1][2]);
            Console.WriteLine(intJaggedArr[2][3]);

            //without specifing the total array size
            int[][] intJaggedArr2 = new int[][]
            {
                new int[2] { 10, 20 },
                new int[3] { 50, 20, 30 },
                new int[4] { 60, 20, 30, 80 },
                new int[3] { 60, 20, 30 },
                new int[5] { 60, 20, 30, 70, 90 },
            };

            //Multidimentional Jagged Array
            int[][,] int2DJaggedArray = new int[][,]
            {
                new int[2,3]{ {10, 20, 30 }, { 40, 50, 60} },
                new int[2,3]{ {70, 80, 30 }, { 90, 100, 60} }
            };

            Console.WriteLine("Accessing the element: {0}", intJaggedArr2[1][2]);
            Console.WriteLine("Accessing the element: {0}", int2DJaggedArray[1][1, 2]);

            Console.WriteLine(int2DJaggedArray[0][0, 0]);

            Console.WriteLine("========================================");

            for (int i = 0; i < int2DJaggedArray.Length; i++)
            {
                for (int j = 0; j < int2DJaggedArray[i].GetLength(0); j++)
                {
                    for (int k = 0; k < int2DJaggedArray[j].Rank; k++)
                    {
                        Console.WriteLine(int2DJaggedArray[i][j, k]);
                    }
                }
            }
        }
    }
}
