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

            /** 4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.
              If the user guesses the number, display “You won"; otherwise, display “You lost".
              (To make sure the program is behaving correctly, you can display the secret number on the console first.)
             **/
            var randomnumber = new Random();
            var correctnumber = randomnumber.Next(1, 10);
            Console.WriteLine(correctnumber);
          
            for(var i = 1 ;i <= 4 ; i++ ) 
            {
                Console.WriteLine("Guess any number bw one to ten : ");
                var guessednumber = Convert.ToInt32(Console.ReadLine());
                if (guessednumber == correctnumber)
                {
                    if (i > 1)
                    {
                        Console.WriteLine("You won ! You used " + i + " guesses");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You won ! You used 1 guess");
                        break;
                    }
                }
                else
                {
                    if (i == 4)
                    {
                        Console.WriteLine("You used all of your 4 guesses,The correct number is " + correctnumber);
                    }
                    else
                    {
                        continue;
                    }
                        
                }
                
            }
            

        }
    }
}
