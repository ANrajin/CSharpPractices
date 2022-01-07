using System;
using System.Collections.Generic;

namespace RemoveDuplicateElementsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };

            List<int> tmp = new List<int>(arr1);

            for(var i = 0; i < tmp.Count; i++)
            {
                for(var j = 0; j < tmp.Count; j++)
                {
                    if (i == j) continue;

                    if (arr1[i] == arr1[j])
                        tmp.RemoveAt(j);
                }
            }

            arr1 = tmp.ToArray();

            foreach(var a in arr1)
            {
                Console.WriteLine(a);
            }
        }
    }
}
