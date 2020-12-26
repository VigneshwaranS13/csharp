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
            //for (var i =0; i <=10; i++)
            // {
            //     if ( i % 2 == 0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            /* same code in while loop
            var i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            } 
            */
           
            //while (true)
            //{
            //    Console.Write("Type your name ");
            //    var input = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(" @Echo " + input);
            //    }
            //} 
            // same program in differnt format
            while (true)
            {
                Console.Write("Type your name");
                var input = Console.ReadLine();
                if (!(string.IsNullOrWhiteSpace(input)))
                {
                    Console.WriteLine("@Echo  " + input);
                    continue;
                }
                break;
            }
        }


    }
}
