using System;
using System.Collections.Generic;
using System.Text;



namespace CSharpFundamentals
{

    class Program
    {

        static void Main(string[] args)
        {
            //  4 Write a program and ask the user to enter a few words separated by a space. Use the words to create a
            //variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
            //Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the
            //program should still display "NumberOfStudents".
            Console.WriteLine("Enter few words with space ");
            var input = Console.ReadLine();

            var buffer = input;
            //Console.WriteLine(buffer);
            Console.WriteLine();
            var words = buffer.Split(' ');
            var results = new List <string>();
            foreach(var word in words)
            {
                //Console.WriteLine(word);
                //results.Add(char.ToUpper(word[0]) +word.Substring(1));
                results.Add(char.ToUpper(word[0]) + word.Substring(1).ToLower());
            }
            //foreach(var result in results)
            //{
            //    Console.WriteLine(result);
            //}
            string.Join("", results);
            Console.WriteLine();
            Console.WriteLine(string.Join("", results));



        }



    }
}
