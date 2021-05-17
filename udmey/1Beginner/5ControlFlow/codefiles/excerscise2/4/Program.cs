using System;
using ConsoleApp1.Math;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type numbers with comma");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            
            var max = Convert.ToInt32(numbers[0]);
            foreach(var str in numbers)
            {
                
                if (Convert.ToInt32(str) > max)
                    max = Convert.ToInt32(str);
                
            }
            Console.WriteLine(max);
        }

    } 
    
}