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
            // value type will create a copy of var with new memory location in stack
            var a = 5;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a :{0} b : {1}",a,b));// a=5,b=6

            /*reference type will copy of the refrence of the variable  which is present in heap to the stack
            so if we assign to other var then it will create another reference in stack which will refernce to
            the same heap memory location*/

            var numbers = new int[3] { 1, 2, 3 };
            var numbers2 = numbers;
            numbers2[0] = 200;
            Console.WriteLine(string.Format("numbers[0] is : {0} and  numbers2[0] :{1}", numbers[0], numbers2[0]));

        }
    }
}
