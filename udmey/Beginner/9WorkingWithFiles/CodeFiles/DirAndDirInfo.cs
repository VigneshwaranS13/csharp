using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFundamentals 
{ 
    
    class Program
    {

        static void Main(string[] args)
        {
            var path = @"D:\ps\csharp\source\Servers";
            var destination = @"D:\ps\csharp\destination\Servers";

            //Directory

            Directory.CreateDirectory(path);//It will automatically overwrite  the folder if it exists
            Directory.CreateDirectory(destination);

            var directories = Directory.GetDirectories(@"D:\ps\", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            //DirectoryInfo
            Console.WriteLine("****************************************DirectoryInfo**************************************");
            var dirinfo = new DirectoryInfo(@"D:\ps\");
            var dirs = dirinfo.GetDirectories();// GetDirectories method will return Array,so we need to assign and iterate to access individual elements

            foreach(var dir in dirs)
            {
                Console.WriteLine(dir);
            }







        }



    }
}
