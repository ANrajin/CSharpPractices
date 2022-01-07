using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularRotationOfArrayElements
{
    public static class RightCircularRotation
    {
        public static void Rotate(int[] items)
        {
            int[] arr = items;

            for (var i = arr.Length - 1; i > 0 ; i--)
            {
                int temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
            }

            StringBuilder _result = new StringBuilder();

            foreach(var a in arr)
            {
                _result.Append($"{a}, ");
            }

            //Remove the comma and space from last
            _result.Remove(_result.Length - 2, 2);

            Console.WriteLine(_result);
        }
    }
}
