using System;
using System.Collections;

namespace Non_Generic_Collections_in_CSharp
{
    public static class HashTable_in_CSharp
    {
        public static void HashTbl()
        {
            Hashtable openwith = new Hashtable();

            openwith.Add("txt", "notepad.exe");
            openwith.Add("bmp", "paint.exe");
            openwith.Add("dib", "paint.exe");
            openwith.Add("rtf", "wordpad.exe");


            // The Add method throws an exception if the new key is
            // already in the hash table.
            try
            {
                openwith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }


            var cities = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            cities.Remove("UK");

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            cities.Clear(); //removes all elements
        }
    }
}
