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
            var path = @"D:\ps\csharp\source\Servers.txt";
            var destination = @"D:\ps\csharp\destination\Servers.txt";
            
            //File calss

            if(File.Exists(destination))
            {
                File.Delete(destination);
            }                        
            File.Copy(path, destination);//It will not overwrite the exisintg file            
            File.Copy(path, destination, true);// It will overwrite the if the file is already exist
            var content = File.ReadAllText(destination); ;
            Console.WriteLine(content);//it will print the contents in the file

            //FileInfo class

            var fileInfo = new FileInfo(path);

            
            //fileInfo.CopyTo(destination);
            fileInfo.CopyTo(destination, true);

            if(fileInfo.Exists)
            {
                fileInfo.Delete();//This will permanently delete the source file 
            }





            



        }



    }
}
