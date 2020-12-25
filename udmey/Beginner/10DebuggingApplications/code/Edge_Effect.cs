using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFundamentals 
{ 
    
    class Program
    {

        static void Main(string[] args)
        {
            var numbers = new List<int> { 7, 8,9,15,5,3};
            var smallests = GetSmallests(numbers, 3);

            foreach(var number in smallests)
                Console.WriteLine(number);

            Console.WriteLine("Oriningal list");
            //Edge code check
            foreach (var number in numbers)
                Console.WriteLine(number);
            // so it will remove the inputs 

        }

        public static List<int> GetSmallests(List<int> list ,int count )
        {
            //to avoid edge effect
            var buffer = new List<int>(list);//for avoiding edge effect 
            var smallests = new List<int>();
            smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);//we chaged from list to buffer
                smallests.Add(min);
                buffer.Remove(min);//we chaged from list to buffer
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for(var i = 1;i<list.Count;i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }

    }
}
