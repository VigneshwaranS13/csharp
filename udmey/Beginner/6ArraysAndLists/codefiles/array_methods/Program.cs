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
            var ary1 = new [] { 1, 2, 3, 4, 5 };

            // Length

            Console.WriteLine(" Length : " + ary1.Length);

            /** ary1.Length --instance member which means its not static
            Array.Clear -- this is static method in array class which can be directly accessible **/


            // IndexOf

            var position = Array.IndexOf(ary1, 3);
            Console.WriteLine("index of number 3 is : " + position);

            //Clear

            Array.Clear(ary1, 0, 2);
            Console.WriteLine("Effect of clear()");
            foreach (var i in ary1)
                Console.WriteLine(i);

            //Copy

            var another = new int[3];

            Array.Copy(ary1, another, 3);
            Console.WriteLine("Effect of copy");
            foreach (var i in another)
                Console.WriteLine(i);

            // Sort

            Array.Sort(ary1);
            Console.WriteLine("Effect of sort()");
            foreach (var i in ary1)
                Console.WriteLine(i);
            // Reverse

            Array.Reverse(another);

            Console.WriteLine("Effect of reverse()");
            foreach (var i in another) 
                    Console.WriteLine(i);


        }

    }
}
