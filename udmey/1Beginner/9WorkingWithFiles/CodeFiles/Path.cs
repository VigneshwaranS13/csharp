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
            var path = @"D:\ps\csharp\source\Servers\Servers.txt";
            
            // String processing for accessing path from strings
            var index = path.IndexOf('.');
            var fileext = path.Substring(index);
            Console.WriteLine("File extension " + fileext);
            Console.WriteLine();
            // using path class
            Console.WriteLine("Using Path Class");
            Console.WriteLine();
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("FileName ext : " + Path.GetExtension(path));
            Console.WriteLine("FileName without extensin : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("DirectoryName :  " + Path.GetDirectoryName(path));





        }



    }
}
