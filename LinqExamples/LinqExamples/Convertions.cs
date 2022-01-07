using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Convertions
    {
        public int ConvertToArray()
        {
            #region conver-to-array
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var sortedDouble = (from d in doubles orderby d descending select d).ToArray();

            Console.WriteLine("Every other double from highest to lowest:");

            for (int d = 0; d < sortedDouble.Length; d += 2)
            {
                Console.WriteLine(sortedDouble[d]);
            }

            #endregion
            return 0;
        }

        public int ConvertToList()
        {
            #region Convert-to-list
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = (from w in words orderby w descending select w).ToList();

            Console.WriteLine("The sorted word list:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
            #endregion
            return 0;
        }

        public int ConvertToDictionary()
        {
            #region Convert-to-dictionary
            //annonymous object array
            var scoreRecords = new[] { new {Name = "Alice", Score = 50},
                                new {Name = "Bob"  , Score = 40},
                                new {Name = "Cathy", Score = 45}
                            };
            var result = scoreRecords.ToDictionary(sr => sr.Name);

            Console.WriteLine("Bob's score: {0}", result["Bob"]);
            #endregion
            return 0;
        }

        public int ConvertSelectedItems()
        {
            #region convert-to-type
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

            var result = numbers.OfType<double>();

            Console.WriteLine("Numbers stored as doubles:");
            foreach (var d in result)
            {
                Console.WriteLine(d);
            }

            #endregion
            return 0;
        }
    }
}
