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
            //var random = new Random();

            //for (var i = 0; i <= 10; i++)
            //    Console.Write((char)random.Next(97, 122));

            //Console.WriteLine((int)'a'); // 97
            //Console.WriteLine((int)'z'); // 122

            //for (var i = 0; i <= 10; i++)
            //    Console.Write((char)('a'+random.Next(0, 26)));
            //    Console.WriteLine();
            //    Console.Write(('a' + random.Next(0, 26)));// when we add a charcter to the number  the result it going to be a number
            //Console.WriteLine();

            var random = new Random();
            var passwordLength = 10;
            char[] buffer = new char[passwordLength];

            for (var i=0;i < passwordLength; i++)
                buffer[i] =(char)('a'+ random.Next(0,26));
            var password = new string(buffer);
            Console.WriteLine(password);



        }



    }
}
