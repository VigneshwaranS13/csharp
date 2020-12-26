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
           var name = "MS Dhoni";
           // with for loop
           for (var i = 0; i < name.Length; i++ )
            {
                Console.WriteLine(name[i]);
            }
            // with foreach

           foreach(var letter in name)
            {
                Console.WriteLine(letter);
            }

            // foreach for array

            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
