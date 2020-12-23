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
            //1 Write a program and ask the user to enter a few numbers separated by a hyphen. 
            //Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //display a message: "Consecutive"; otherwise, display "Not Consecutive".

            Console.WriteLine("Enter 5 numbers with hypen");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            var inputwithouthypen =input.Replace('-', ' ');
            var numbers = inputwithouthypen.Split(' ');
            var Numbers = new int[5];
            foreach(var number in numbers)
            {
                Numbers.Append(Convert.ToInt32(number));

            }
          
              for ( int i=0;i <= 5; i++)
                {
                    if(Numbers[i]-Numbers[i-1] == 1)
                    {
                        Console.WriteLine("Consecutive");
                    }
                else
                {
                    Console.WriteLine("Not Consecutive");
                }
                }
           

        }



    }
}
