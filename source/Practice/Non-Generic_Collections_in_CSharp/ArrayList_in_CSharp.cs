using System;
using System.Collections;

namespace Non_Generic_Collections_in_CSharp
{
    public static class ArrayList_in_CSharp
    {
        public static void ArrList()
        {
            //array list are not type safe
            //it can take any datatype
            //it's size increases automatically

            ArrayList arrList = new ArrayList();

            arrList.Add(1);
            arrList.Add("Hello");
            arrList.Add(4.20);
            arrList.Add(null);
            arrList.Add("");
            arrList.Add(true);


            //Use the AddRange(ICollection c) method to add an entire Array,
            //HashTable, SortedList, ArrayList, BitArray, Queue, and Stack in the ArrayList.

            ArrayList arList = new ArrayList();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            string[] str = new string[] { "Hello", "World" };

            Queue que = new Queue();
            que.Enqueue("Hello");
            que.Enqueue("World");

            arList.AddRange(arrList);
            arList.AddRange(arr);
            arList.AddRange(str);
            arList.AddRange(que);


            //The ArrayList class implements the IList interface.
            //So, elements can be accessed using indexer, in the same way as an array.
            //Index starts from zero and increases by one for each subsequent element.

            var a = arrList[0];
            string b = (string) arrList[1];

            var c = arList[0];
            var d = arList[2];


            //The ArrayList implements the ICollection interface that supports iteration of the collection types.
            //So, use the foreach and the for loop to iterate an ArrayList.
            //The Count property of an ArrayList returns the total number of elements in an ArrayList.

            foreach(var item in arrList)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < arrList.Count; i++)
                Console.Write(arrList[i] + ", ");

            Console.WriteLine();
        }


        //Insert Elements in ArrayList
        public static void InsertInArrayList()
        {
            ArrayList arrList = new ArrayList() { 1, "Hello", 5.00, true };

            //Use the Insert() method to insert an element at the specified index into an ArrayList.
            arrList.Insert(1, "World");

            foreach(var item in arrList)
            {
                Console.WriteLine(item);
            }
        }


        //Remove Elements from ArrayList
        public static void RemoveFromArrayList()
        {
            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };

            arList.Remove(null); //Removes first occurance of null
            arList.RemoveAt(4); //Removes element at index 4
            arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
        }


        //Check Element in ArrayList
        public static void ContainsInArrayList()
        {
            ArrayList arList = new ArrayList()
                {
                    1,
                    "Bill",
                    300,
                    4.5f,
                    300
                };

            Console.WriteLine(arList.Contains(300)); // true
            Console.WriteLine(arList.Contains("Bill")); // true
            Console.WriteLine(arList.Contains(10)); // false
            Console.WriteLine(arList.Contains("Steve")); // false
        }
    }
}
