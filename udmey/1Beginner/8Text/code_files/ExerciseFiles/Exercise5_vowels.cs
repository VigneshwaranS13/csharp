using System;
using System.Collections.Generic;
using System.Text;



namespace CSharpFundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            //5 Write a program and ask the user to enter an English word. Count the number of vowels(a, e, o, u, i)
            //in the word. So, if the user enters "inadequate", the program should display 6 on the console.

            Console.WriteLine("Enter any word : ");
            var input = Console.ReadLine();
            int count = 0;

            for(var i =0;i <input.Length;i++)
            {
                if(input[i]=='a' || input[i] == 'e'|| input[i] == 'i'|| input[i] == 'o'|| input[i] == 'u')
                {
                    count++;
                }

            }
            Console.WriteLine("total number of vowels is : " + count);

        }



    }
}
