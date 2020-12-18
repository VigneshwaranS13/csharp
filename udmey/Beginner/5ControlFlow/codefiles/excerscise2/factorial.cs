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

            /**
            3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            **/
            Console.WriteLine("Enter any number : ");
            var number = Convert.ToInt32(Console.ReadLine());
            var fact = 1d;
            if (number <= 1)
            {
                Console.WriteLine("Factorial is " + fact);
            }
            else
            {
                while (number != 1)
                {
                    fact = fact * number;
                    number = number - 1;
                    continue;
                }
                Console.WriteLine("Factorial is " + fact);
            }
        }
    }
}
