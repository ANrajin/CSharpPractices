using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesOperation_18
{
    public class FileInfoClass
    {
        public void Run()
        {
            FileInfo fi = new FileInfo(@"F:\Temp\New.txt");

            //using (StreamWriter str = fi.CreateText())
            //{
            //    str.WriteLine("Hello From C-Sharp!");
            //    str.WriteLine("C-Sharp in robust");
            //    str.WriteLine("I love to solve problems in c#");
            //    str.Write("Hello");
            //    str.Write("\t World");
            //}

            //using (StreamWriter str = fi.AppendText())
            //{
            //    str.WriteLine("Hello From C#!");
            //    str.WriteLine("C-Sharp in awesome");
            //    str.WriteLine("I love to code in c#");
            //}

            //using(StreamReader sr = fi.OpenText())
            //{
            //    var s = "";

            //    while((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //Console.WriteLine(fi.Extension);

            //Console.WriteLine(fi.DirectoryName);
        }
    }
}
