using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConvertion
{
    public class OneD2TwoD
    {
        public int[] InputOutput()
        {

            Console.WriteLine("Array Length");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            Console.WriteLine("array element");
            for(var i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        public int[,] Convert()
        {
            int[] arr = InputOutput();
            int x = default;
            int y = default;

            if(arr.Length % 2 != 0)
            {
                double z = arr.Length / 2d;

                x = (int)Math.Floor(z);
                y = (int)Math.Ceiling(z);
            }
            else
            {
                x = arr.Length / 2;
                y = arr.Length / 2;
            }

            int[,] arr2D = new int[x, y];

            for(var i = 0; i < x; i++)
            {
                for(var j = 0; j < y; j++)
                {
                    arr2D[i, j] = arr[i + j];
                }
            }

            return arr2D;
        }
    }
}
