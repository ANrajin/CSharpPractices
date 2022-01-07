using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesOperation_18
{
    class Static_File_Class
    {
        public void Run()
        {
            //	File is a "static" class that provides different functionalities like copy, create, move, delete, open for reading or /writing,
            //	encrypt or decrypt, check if a file exists, append lines or text to a file�s content, get last access time, etc.

            //To read all text from a file
            //var text = File.ReadAllText("mytext.txt");

            //Console.WriteLine(text);

            //Write into a file
            //var content = "Hello from CSharp. C# is awesome!";
            //File.WriteAllText("files/newtext.txt", content);

            //Read line, return as array
            //var text2 = File.ReadAllLines("mytext.txt");
            //Console.WriteLine(text2);

            /**
             *AppendAllLines -> Appends lines to a file, and then closes the file. 
             *If the specified file does not exist, this method creates a file, writes the specified lines to the file, and then closes the file.
             */
            //Opens SampleFile.txt and append lines. If file is not exists then create and open.
            //List<string> str = new List<string>()
            //{
            //    "This is first line.",
            //    "This is second line.",
            //    "This is third line."
            //};
            //File.AppendAllLines(@"F:\SampleFile.txt", str);

            /**
             * AppendAllText -> Opens a file, appends the specified string to the file, and then closes the file. 
             * If the file does not exist, this method creates a file, writes the specified string to the file, then closes the file.
             */

            /**
             * AppendText -> Creates a StreamWriter that appends UTF-8 encoded text to an existing file, 
             * or to a new file if the specified file does not exist.
             */


            /***
             * Copy	Copies an existing file to a new file. 
             * Overwriting a file of the same name is not allowed.
             */

            //Copy DummyFile.txt as new file DummyFileNew.txt
            //File.Copy(@"F:\SampleFile.txt", @"E:\1.Class-Works\DummyFile.txt");


            /**
             * Create -> Creates or overwrites a file in the specified path.
             * 
             */
            File.Create(@"F:\Temp\New.txt");


            /**
             * Delete -> Deletes the specified file.
             * 
             */
            //File.Delete(@"E:\1.Class-Works\NewFile.docx");


            /**
             * Exists -> Determines whether the specified file exists.
             * return bool
             */
            //var x = File.Exists(@"F:\SampleFile.txt");
            //Console.WriteLine(x);

            /**
             * Move -> Moves a specified file to a new location, providing the option to specify a new file name.
             * also we can overwrite existing file;
             */
            //File.Move(@"F:\SampleFile.txt", @"E:\1.Class-Works\NewSampleFile.txt");
        }
    }
}
