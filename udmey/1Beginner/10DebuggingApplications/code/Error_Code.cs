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
            var numbers = new List<int> { 7, 8, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach(var number in smallests)
                Console.WriteLine(number);

        }

        public static List<int> GetSmallests(List<int> list ,int count )
        {
            var smallests = new List<int>();
            smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for(var i = 1;i<list.Count;i++)
            {
                if (list[i] > min) ;
            }
            return min;
        }

    }
}
