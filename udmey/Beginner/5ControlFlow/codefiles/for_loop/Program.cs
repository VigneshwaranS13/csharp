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
           
            // To print odd or even number within 10
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2  == 0)
                {
                    Console.WriteLine(string.Format("Even number : {0}",i));
                }
                else
                {
                    Console.WriteLine(string.Format("Odd number : {0}",i));
                }
            }

            // To reverse the order
            for (var i = 10; i >=1; i--)
            {
                if( i % 2 ==0 )
                {
                    Console.WriteLine(string.Format("even number : {0}", i));
                }

                else
                {
                    Console.WriteLine(string.Format("odd number : {0}", i));
                }
            }
            
        }
    }
}
