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
            var firstname = "MS";
            var lastname = "dhoni";
            var fullname = string.Format("My favaourite crickter is {0} {0}", firstname, lastname);
            Console.WriteLine(fullname);

            var names = new string[3] { "MS", "Dhnoi", "Forever" };
            var combined = string.Join(",", names);
            Console.WriteLine(combined);

            var text1 = "Hi\nHow are you?\nHow was your day\nPFB path for file in my system\nC:\\windows\\project\\file1.txt";
            Console.WriteLine(text1);

            // Verbatim string
            var text2 = @"Hi
How are you?
How was your day
PFB path for file in my system
C:\windows\project\file1.txt";
            Console.WriteLine(text2);


        }
    }
}
