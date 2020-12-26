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
            var numbers = new int[3] { 1, 2 };
            // int[] numbers = new int[3];
            numbers[2] = 30;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var bools = new bool[3];

            bools[1] = true;
            bools[0]= false;
            Console.WriteLine(bools[0]);
            Console.WriteLine(bools[1]);
            Console.WriteLine(bools[2]);


            var letters = new string[3];
            Console.WriteLine(letters[0]);
            Console.WriteLine(letters[1]);
            Console.WriteLine(letters[2]);
        }
    }
}
