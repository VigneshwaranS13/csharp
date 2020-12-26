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
            //3 Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00). A valid
            //time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".
            //If the user doesn't provide any values, consider it as invalid time.
            Console.WriteLine("Enter a time in 24 hour format : " );
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                //Console.WriteLine("Need to check proceed futher");
                try
                {
                    DateTime time1 = Convert.ToDateTime(input);
                    Console.WriteLine("ok");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid Time");
                    //Console.WriteLine("Error was " + e);                    
                }                
            }
            

        
        }



    }
}
