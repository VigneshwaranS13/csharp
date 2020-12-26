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
            Console.WriteLine("You entered the input as :" + input);

            var Strnumbers = input.Split('-');
            var Numbers = new List<int>();

            foreach (var number in Strnumbers)
            {
                int n = Convert.ToInt32(number);
                Numbers.Add(n);

            }
            foreach (var Number in Numbers)
            {
                Console.WriteLine(Number);
            }
            int count = 0;
            for (var i = 0; i < 4; i++)
            {
                if (Numbers[i + 1] - Numbers[i] == 1 || (Numbers[i + 1] - Numbers[i] == -1))
                {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("Consecutive");
                        break;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Not Consecutinve");
                    break;
                }
            }

            


        }



    }
}
