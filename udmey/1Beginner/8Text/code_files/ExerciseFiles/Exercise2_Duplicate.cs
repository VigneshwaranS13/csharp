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
            /** Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses
            Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so,
            display "Duplicate" on the console. **/

            Console.WriteLine("Enter few numbers with hypen : ");
            var Input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Input))
            {
                Console.WriteLine("No values has been entered");
                
            }
            else
            {
                var buffer = Input.Replace('-', ' ');
                var Numbers = buffer.Split(' ');
                if(Numbers.Distinct().Count() ==Numbers.Count() )
                {
                    Console.WriteLine("No duplicates");
                }
                else
                {
                    Console.WriteLine("It has duplicates");
                }
           
            }





        }



    }
}
