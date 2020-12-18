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

            //// 1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

            int total = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    total++;
                }
            }
            Console.WriteLine("Total numbers that can be divided by 3 is : " + total);

            //// 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered 
            //// numbers and display it on the console.
            var number = 0;
            var count = 0;
            while (true)
            {

                Console.WriteLine("Enter number to play or ok to stop");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                else
                {
                    number = Convert.ToInt32(input);
                    count = count + number;
                    continue;
                }
            }
            Console.WriteLine("Total count is " + count);

        }
    }
}
