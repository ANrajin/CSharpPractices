using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularRotationOfArrayElements
{
    public static class LeftCircularRotation
    {
        public static void Rotate(int[] items)
        {
            int[] arr = items;

            for (var i = 0; i < arr.Length - 1; i++)
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }

            StringBuilder _result = new StringBuilder();

            foreach (var a in arr)
            {
                _result.Append($"{a}, ");
            }

            //remove the last comma and space
            _result.Remove(_result.Length - 2, 2);

            Console.WriteLine(_result);
        }
    }
}
