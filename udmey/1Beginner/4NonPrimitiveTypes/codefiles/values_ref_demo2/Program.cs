using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    
    public class Person2
    {
        public int Age;
    }
    class Program
    {   
        
        static void Main(string[] args)
        {
            // since we have value type(int) in method Increment it will copy the value of var numbers in another location and will add 10
            // This whole process will take place in stack
            var number = 5;
            Incrememt(number);
            Console.WriteLine(number);

            // Here we have refernce type (Person class object) so when we do MakeOld method it will copy the refernce to object p1 and it will add the age
            // Here the process takes place in heap except creation of reference which will happen in Stack
            Person2 Person2_obj = new Person2() { Age = 30 };
            MakeOld(Person2_obj);
            Console.WriteLine(Person2_obj.Age);
        }
        public static void Incrememt(int a)
        {
            a += 10;
        }
        public static void MakeOld(Person2 p1)
        {
            p1.Age += 20;
        }
    }
}
