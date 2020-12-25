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
            var numbers = new List<int>();//pass values less than list count
            var smallests = GetSmallests(null, 0);//pass count as 3,-2,0,null and pass numbers as null

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
            if (list == null)
                throw new ArgumentNullException("count", "list cannot be null");
            
            if (count > list.Count || count <=0)//first one is to check the list count is max than the count and second conditon is to check count is non negative and greater than one
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of list count");
            
            
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
