using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesOperation_18
{
    public class Static_Directory_Class
    {
        public void Run()
        {
            string root = @"F:\Temp";

            //-create
            //Directory.CreateDirectory(root);

            //-Check if exist
            //var n = Directory.Exists(root);
            //Console.WriteLine(n);

            //-Delete
            //Directory.Delete(root);

            //-Move
            //string dest = @"F:\torrents\New";
            //Directory.Move(root, dest);

            //-Get the files in a directory
            //var files = Directory.GetFiles(@"F:\books");

            //foreach(var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //-Get current directory
            //Console.WriteLine(Directory.GetCurrentDirectory());

            //-Get all directory in a folder
            //var path = Directory.GetFiles(@"F:\");

            //var d = Directory.GetDirectories("");

            //foreach(var dir in d)
            //{
            //    Console.WriteLine(dir);
            //}

            //- Get the root directory of any directory
            //Console.WriteLine(Directory.GetDirectoryRoot(root));

            //- Get parent of any directory
            //Console.WriteLine(Directory.GetParent(root));

            //-Get all the logical drive on system
            //var drives = Directory.GetLogicalDrives();

            //foreach(var drive in drives)
            //{
            //    Console.WriteLine(drive);
            //}
        }
    }
}
