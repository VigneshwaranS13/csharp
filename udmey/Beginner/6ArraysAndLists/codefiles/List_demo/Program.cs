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

            //Lists
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);
            numbers.AddRange(new int[4] { 6, 7, 8, 9 });
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            numbers.Add(3);
            Console.WriteLine("index of 3 is "+numbers.IndexOf(3));
            Console.WriteLine("Last Index of 3 is " +numbers.LastIndexOf(3));
            Console.WriteLine("count" + numbers.Count);
            numbers.Remove(3);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Removal of list objects ");
            //Let's try to remove all the 3s from the app

            //foreach (var number in numbers)
            //{
            //    if(number == 3)
            //    {
            //        numbers.Remove(number);
            //    }
            //}

            // application will crash for above code 
            //because in csharp  we cannot modify the collection inside foreach loop
            //same can be done via for loop
            for (var i = 0; i <numbers.Count; i++)
            {
                if(numbers[i]==3)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Before clearing count was : " + numbers.Count);
            numbers.Clear();//will remove all elements from the list
            Console.WriteLine("after clearing count was  : "+numbers.Count);
        }

    }
}
