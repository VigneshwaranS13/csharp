using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFundamentals 
{ 
    
    class Program
    {

        static void Main(string[] args)
        {
            //var builder = new StringBuilder();
            //builder.Append('-', 20);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 20);
            //Console.WriteLine(builder);
            //builder.Replace('-', '+');
            //Console.WriteLine(builder);
            //builder.Remove(0, 5);
            //Console.WriteLine(builder);
            //builder.Insert(0,new string('*',10));
            //Console.WriteLine(builder);

            //we can initialize the stringbuilder

            var builder = new StringBuilder("Hello World");
            builder.Append('-', 20);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 20);
            Console.WriteLine(builder);
            builder.Replace('-', '+');
            Console.WriteLine(builder);
            builder.Remove(0, 5);
            Console.WriteLine(builder);
            builder.Insert(0, new string('*', 10));
            Console.WriteLine(builder);


            //to access individual char

            Console.WriteLine("First char is : " +builder[0]);

            //all of the string buider method will return stringbuilder object,so we can directly call the object to next method
            var builder2 = new StringBuilder("Hello World3");
            builder2.Append('-', 20)
                    .AppendLine()
                    .Append("Heaer")
                    .AppendLine()
                    .Append('-', 20);
            Console.WriteLine(builder2);
        }



    }
}
