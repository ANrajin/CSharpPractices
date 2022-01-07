using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_in_CSharp
{
    class Generic_List_T
    {
        public string[] animals;

        public Generic_List_T()
        {
            animals = new string[]{ "Lion", "Tiger", "Deer" };
        }

        public static void AddAuthors()
        {
            //Generic list automatically expand it's size
            List<string> authors = new List<string>();

            authors.Add("John");
            authors.Add("Martin");
            authors.Add("Rowling");

            Console.WriteLine(authors.Capacity);

            Console.WriteLine(authors.Count);

            //insert at a index
            authors.Insert(4, "Bill Author");

            string[] newAuthors = { "New Author1", "New Author2", "New Author3" };

            // Insert array at position 2  
            authors.InsertRange(2, newAuthors);

            // Remove an item  
            authors.Remove("New Author1");

            // Remove 3rd item  
            authors.RemoveAt(3);

            // Remove a range starting from a specified position
            authors.RemoveRange(3, 2);

            // Remove all items  
            authors.Clear();

            //The IndexOf method finds an item in a List. The IndexOf method returns -1 if there are no items found in the List. 
            //authors.indexOf()
            //authors.lastindexOf()


            /*
             * The Sort method of List<T> sorts all items of the List using the QuickSort algorithm.
             */

            Console.WriteLine("Original List items");
            Console.WriteLine("===============");
            // Print original order  
            foreach (string a in authors)
                Console.WriteLine(a);
            // Sort list items  
            authors.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted List items");
            Console.WriteLine("===============");
            // Print sorted items  
            foreach (string a in authors)
                Console.WriteLine(a);

            // Reverse list items  
            authors.Reverse();
            Console.WriteLine();


            /*
             *The BinarySearch method of List<T> searches a sorted list and returns the zero-based index of the found item.
             *The List<T> must be sorted before this method can be used. 
             */
            int bs = authors.BinarySearch("Mahesh Chand");
        }

        public void AddRangeMethod()
        {
            //Use the AddRange() method to add all the elements from an array or another collection to List

            List<string> animalsList = new List<string>();

            animalsList.AddRange(animals);

            foreach(string a in animalsList)
            {
                Console.WriteLine(a);
            }
        }
    }
}
