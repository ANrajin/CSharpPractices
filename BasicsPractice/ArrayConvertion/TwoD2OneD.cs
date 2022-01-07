using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConvertion
{
    public class TwoD2OneD
    {
        //Two dimension array 2 one dimension
        public int[] Convert()
        {
            int[,] arr = new int[2, 3]
            {
                {2,3,4},
                {9,8,7}
            };

            int numberOfRows = arr.GetLength(0);
            int numberOfColumns = arr.GetLength(1);

            int index = 0;
            int[] arr1D = new int[numberOfRows * numberOfColumns];

            for(var i = 0; i < numberOfRows; i++)
            {
                for(var j = 0; j < numberOfColumns; j++)
                {
                    arr1D[index] = arr[i, j];
                    index += 1;
                }
            }

            return arr1D;
        }
    }
}
